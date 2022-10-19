using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAdmin.Data.DataSource;
using MyAdmin.Presentation.Component;
using MyAdmin.Presentation.Sale;

namespace MyAdmin.Presentation
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            //Connection.DataCon.Close();
            Application.Exit();
           
        }

        private void ckbPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = (ckbPassword.Checked) ? false : true;

        }
        private bool CheckTexBox(params TextBox[] txt)
        {
            foreach (var temp in txt)
            {
                if (temp.Text.Equals(""))
                {
                    temp.Focus();
                    return false;
                }
            }
            return true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) LogIn();
        }
        private  void LogIn()
        {
            if (CheckTexBox(txtUserName, txtPassword))
            {
                try
                {
                    string userName = txtUserName.Text.Trim();
                    string password = txtPassword.Text.Trim();
                    Connection.ConnectionDB("localhost", userName, password, "sodacafe");
                    if (userName.Equals("Admin"))
                        new Main().Show();
                    else new FormSale().Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }
    }
}
