using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAdmin.Data.Repositories;
using MyAdmin.Business.Entities;
using MyAdmin.Data.DataSource;
using System.Data.SqlClient;
using MyAdmin.Presentation.Component;

namespace MyAdmin.Presentation.Sale
{
    public partial class FormSale : Form

    {
        private ProductImple productImple;
        private List<Product> ls;
        private int catId = 0;
        private double rate = 0;
        public FormSale()
        {
            InitializeComponent();
        }
        private void FormSale_Load(object sender, EventArgs e)
        {
            productImple = new ProductImple();
            ls = new List<Product>();
            txtUser.Text = Connection.NAME;
            timer1.Start();
            try
            {
                SetComboxCatId();
                catId = int.Parse(cboCatId.GetItemText(cboCatId.SelectedValue.ToString()));
                SetDataGrid(productImple.searchByCategory(catId));
                ProductSale.Rows = dgvOrder.Rows;
                ProductSale.Total = txtTotal;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetDataGrid(List<Product> ls)
        {
            int c = 1, r = 0;
            tableLayoutPanel.Controls.Clear();
            foreach (Product v in ls)
            {
                ProductSale p = new ProductSale();
                p.Pbox = Image.FromFile(v.Image);
                p.Id = v.ID;
                p.LblName = v.Name;
                p.LblSize = v.Size;
                p.LblPrice = v.Price.ToString("$#0.00");
                tableLayoutPanel.Controls.Add(p, c, r);
                c++;
                if (c > 3)
                {
                    c = 1;
                    r += 1;
                }
            }
        }
        private void SetComboxCatId()
        {
            string sql = "select id,name from tblcategory";
            SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //DataRow item = dataTable.NewRow();
            //item[0] = "ទំនិញទាំងអស់";
            //dataTable.Rows.InsertAt(item, 0);
            cboCatId.DataSource = dataTable;
            cboCatId.DisplayMember = "name";
            cboCatId.ValueMember = "id";
        }
        private void FormSale_FormClosing(object sender, FormClosingEventArgs e)
        {
            Connection.DataCon.Close();
            Application.Exit();
        }

        private void cboCatId_SelectedValueChanged(object sender, EventArgs e)
        {
            //catId = int.Parse(cboCatId.SelectedValue.ToString());

        }

        private void cboCatId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                catId = int.Parse(cboCatId.GetItemText(cboCatId.SelectedValue.ToString()));
                //MessageBox.Show(catId.ToString());
                SetDataGrid(productImple.searchByCategory(catId));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PrintReport(string id,double amount,double receive,double remain,double rate)
        {
           
            //r.SetHeader("txtSeller", Connection.NAME);
            List<ReportSale> ls = new List<ReportSale>();
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                string name = row.Cells[1].Value.ToString();
                int qty = int.Parse(row.Cells[2].Value.ToString());
                string size = row.Cells[3].Value.ToString();
                double price = double.Parse(row.Cells[4].Value.ToString().Replace("$", ""));
                var check = row.Cells[6].Value;
                int dis = 0;
                if (check != null)
                {
                    dis = int.Parse(check.ToString().Replace("%", ""));
                }

                ls.Add(new ReportSale(name, qty,size, price, dis));
            }
            double reil = amount * rate;
            ReportDetail r = new ReportDetail(Connection.NAME, id, reil, receive, remain, rate,ls);
            r.ShowDialog();
        }
        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtChange.Text.Equals(""))
                {
                    rate = double.Parse(txtChange.Text);
                    if (rate > 0)
                    {
                        Payment p = new Payment(TotalAmount(), rate);
                        if (p.ShowDialog() == DialogResult.OK)
                        {
                            //insert data into tblorder
                            string orderId = InsertOrder();

                            //insert data into tblorderdetail
                            InsertOrderDetail(orderId);
                            //print report
                            string date = DateTime.Now.ToString("yyyyMMdd");
                            PrintReport(date+orderId, p.Amount, p.Received, p.Remain, rate);
                            dgvOrder.Rows.Clear();
                        }
                    }
                }
                else
                {
                    SuccessfullDialog s = new SuccessfullDialog();
                    s.Text = "ប្រុងប្រយ័ត្ន";
                    s.Caption = "សូមបញ្ចូលអត្រាប្ដូរប្រាក់";
                    s.Pbox = Properties.Resources.error_100px1;
                    s.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InsertOrderDetail(string id)
        {
            string proId, qty, price, discount;
            string sql = "";
            for (int i=0; i<dgvOrder.RowCount; i++)
            {
                proId = dgvOrder.Rows[i].Cells[0].Value.ToString();
                qty = dgvOrder.Rows[i].Cells[2].Value.ToString();
                price = dgvOrder.Rows[i].Cells[4].Value.ToString().Replace("$", "");
                var check = dgvOrder.Rows[i].Cells[6].Value;
                if (check != null)
                {
                    discount = check.ToString().Replace("%","");
                }
                else
                {
                    discount = "0";
                }
                sql = $"exec create_order_detail {id},{proId},{qty},{price},{discount}";
                SqlCommand s = new SqlCommand(sql, Connection.DataCon);
                s.ExecuteNonQuery();
                s.Dispose();
            }
            
        }
        private string InsertOrder()
        {
            string id = "";
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            string time = DateTime.Now.ToString("HH:mm:ss");
            string sql = $"exec create_order '{Connection.NAME}','{date}','{time}'";
            SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
            sqlCommand.ExecuteNonQuery();
            sql = "SELECT @@Identity";
            sqlCommand = new SqlCommand(sql, Connection.DataCon);
            SqlDataReader r =sqlCommand.ExecuteReader();
            if (r.Read())
            {
                id = r[0].ToString();
            }
            sqlCommand.Dispose();
            r.Close();
            return id;
        }
        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrder.Columns[e.ColumnIndex].Name.Equals("btnDelete"))
            {
               
                int qty= int.Parse(dgvOrder.Rows[e.RowIndex].Cells[2].Value.ToString());
                if(qty > 1)
                {

                    var check = dgvOrder.Rows[e.RowIndex].Cells[6].Value;
                    int dis = 0;
                    if (check != null)
                    {
                        dis = int.Parse(dgvOrder.Rows[e.RowIndex].Cells[6].Value.ToString().Replace("%",""));
                    }
                    qty--;
                    dgvOrder.Rows[e.RowIndex].Cells[2].Value = qty;
                    double price = double.Parse(dgvOrder.Rows[e.RowIndex].
                        Cells[4].Value.ToString().Replace("$",""));
                    //dgvOrder.Rows[e.RowIndex].Cells[4].Value = price;
                    double total = (price * qty) -((price * qty) *dis)/100;
                    dgvOrder.Rows[e.RowIndex].Cells[5].Value = total.ToString("$#,##0.00");
                }
                else
                {
                    dgvOrder.Rows.RemoveAt(e.RowIndex);
                    //ProductSale.Rows.RemoveAt()
                }
                txtTotal.Text = TotalAmount().ToString("$#,##0.00");
                
            }
        }

        private void dgvOrder_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(dgvOrder.CurrentCell.ColumnIndex.Equals(6) && e.Control is ComboBox)
            {
                ComboBox comboBox = (ComboBox)e.Control;
                int rowIndex = dgvOrder.CurrentCell.RowIndex;
                if(comboBox != null)
                {
                    comboBox.SelectedIndexChanged -= new EventHandler(Combox_SelectedIndexChangedv);
                    comboBox.SelectedIndexChanged += new EventHandler(Combox_SelectedIndexChangedv);
                }
            }
        }

        private void Combox_SelectedIndexChangedv(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            int dis = int.Parse(combo.SelectedItem.ToString().Replace("%", ""));
            int qty = int.Parse(dgvOrder.Rows[dgvOrder.CurrentCell.RowIndex].Cells[2].Value.ToString());
            double price = double.Parse(dgvOrder.Rows[dgvOrder.CurrentCell.RowIndex].Cells[4].Value.ToString().Replace("$", ""));
            double total = qty * price;
            dgvOrder.Rows[dgvOrder.CurrentCell.RowIndex].Cells[5].Value = (total - (total * dis) / 100).ToString("$#,##0.00,");
            txtTotal.Text = TotalAmount().ToString("$#,##0.00");
        }
        private double TotalAmount()
        {
            double total = 0;
           for(int i=0; i < dgvOrder.RowCount; i++)
            {
                total += double.Parse(dgvOrder.Rows[i].Cells[5].Value.ToString().Replace("$",""));
            }
            return total;
        }

        private void txtChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyInput.InputFloating(e, txtChange);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            ComfirmDialog c = new ComfirmDialog();
            c.ControlBox = false;
            c.Caption = "តើអ្នកចង់ចាកចេញមែនទេ?";
            c.ShowDialog();
            if (c.DialogResult.Equals(DialogResult.Yes))
            {
                Connection.DataCon.Close();
                this.Dispose();
                new Login().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvOrder.Rows.Clear();
            txtTotal.Text = "$00.00";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
 }
