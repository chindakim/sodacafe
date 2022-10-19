using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyAdmin.Presentation.Component;

namespace MyAdmin.Presentation.Sale
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        public Payment(double amount,double rate)
        {
            InitializeComponent();
            Amount = amount;
            Rate = rate;
        }
       

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtReceive))
            {
                DialogResult = DialogResult.OK;
                int index = cboMoneyType.SelectedIndex;
                if (index == 0)
                {
                    Received = double.Parse(txtReceive.Text.Trim());
                    Remain = double.Parse(txtRemain.Text.Replace("$", ""));
                }
                else
                {
                    Received = double.Parse(txtReceive.Text.Trim()) / Rate;
                    Remain = double.Parse(txtRemain.Text.Replace("$", ""))/Rate;
                }
                this.Dispose();
            }
           
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            cboMoneyType.SelectedIndex = 0;
            txtAmount.Text = Amount.ToString("$#,##0.00");
            txtReil.Text = (Amount * Rate).ToString("#,##0.00");
            if (Amount > 0)
                txtReceive.ReadOnly = false;
           
        }
        

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {
            if (!txtReceive.Text.Equals(""))
            {
                int index = cboMoneyType.SelectedIndex;
                double receive = double.Parse(txtReceive.Text);
                double pay = 0.0;
                if (index == 0)
                {
                    pay = receive - Amount;
                    txtRemain.Text = pay.ToString("$#,##0.00");
                    
                }
                else
                {
                    double reil = double.Parse(txtReil.Text);
                    pay = receive - reil;
                    txtRemain.Text = pay.ToString();
                }
                if (pay >= 0)
                    btnCommit.Enabled = true;
                else btnCommit.Enabled = false;

            }
            else
            {
                txtRemain.Text = "$0.00";
                btnCommit.Enabled = false;
            }
        }

        private void txtReceive_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyInput.InputFloating(e, txtReceive);
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Dispose();
        }
        public double Amount { get; set; }
        public double Rate { get; set; }
        public double Received { get; set; }
        public double Remain { get; set; }
        private void cboMoneyType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtReceive.Text = "";
        }
        private bool CheckTextBox(params TextBox[] txt)
        {
            foreach(var temp in txt)
            {
                string text = temp.Text;
                if (text.Equals(""))
                {
                    temp.Focus();
                    return false;
                }
                    
            }
            return true;
        }
    }
}
