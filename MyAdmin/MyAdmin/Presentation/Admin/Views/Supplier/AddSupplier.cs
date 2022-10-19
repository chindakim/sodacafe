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
using System.IO;

namespace MyAdmin.Presentation.Admin.Views.Supplier
{
    public partial class AddSupplier : UserControl
    {
        
        private SupplierImple supplierImple;
        private bool click = true;
        private int id = 0;
        private SuccessfullDialog successfullDialog;
        
        public AddSupplier()
        {
            InitializeComponent();
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void AddSupplier_Load(object sender, EventArgs e)
        {
            //ls = new List<Supplier>();
            successfullDialog = new SuccessfullDialog();
            supplierImple = new SupplierImple();
            RefreshData(supplierImple.ReadData());
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtName, txtPhone, txtAddress))
            {
                string name = txtName.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string address = txtAddress.Text.Trim();
                string email = txtEmail.Text.Trim();
                string img = ofd.FileName;
                string uptodate = dtpDate.Text;
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
                            img = "People/user-empty.png";
                        result = supplierImple.CreateData(new Business.Entities.Supplier(0, name, phone, address, email, img, uptodate));
                    }
                    else
                    {
                        //update
                        result = supplierImple.UpdateData(new Business.Entities.Supplier(id, name, phone, address, email, img, uptodate));
                        btnSave.Text = "រក្សាទុក";
                        click = true;

                    }                    
                    if (result)
                    {
                        msg = "ការរក្សាទុកទិន្ន័យទទួលបានជោគជ័យ";
                        image = Properties.Resources.ok_100px;
                        c = Color.Green;
                        RefreshData(supplierImple.ReadData());
                        btnNew_Click(sender, e);
                    }
                    else
                    {
                        image = Properties.Resources.error_100px1;
                        c = Color.Red;
                        msg = "ការរក្សាទុកទិន្ន័យមិនទទួលបានជោគជ័យ";
                    }
                    
                    successfullDialog.Text = "ការបញ្ចូលទិន្ន័យ";
                    successfullDialog.Caption = msg;
                    successfullDialog.Pbox = image;
                    successfullDialog.ForeColor = c;
                    successfullDialog.ShowDialog();
                } catch(Exception ex)
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
            foreach(var temp in txt)
            {
                string text = temp.Text.Trim();
                if (text.Equals(""))
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
                if (comfirmDialog.DialogResult.Equals(DialogResult.Yes))
                {
                    bool selected = false;
                    int id = 0;
                    bool result = false;
                    string msg = "";
                    Image img = Properties.Resources.error_100px1;
                    Color c = Color.Red;
                    foreach (DataGridViewRow row in dgvSupplier.Rows)
                    {
                        selected = Convert.ToBoolean(row.Cells["check"].Value);
                        if (selected)
                        {
                            id = int.Parse(row.Cells[1].Value.ToString());
                            result = supplierImple.DeleteData(id);
                        }
                    }
                    if (result)
                    {
                        msg = "ការលុបទិន្ន័យទទួលបានជោគជ័យ";
                        img = Properties.Resources.ok_100px;
                        c = Color.Green;
                        btnNew_Click(sender, e);
                        RefreshData(supplierImple.ReadData());
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
        
        private void RefreshData(List<MyAdmin.Business.Entities.Supplier> dataAdapter)
        {
            dgvSupplier.DataSource = dataAdapter;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (!txtSearchName.Text.Equals(""))
            {
                RefreshData(supplierImple.Search(txtSearchName.Text.Trim()));
            }
            else
            {
                RefreshData(supplierImple.ReadData());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBox(txtName, txtPhone, txtEmail, txtAddress);
            imgPicker.Image = Properties.Resources.user_empty;
            dtpDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            click = true;
            btnSave.Text = "រក្សាទុក";
           

        }


        private void imgPicker_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
           // ofd.Filter = "Image file (*.png; *.jpg; *.gif)|*.png; *.jpg; *.gif";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Image img = Image.FromFile(ofd.FileName);
                imgPicker.Image = img;
            }
        }

       

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            click = false;
            btnSave.Text = "កែប្រែ";
            id = int.Parse(dgvSupplier.Rows[dgvSupplier.CurrentRow.Index].Cells[1].Value.ToString());
            txtName.Text = dgvSupplier.Rows[dgvSupplier.CurrentRow.Index].Cells[2].Value.ToString();
            txtPhone.Text = dgvSupplier.Rows[dgvSupplier.CurrentRow.Index].Cells[3].Value.ToString();
            txtAddress.Text = dgvSupplier.Rows[dgvSupplier.CurrentRow.Index].Cells[4].Value.ToString();
            txtEmail.Text = dgvSupplier.Rows[dgvSupplier.CurrentRow.Index].Cells[5].Value.ToString();
            dtpDate.Text = dgvSupplier.Rows[dgvSupplier.CurrentRow.Index].Cells[7].Value.ToString();
            string path = dgvSupplier.Rows[dgvSupplier.CurrentRow.Index].Cells[6].Value.ToString();
            Image img = Properties.Resources.user_empty;
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
            imgPicker.Image = img;
        }
    }
}
