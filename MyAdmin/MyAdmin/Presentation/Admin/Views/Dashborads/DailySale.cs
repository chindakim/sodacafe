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
    public partial class DailySale : UserControl
    {
        
        public DailySale()
        {
            InitializeComponent();
            try
            {
                Connection.ConnectionDB("localhost", "sodacafe");
                string sql = $"SELECT SUM((v.price*v.quantity)-(v.quantity*v.price)*v.discount/100) as [total] FROM view_product_sale v WHERE v.[date] = '{DateTime.Now:yyyy-MM-dd}';";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataReader r = sqlCommand.ExecuteReader();
                if (r.Read())
                {
                    string total = r[0].ToString();
                    double t;
                    if (!total.Equals(""))
                        t = double.Parse(total);
                    else t = 0.0;
                    lblTotal.Text =t.ToString("$#,##0.00");
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

        private void DailySale_Load(object sender, EventArgs e)
        {
            
        }
    }
}
