using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAdmin.Presentation.Component
{
    public class MyInput
    {
        public static void InputInteger(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        public static void InputFloating(KeyPressEventArgs e,TextBox txt)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (txt.Text.Equals("0") && !e.KeyChar.Equals('.') && char.IsDigit(e.KeyChar) == true)
            {
                txt.Text = "";
            }
            if (txt.Text.Equals("") && e.KeyChar.Equals('.'))
            {
                e.Handled = true;
            }
            int i = txt.Text.IndexOf('.');
            if (i >= 0 && e.KeyChar.Equals('.'))
            {
                e.Handled = true;
            }
        }
    }
}
