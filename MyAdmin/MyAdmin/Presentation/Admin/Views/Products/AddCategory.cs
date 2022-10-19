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
using MyAdmin.Business.Entities;
using MyAdmin.Data.Repositories;
using MyAdmin.Presentation.Component;

namespace MyAdmin.Presentation.Admin.Views.Products
{
    public partial class AddCategory : UserControl
    {
        private CategoryImple category;
        private bool click = true;
        private SuccessfullDialog successfullDialog;
        public AddCategory()
        {
            InitializeComponent();
            dtp.MaxDate = DateTime.Now;
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            category = new CategoryImple();
            successfullDialog = new SuccessfullDialog();
            try
            {
                RefreshData(category.ReadData());
            }
            catch(Exception ex)
            {
                successfullDialog.Text = "Error";
                successfullDialog.ForeColor = Color.Red;
                successfullDialog.Caption = ex.Message;
                successfullDialog.Pbox = Properties.Resources.error_100px1;
                successfullDialog.ShowDialog();
            }
        }

        private void RefreshData(List<Category> ls)
        {
            dgvCategories.DataSource = ls;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != "")
                {
                    RefreshData(category.Search(txtSearch.Text.Trim()));
                }
                else
                {
                    RefreshData(category.ReadData());
                }
            }
            catch(Exception ex)
            {
                successfullDialog.Text = "Error";
                successfullDialog.ForeColor = Color.Red;
                successfullDialog.Caption = ex.Message;
                successfullDialog.Pbox = Properties.Resources.error_100px1;
                successfullDialog.ShowDialog();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtName)){
                string name = txtName.Text.Trim();
                string date = dtp.Text;
                string desc = txtDescription.Text.Trim();
                try
                {
                    bool result = false;
                    string msg = "";
                    Image img = Properties.Resources.error_100px1;
                    Color c = Color.Red; ;
                    if (click)
                    {
                        //add
                        result = category.CreateData(new Category(0, name, desc, date));
                    }
                    else
                    {
                        //update
                        result = category.UpdateData(new Category(0, name, desc, date));
                    }
                    if (result)
                    {
                        msg = "ការលុបទិន្ន័យទទួលបានជោគជ័យ";
                        img = Properties.Resources.ok_100px;
                        c = Color.Green;
                        btnNew_Click(sender, e);
                        RefreshData(category.ReadData());
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
                catch(Exception ex)
                {
                    successfullDialog.Text = "Error";
                    successfullDialog.ForeColor = Color.Red;
                    successfullDialog.Caption = ex.Message;
                    successfullDialog.Pbox = Properties.Resources.error_100px1;
                    successfullDialog.ShowDialog();
                }
                
            }
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
            foreach(TextBox txtItem in txt)
            {
                if (txtItem.Text.Equals(""))
                {
                    txtItem.Focus();
                    return false;
                }
            }
            return true;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBox(txtName, txtDescription);
            dtp.Text = DateTime.Now.ToString();
            click = true;
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            click = false;
            int index = e.RowIndex;
            txtName.Text = dgvCategories.Rows[index].Cells[2].Value.ToString();
            txtDescription.Text = dgvCategories.Rows[index].Cells[3].Value.ToString();
            dtp.Text = dgvCategories.Rows[index].Cells[4].Value.ToString();
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
                    foreach (DataGridViewRow row in dgvCategories.Rows)
                    {
                        selected = Convert.ToBoolean(row.Cells["check"].Value);
                        if (selected)
                        {
                            id = int.Parse(row.Cells[1].Value.ToString());
                            result = category.DeleteData(id);
                        }
                    }
                    if (result)
                    {
                        msg = "ការលុបទិន្ន័យទទួលបានជោគជ័យ";
                        img = Properties.Resources.ok_100px;
                        c = Color.Green;
                        btnNew_Click(sender, e);
                        RefreshData(category.ReadData());
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
            catch(Exception ex)
            {
                successfullDialog.Text = "Error";
                successfullDialog.ForeColor = Color.Red;
                successfullDialog.Caption = ex.Message;
                successfullDialog.Pbox = Properties.Resources.error_100px1;
                successfullDialog.ShowDialog();
            }
        }
    }
}
