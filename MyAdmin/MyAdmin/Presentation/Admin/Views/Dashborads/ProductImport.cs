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
    public partial class ProductImport : UserControl
    {
        public ProductImport()
        {
            InitializeComponent();
            try
            {
                Connection.ConnectionDB("localhost", "sodacafe");
                string sql = $"select COUNT(p.proID)  from tblimportdetail p inner join tblimport im on im.id = p.imID where MONTH(im.date) =  {DateTime.Now.Month} and YEAR(im.date) = {DateTime.Now.Year};";
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
