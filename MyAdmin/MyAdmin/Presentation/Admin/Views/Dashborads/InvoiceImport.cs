using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MyAdmin.Data.DataSource;
namespace MyAdmin.Presentation.Admin.Views.Dashborads
{
    public partial class InvoiceImport : UserControl
    {
        public InvoiceImport()
        {
            InitializeComponent();
            try
            {
                Connection.ConnectionDB("localhost", "sodacafe");
                string sql = $"select count(id) from tblimport v where MONTH(v.date) = {DateTime.Now.Month} and YEAR(v.date) = {DateTime.Now.Year} ;";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                if (r.Read())
                {
                    string total = r[0].ToString();
                    double t;
                    if (!total.Equals(""))
                        t = double.Parse(total);
                    else t = 0.0;
                    lblTotal.Text = t.ToString("");
                }
                sqlCommand.Dispose();
                r.Close();
                Connection.DataCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
