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

namespace MyAdmin.Presentation.Admin.Views.Dashborads
{
    public partial class Invoice : UserControl
    {
        public Invoice()
        {
            InitializeComponent();
            try
            {
                Connection.ConnectionDB("localhost", "sodacafe");
                string sql = $"select count(id) from tblorder  v WHERE v.[date] = '{DateTime.Now:yyyy-MM-dd}';";
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
