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
namespace MyAdmin.Presentation.Admin.Views.Supplier
{
    public partial class ViewProductImport : UserControl
    {
        public ViewProductImport()
        {
            InitializeComponent();
            dtp1.MaxDate = DateTime.Now;
            dtp2.MinDate = dtp1.MaxDate;

            RefreshData(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            RefreshData(dtp1.Text, dtp2.Text);
        }
        private void RefreshData(string startDate,string endDate)
        {
            string sql = $"select * from view_product_import v where  v.[Import Date] between '{startDate}' and '{endDate}';";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);
                dataGridView.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            RefreshData(dtp1.Text, dtp2.Text);
        }
    }
}
