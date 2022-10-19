using MyAdmin.Data.DataSource;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAdmin.Data.Repositories;
using MyAdmin.Business.Entities;
using MyAdmin.Presentation.Component;
namespace MyAdmin.Presentation.Admin.Views.Supplier
{
    public partial class ImportDetail : UserControl
    {
        private ProductImportImple productImportImple;
        private SuccessfullDialog successfullDialog;
        private int rowIndex = -1;
        private bool click = true;
        private int index = -1;
        public ImportDetail()
        {
            InitializeComponent();
        }


        private void ImportDetail_Load(object sender, EventArgs e)
        {
            productImportImple = new ProductImportImple();
            successfullDialog = new SuccessfullDialog();
            try
            {
                LoadData(productImportImple.ReadData());
                string sql = "select id,name from tblsupplier";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //DataRow item = dataTable.NewRow();
                //item[1] = "";
                //dataTable.Rows.InsertAt(item, 0);
                cboSupplier.DataSource = dataTable;
                cboSupplier.DisplayMember = "name";
                cboSupplier.ValueMember = "id";
                index = cboSupplier.SelectedIndex;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvProduct.CurrentCell.RowIndex;
            txtProductId.Text = dgvProduct.Rows[index].Cells[0].Value.ToString();
            txtName.Text = dgvProduct.Rows[index].Cells[1].Value.ToString();
            txtCost.Text = dgvProduct.Rows[index].Cells[2].Value.ToString();
        }
        private void dgvImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            click = false;
            btnAdd.Text = "កែប្រែ";
            rowIndex = dgvImport.CurrentCell.RowIndex;
            int id= int.Parse(dgvImport.Rows[rowIndex].Cells[0].Value.ToString());
            txtProductId.Text = id.ToString();
            txtQty.Text = dgvImport.Rows[rowIndex].Cells[1].Value.ToString();
            txtCost.Text = dgvImport.Rows[rowIndex].Cells[2].Value.ToString().Replace("$","");
            dtp.Text = dgvImport.Rows[rowIndex].Cells[3].Value.ToString();
            try
            {
                txtName.Text = productImportImple.Search(id).Name;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!txtSearchProduct.Text.Equals(""))
                    LoadData(productImportImple.Search(txtSearchProduct.Text.Trim()));
                else LoadData(productImportImple.ReadData());
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBox(txtProductId, txtName, txtQty,txtCost);
            dtp.Text = DateTime.Now.ToString("yyyy-MM-dd");
            click = true;
            btnAdd.Text = "បន្ថែម";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtProductId, txtQty, txtCost))
            {
                int proId = int.Parse(txtProductId.Text);
                int qty = int.Parse(txtQty.Text);
                double cost = double.Parse(txtCost.Text.Trim());
                string date = dtp.Text;
                if (click)
                {
                    //add
                    int index = FindID(proId);
                    if (index >= 0)
                    {
                        qty += int.Parse(dgvImport.Rows[index].Cells[1].Value.ToString());
                        dgvImport.Rows[index].Cells[1].Value = qty;
                        dgvImport.Rows[index].Cells[2].Value = cost.ToString("$#,##0.00");
                        dgvImport.Rows[index].Cells[3].Value = date;
                    }
                    else
                        dgvImport.Rows.Add(proId, qty, cost.ToString("$#,##0.00"), date);
                }
                else
                {
                    //update
                    ComfirmDialog c = new ComfirmDialog();
                    c.Text = "កែប្រែ";
                    c.Caption = "តើអ្នកចង់កែប្រែទិន្ន័យមែនទេ?";
                    dgvImport.Rows[rowIndex].Cells[1].Value = qty;
                    dgvImport.Rows[rowIndex].Cells[2].Value = cost.ToString("$#,##0.00");
                    dgvImport.Rows[rowIndex].Cells[3].Value = date;
                    rowIndex = -1;
                    btnAdd.Text = "បន្ថែម";
                }
                
                successfullDialog.Text = "ការរក្សារទុកទិន្ន័យ";
                successfullDialog.Caption = "ការរក្សារទុកទិន្ន័យទទួលបានជោគជ័យ";
                successfullDialog.Pbox = Properties.Resources.ok_100px;
                successfullDialog.ShowDialog();
                btnNew_Click(sender, e);
            }
        }
        private void btnCommit_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Import();
                InsertImportDetail(id);
                successfullDialog.Text = "ការរក្សារទុកទិន្ន័យ";
                successfullDialog.Caption = "ការរក្សារទុកទិន្ន័យទទួលបានជោគជ័យ";
                successfullDialog.Pbox = Properties.Resources.ok_100px;
                successfullDialog.ShowDialog();
                dgvImport.Rows.Clear();
            }
            catch (Exception ex)
            {
                successfullDialog.Text = "Error";
                successfullDialog.Caption = ex.Message;
                successfullDialog.Pbox = Properties.Resources.error_100px1;
                successfullDialog.ShowDialog();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvImport.Rows.RemoveAt(rowIndex);
            rowIndex = -1;
        }
        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyInput.InputFloating(e,txtCost);
        }
        private void ClearTextBox(params TextBox[] txt)
        {
            foreach(var txtItem in txt)
            {
                txtItem.Text = "";
                txt[0].Focus();
            }
        }
        private bool CheckTextBox(params TextBox[] txt)
        {
            foreach(var txtItem in txt)
            {
                if (txtItem.Text.Equals(""))
                {
                    txtItem.Focus();
                    return false;
                }
            }
            return true;
        }
        private void cboSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (dgvImport.RowCount > 0)
            {
                ComfirmDialog c = new ComfirmDialog();
                c.Text = "";
                c.Caption = "ប្រសិនបើអ្នកផ្លាស់ប្ដូរអ្នកផ្គត់ផ្គង់ទិន្ន័យនឹងបញ្ចូលទៅក្នុងប្រព្ធ័ន";
                c.ShowDialog();
                if (c.DialogResult.Equals(DialogResult.Yes))
                {
                    btnCommit_Click(sender, e);
                    index = cboSupplier.SelectedIndex;
                }
                else
                {
                    cboSupplier.SelectedIndex = index;
                }

            }
        }
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyInput.InputInteger(e);
        }
       
        private int FindID(int id)
        {
            int importId = -1;
            for(int i=0; i<dgvImport.RowCount; i++)
            {
                importId = int.Parse(dgvImport.Rows[i].Cells[0].Value.ToString());
                if (importId.Equals(id))
                    return i;
            }
            return -1;
        }
        private void LoadData(List<ProductImport> ls)
        {
            dgvProduct.DataSource = ls;
        }
        private string Import()
        {
            int supplierId = int.Parse(cboSupplier.SelectedValue.ToString());
            //string date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            string id = "";
            string sql = $"insert into tblimport(supId,employee,date,time) values({supplierId},'{Connection.NAME}','{DateTime.Now:yyyy-MM-d}', '{DateTime.Now:hh:mm:ss}')";
            SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.ExecuteNonQuery();
            sql = "SELECT @@Identity";
            sqlCommand = new SqlCommand(sql, Connection.DataCon);
            SqlDataReader r = sqlCommand.ExecuteReader();
            if (r.Read())
            {
                id = r[0].ToString();
            }
            sqlCommand.Dispose();
            r.Close();
            return id;

        }
        private void InsertImportDetail(string id)
        {
            string sql = "";
            for (int i = 0; i < dgvImport.RowCount; i++)
            {
                string proId = dgvImport.Rows[i].Cells[0].Value.ToString();
                string qty = dgvImport.Rows[i].Cells[1].Value.ToString();
                string cost = dgvImport.Rows[i].Cells[2].Value.ToString().Replace("$", "");
                string expire = dgvImport.Rows[i].Cells[3].Value.ToString();
                sql = $"insert into tblimportdetail values({id},{proId},{qty},{cost},'{expire}')";
                SqlCommand s = new SqlCommand(sql, Connection.DataCon);
                s.ExecuteNonQuery();
                s.Dispose();
            }
        }

        private void dgvImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvImport.Columns[e.ColumnIndex].Name.Equals("delete"))
            {
                dgvImport.Rows.RemoveAt(e.RowIndex);
                btnNew_Click(sender, e);
            }
        }
    }
}
