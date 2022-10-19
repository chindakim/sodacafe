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
namespace MyAdmin.Presentation.Admin.Views.Report
{
    public partial class MonthReport : UserControl
    {
        public MonthReport()
        {
            InitializeComponent();
        }

        private void MonthReport_Load(object sender, EventArgs e)
        {
            //chart.Series["salary"].Points.AddXY("chinda", 200);
            //chart.Series["salary"].Points.AddXY("sreyda", 300);
            //chart.Series["salary"].Points.AddXY("preab ny", 400);
            lblYear.Text = $"របាយការណ៏លក់ប្រចាំឆ្នាំ​ {DateTime.Now.Year}";
            try
            {
                string sql = "SELECT YEAR([date]) as [year] FROM tblorder GROUP BY YEAR([date]) order by YEAR([date]) desc ";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                DataTable d = new DataTable();
                adapter.Fill(d);
                cboYear.DataSource = d;
                cboYear.DisplayMember = "year";
                int year =int.Parse(DateTime.Now.ToString("yyyy"));
                LoadChart(year);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboYear_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int year = int.Parse(cboYear.Text);
            lblYear.Text = $"របាយការណ៏លក់ប្រចាំឆ្នាំ {year}";
            LoadChart(year);
        }
        private void LoadChart(int year)
        {
            try
            {
                string sql = $"exec report_sale {year}";
                SqlCommand sqlCommand = new SqlCommand(sql, Connection.DataCon);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                //DataSet dataSet = new DataSet();
                DataTable dataSet = new DataTable();
                adapter.Fill(dataSet);
                dgvReport.DataSource = dataSet;
                this.chart.DataSource = dataSet;
                this.chart.Series[0].XValueMember = "month";
                this.chart.Series[0].YValueMembers = "total";
                this.chart.DataBind();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
