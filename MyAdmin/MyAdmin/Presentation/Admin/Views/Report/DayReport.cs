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

namespace MyAdmin.Presentation.Admin.Views.Report
{
    public partial class DayReport : UserControl
    {
        public DayReport()
        {
            InitializeComponent();
            dPicker.MaxDate = DateTime.Now;
        }
        
        private void dPicker_ValueChanged(object sender, EventArgs e)
        {
            string msg = dPicker.Text;
            LoadData(msg);
        }
        private void LoadData(string date)
        {
            string sql = $"exec read_product_sale '{date}'";
            SqlCommand sqlCommand = new SqlCommand(sql ,Connection.DataCon);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dgvData.DataSource = data;
            adapter.Dispose();
            double total = 0.0;
            foreach(DataGridViewRow r  in dgvData.Rows)
            {
                total += double.Parse(r.Cells[6].Value.ToString());
            }
            txtTotal.Text = total.ToString("$#,##0.00");
        }

        private void DayReport_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            LoadData(date);
        }
    }
}
