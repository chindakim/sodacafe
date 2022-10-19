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
using MyAdmin.Data.Repositories;
using MyAdmin.Business.Entities;
using MyAdmin.Presentation.Component;
using MyAdmin.Presentation.Admin.Views.Supplier;
using MyAdmin.Presentation.Admin.Views.Report;
using MyAdmin.Presentation.Admin.Views.Products;
using MyAdmin.Presentation.Admin.Views.Dashborads;

namespace MyAdmin.Presentation
{
    public partial class Main : Form
    {
        private ProductImple productImple;
        private List<Product> ls;
       
        public Main()
        {
            InitializeComponent();
            //var materialSkinManager = MaterialSkinManager.Instance;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            CustomizeDesign();
            productImple = new ProductImple();
            ls = new List<Product>();
            timer.Start();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                TogglePanelMain(new Dashboard());
                lblAdmin.Text = Connection.NAME;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void picAlert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alert");
        }
        private void TogglePanelMain(UserControl userControl)
        {
            this.pMain.Controls.Clear();
            if (userControl == null)
            {
                pMain.Controls.Add(userControl);
                userControl.Dock = System.Windows.Forms.DockStyle.Fill;
                userControl.Location = new System.Drawing.Point(0, 0);

            }
            else
            {
                pMain.Controls.Add(userControl);
                userControl.Dock = System.Windows.Forms.DockStyle.Fill;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //    Connection.DataCon.Close();
            //}
            Application.Exit();
            Connection.DataCon.Close();

        }
        private void CustomizeDesign()
        {
            pCategory.Visible = false;
            pProduct.Visible = false;
            pSupplier.Visible = false;
            pReport.Visible = false;
        }
        private void HideSubMenu()
    {
            if (pCategory.Visible == true)
                pCategory.Visible = false;
            if (pProduct.Visible == true)
                pProduct.Visible = false;
            if (pSupplier.Visible == true)
                pSupplier.Visible = false;
            if (pReport.Visible == true)
                pReport.Visible = false;
        }
        private void ShowSubMenu(Panel subMenu)
    {
        if (subMenu.Visible == false)
        {
            HideSubMenu();
            subMenu.Visible = true;
        }
        else
        {
            subMenu.Visible = false;
        }
    }

        

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pCategory);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pProduct);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {

            ShowSubMenu(pSupplier);
        }

       

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "បន្ថែមប្រភេទទំនិញ";
            TogglePanelMain(new AddCategory());
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "បន្ថែមទំនិញ";
            TogglePanelMain(new AddProduct());
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "បន្ថែមអ្នកផ្គត់ផ្គង់";
            TogglePanelMain(new AddSupplier());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ComfirmDialog c = new ComfirmDialog();
            c.Caption = "តើអ្នកចង់ចាកចេញមែនទេ?";
            c.Text = "ចាកចេញ";
            c.ShowDialog();
            if (c.DialogResult.Equals(DialogResult.Yes))
            {
                Connection.DataCon.Close();
                this.Dispose();
                new Login().Show();
            }
        }

        private void btnImportProduct_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "បន្ថែមទំនិញ";
            TogglePanelMain(new ImportProduct());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ShowSubMenu(pReport);
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "ប្រចាំថ្ងៃ";
            TogglePanelMain(new DayReport());
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "ប្រចាំខែ";
            TogglePanelMain(new MonthReport());
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "បន្ថែមទំនិញនាំចូល";
            TogglePanelMain(new ImportDetail());
        }

        private void btnListProduct_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "បញ្ជីរទំនិញ";
            TogglePanelMain(new ViewProductImport());
        }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            new AboutMe().ShowDialog();
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Dashboard";
            TogglePanelMain(new Dashboard());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
