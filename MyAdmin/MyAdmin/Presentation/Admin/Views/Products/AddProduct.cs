using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAdmin.Data.Repositories;
using MyAdmin.Data.DataSource;
using MyAdmin.Presentation.Component;
using MyAdmin.Business.Entities;
using System.Data.SqlClient;


namespace MyAdmin.Presentation.Admin.Views.Products
{
    public partial class AddProduct : UserControl
    {
        private string catId = "";
        private bool click = true;
        private int id = 0;
        private ProductImple productImple;
        private SuccessfullDialog successfullDialog;
        public AddProduct(){
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            productImple = new ProductImple();
            successfullDialog = new SuccessfullDialog();
            cboSize.SelectedIndex = 0;
            try
            {
                RefreshData(productImple.ReadData());
                string sql = "select id,name from tblcategory";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                //DataRow item = dataTable.NewRow();
                //item[1] = "";
                //dataTable.Rows.InsertAt(item, 0);
                cboCatId.DataSource = dataTable;
                cboCatId.DisplayMember = "name";
                cboCatId.ValueMember = "id";
            }
            catch (Exception ex)
            {
                successfullDialog.Text = "Error";
                successfullDialog.ForeColor = Color.Red;
                successfullDialog.Caption = ex.Message;
                successfullDialog.Pbox = Properties.Resources.error_100px1;
                successfullDialog.ShowDialog();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBox(txtName, txtPrice,txtSearh);
            cboCatId.SelectedIndex = 0;
            cboSize.SelectedIndex = 0;
            pbox.Image = Properties.Resources.No;
            btnSave.Text = "រក្សាទុក";
            click = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtName, txtPrice)) {
                string name = txtName.Text.Trim();
                double price = double.Parse(txtPrice.Text.Trim());
                string size = cboSize.SelectedItem.ToString();
                string img = ofd.FileName;
                try
                {
                    string msg = "";
                    bool result = false;
                    Image image = Properties.Resources.error_100px1;
                    Color c = Color.Red;
                    if (click)
                    {
                        //save
                        if (img.Equals(""))
                            img = "People/No.jpg";
                        result = productImple.CreateData(new Product(0, name, int.Parse(catId), price, img, size));
                    }
                    else
                    {
                        //update
                        ComfirmDialog comfirmDialog = new ComfirmDialog();
                        comfirmDialog.Caption = "តើអ្នកចង់កែប្រែទិន្ន័យមែនទេ?";
                        comfirmDialog.ShowDialog();
                        if (comfirmDialog.DialogResult.Equals(DialogResult.Yes))
                        {
                            result = productImple.UpdateData(new Product(id, name, int.Parse(catId), price, img, size));
                            btnSave.Text = "រក្សាទុក";
                            click = true;
                            id = 0;
                        }
                    }
                    if (result)
                    {
                        msg = "ការរក្សាទុកទិន្ន័យទទួលបានជោគជ័យ";
                        RefreshData(productImple.ReadData());
                        btnNew_Click(sender, e);
                        image = Properties.Resources.ok_100px;
                        c = Color.Green;
                    }
                    else
                    {
                        msg = "ការរក្សាទុកទិន្ន័យមិនទទួលបានជោគជ័យ";
                        image = Properties.Resources.error_100px1;
                        c = Color.Red;
                    }
                    successfullDialog.Text = "ការបញ្ចូលទិន្ន័យ";
                    successfullDialog.Caption = msg;
                    successfullDialog.Pbox = image;
                    successfullDialog.ForeColor = c;
                    successfullDialog.ShowDialog();

                }
                catch (Exception ex)
                {
                    successfullDialog.Text = "Error";
                    successfullDialog.ForeColor = Color.Red;
                    successfullDialog.Caption = ex.Message;
                    successfullDialog.Pbox = Properties.Resources.error_100px1;
                    successfullDialog.ShowDialog();
                }

            }
        }
     
        private void RefreshData(List<Product> ls)
        {
            dgvProduct.DataSource = ls;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ComfirmDialog comfirmDialog = new ComfirmDialog();
                comfirmDialog.Caption = "តើអ្នកចង់លុបទិន្ន័យមែនទេ?";
                comfirmDialog.ShowDialog();
                if (comfirmDialog.DialogResult.Equals(DialogResult.Yes))
                {
                    bool selected = false;
                    int id = 0;
                    bool result = false;
                    string msg = "";
                    Image img = Properties.Resources.error_100px1;
                    Color c = Color.Red;
                    foreach (DataGridViewRow row in dgvProduct.Rows)
                    {
                        selected = Convert.ToBoolean(row.Cells["check"].Value);
                        if (selected)
                        {
                            id = int.Parse(row.Cells[1].Value.ToString());
                            result = productImple.DeleteData(id);
                        }
                    }
                    if (result)
                    {
                        msg = "ការលុបទិន្ន័យទទួលបានជោគជ័យ";
                        img = Properties.Resources.ok_100px;
                        c = Color.Green;
                        btnNew_Click(sender, e);
                        RefreshData(productImple.ReadData());
                    }
                    else
                    {
                        img = Properties.Resources.error_100px1;
                        c = Color.Red;
                        msg = "ការលុបទិន្ន័យមិនទទួលបានជោគជ័យ";
                    }
                    successfullDialog.Text ="លុបទិន្ន័យ";
                    successfullDialog.Caption = msg;
                    successfullDialog.Pbox = img;
                    successfullDialog.ForeColor = c;
                    successfullDialog.ShowDialog();
                    
                }
                else
                {
                    btnNew_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                successfullDialog.Text = "Error";
                successfullDialog.ForeColor = Color.Red;
                successfullDialog.Caption = ex.Message;
                successfullDialog.Pbox = Properties.Resources.error_100px1;
                successfullDialog.ShowDialog();
            }


        }



        private void txtSearh_TextChanged(object sender, EventArgs e)
        {
            if (!txtSearh.Text.Equals(""))
                RefreshData(productImple.Search(txtSearh.Text.Trim()));
            else RefreshData(productImple.ReadData());
        }

        private void cboCatId_SelectedValueChanged(object sender, EventArgs e)
        {
            catId = cboCatId.SelectedValue.ToString();
            
        }

        private void pbox_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pbox.Image = Image.FromFile(ofd.FileName);
            }
        }
        private bool CheckTextBox(params TextBox[] txt)
        {
            foreach(var temp in txt)
            {
                if (temp.Text.Equals(""))
                {
                    temp.Focus();
                    return false;
                }
            }
            return true;
        }
        private void ClearTextBox(params TextBox[] txt)
        {
            foreach(var temp in txt)
            {
                temp.Text = "";
            }
            txt[0].Focus();
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyInput.InputInteger(e);
        }

       

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyInput.InputFloating(e, txtPrice);
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            click = false;
            btnSave.Text = "កែប្រែ";
            id = int.Parse(dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[1].Value.ToString());
            txtName.Text = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[2].Value.ToString();
            cboCatId.SelectedValue =int.Parse(dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[3].Value.ToString());
            
            txtPrice.Text = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[4].Value.ToString();
            string path = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[5].Value.ToString();
            cboSize.SelectedItem = dgvProduct.Rows[dgvProduct.CurrentRow.Index].Cells[6].Value.ToString();
            Image img = Properties.Resources.No;
            if (!path.Equals(""))
            {
                try
                {
                    ofd.FileName = path;
                    img = Image.FromFile(ofd.FileName);
                }
                catch (Exception ex)
                {
                    img = Properties.Resources.user_empty;
                }
            }
            pbox.Image = img;
            //MessageBox.Show(cat.ToString());
        }
    }
}
