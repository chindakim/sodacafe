using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyAdmin.Data.DataSource;
using MyAdmin.Data.Repositories;
using MyAdmin.Business.Entities;
using MyAdmin.Presentation.Component;

namespace MyAdmin.Presentation.Admin.Views.Supplier
{
    public partial class ImportProduct : UserControl
    {
        private ProductImportImple pro;
        private SuccessfullDialog successfullDialog;
        private bool click = true;
        private int id = 0;
        public ImportProduct()
        {
            InitializeComponent();
        }

        private void ImportProduct_Load(object sender, EventArgs e)
        {
            pro = new ProductImportImple();
            successfullDialog = new SuccessfullDialog();
            try
            {
                LoadData(pro.ReadData());
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadData(List<ProductImport> adapter)
        {

            dgvProductImport.DataSource = adapter;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBox(txtName, txtName, txtCost);
            btnSave.Text = "រក្សាទុក";
            click = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtName, txtCost))
            {
                string name = txtName.Text.Trim();
                double cost = double.Parse(txtCost.Text.Trim());
                string description = txtDescription.Text.Trim();
                try
                {
                    bool result = false;
                    string msg = "";
                    Image image = Properties.Resources.error_100px1;
                    Color c = Color.Red;
                    if (click)
                    {
                        //Add Data
                        result = pro.CreateData(new ProductImport(0, name, cost, description));
                    }
                    else
                    {
                        //Update
                        ComfirmDialog comfirmDialog = new ComfirmDialog();
                        comfirmDialog.Caption = "តើអ្នកចង់កែប្រែទិន្ន័យមែនទេ?";
                        comfirmDialog.ShowDialog();
                        if (comfirmDialog.DialogResult.Equals(DialogResult.Yes))
                        {
                            click = true;
                            result = pro.UpdateData(new ProductImport(id, name, cost, description));
                            id = 0;
                            btnSave.Text = "រក្សារទុក";
                        }
                    }
                    if (result)
                    {
                        msg = "ការរក្សាទុកទិន្ន័យទទួលបានជោគជ័យ";
                        LoadData(pro.ReadData());
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
        private bool CheckTextBox(params TextBox[] txt)
        {
            foreach (TextBox txtItem in txt)
            {
                if (txtItem.Text.Equals(""))
                {
                    txtItem.Focus();
                    return false;
                }
            }
            return true;
        }
        private void ClearTextBox(params TextBox []txt)
        {
            foreach(var txtItem in txt)
            {
                txtItem.Text = "";
                txt[0].Focus();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                ComfirmDialog comfirmDialog = new ComfirmDialog();
                comfirmDialog.Caption = "តើអ្នកចង់លុបទិន្ន័យមែនទេ?";
                comfirmDialog.ShowDialog();
                //DialogResult r = MessageBox.Show("តើអ្នកចង់លុបទិន្ន័យមែនទេ?", "លុបទិន្ន័យ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (comfirmDialog.DialogResult.Equals(DialogResult.Yes))
                {
                    bool selected = false;
                    int id = 0;
                    bool result = false;
                    string msg = "";
                    Image img = Properties.Resources.error_100px1;
                    Color c = Color.Red;
                    foreach (DataGridViewRow row in dgvProductImport.Rows)
                    {
                        selected = Convert.ToBoolean(row.Cells["check"].Value);
                        if (selected)
                        {
                            id = int.Parse(row.Cells[1].Value.ToString());
                            result = pro.DeleteData(id);
                        }
                    }
                    if (result)
                    {
                        msg = "ការលុបទិន្ន័យទទួលបានជោគជ័យ";
                        img = Properties.Resources.ok_100px;
                        c = Color.Green;
                        btnNew_Click(sender, e);
                        LoadData(pro.ReadData());
                    }
                    else
                    {
                        img = Properties.Resources.error_100px1;
                        c = Color.Red;
                        msg = "ការលុបទិន្ន័យមិនទទួលបានជោគជ័យ";
                    }
                    successfullDialog.Text = "លុបទិន្ន័យ";
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

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
            try
            {
                if (!txtSearch.Text.Equals(""))
                    LoadData(pro.Search(txtSearch.Text.Trim()));
                else LoadData(pro.ReadData());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyInput.InputFloating(e, txtCost);
        }

        private void dgvProductImport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            click = false;
            btnSave.Text = "កែប្រែ";
            int index = dgvProductImport.CurrentRow.Index;
            id = int.Parse(dgvProductImport.Rows[index].Cells[1].Value.ToString());
            txtName.Text = dgvProductImport.Rows[index].Cells[2].Value.ToString();
            txtCost.Text = dgvProductImport.Rows[index].Cells[3].Value.ToString();
            txtDescription.Text = dgvProductImport.Rows[index].Cells[4].Value.ToString();
        }
    }
}
