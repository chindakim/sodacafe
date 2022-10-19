using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyAdmin.Presentation.Sale
{
    public partial class ReportDetail : Form
    {
        private string name;
        private string orderId;
        private double receive;
        private double reil;
        private double remain;
        private double rate;
        private List<Business.Entities.ReportSale> ls;
        private MyAdmin.Report re;
        public ReportDetail()
        {
            InitializeComponent();
            
        }
        public ReportDetail( string name,string orderId, double reil,double receive,double remain,
            double rate,List<Business.Entities.ReportSale> ls)
        {
            InitializeComponent();
            this.name = name;
            this.orderId = orderId;
            this.receive = receive;
            this.reil = reil;
            this.receive = receive;
            this.remain = remain;
            this.rate = rate;
            this.ls = ls;
        }
        private void ReportDetail_Load(object sender, EventArgs e)
        {
            re = new MyAdmin.Report();
            TextObject txtOrderId = (TextObject)re.ReportDefinition.Sections["Section2"].ReportObjects["txtOrderId"];
            txtOrderId.Text = orderId;
            TextObject txtSeller = (TextObject)re.ReportDefinition.Sections["Section2"].ReportObjects["txtSeller"];
            txtSeller.Text = name;

            TextObject txtReil = (TextObject)re.ReportDefinition.Sections["Section4"].ReportObjects["txtReil"];
            txtReil.Text = reil.ToString("#,###0.00");
            TextObject txtReceive = (TextObject)re.ReportDefinition.Sections["Section4"].ReportObjects["txtReceive"];
            txtReceive.Text = receive.ToString("$#,##0.00");

            TextObject txtReamin = (TextObject)re.ReportDefinition.Sections["Section4"].ReportObjects["txtRemain"];
            txtReamin.Text = remain.ToString("$#,##0.00");
            TextObject txtRate = (TextObject)re.ReportDefinition.Sections["Section4"].ReportObjects["txtRate"];
            txtRate.Text = rate.ToString();
            re.SetDataSource(ls);
            crystalReportViewer.ReportSource = re;
            crystalReportViewer.Refresh();

        }
    }
}
