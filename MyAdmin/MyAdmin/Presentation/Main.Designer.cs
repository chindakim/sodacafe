namespace MyAdmin.Presentation
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAboutMe = new System.Windows.Forms.Button();
            this.pReport = new System.Windows.Forms.Panel();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.pSupplier = new System.Windows.Forms.Panel();
            this.btnListProduct = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnImportProduct = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.pProduct = new System.Windows.Forms.Panel();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.pCategory = new System.Windows.Forms.Panel();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.circularPictureBox1 = new MyAdmin.Presentation.Component.CircularPictureBox();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pReport.SuspendLayout();
            this.pSupplier.SuspendLayout();
            this.pProduct.SuspendLayout();
            this.pCategory.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 801);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.btnAboutMe);
            this.panel5.Controls.Add(this.pReport);
            this.panel5.Controls.Add(this.btnReport);
            this.panel5.Controls.Add(this.pSupplier);
            this.panel5.Controls.Add(this.btnSupplier);
            this.panel5.Controls.Add(this.pProduct);
            this.panel5.Controls.Add(this.btnProduct);
            this.panel5.Controls.Add(this.pCategory);
            this.panel5.Controls.Add(this.btnCategory);
            this.panel5.Controls.Add(this.dashboard);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.btnLogout);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(221, 732);
            this.panel5.TabIndex = 1;
            // 
            // btnAboutMe
            // 
            this.btnAboutMe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutMe.FlatAppearance.BorderSize = 0;
            this.btnAboutMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutMe.Font = new System.Drawing.Font("Kh Content", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutMe.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAboutMe.Image = global::MyAdmin.Properties.Resources.high_importance_24px;
            this.btnAboutMe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutMe.Location = new System.Drawing.Point(0, 706);
            this.btnAboutMe.Name = "btnAboutMe";
            this.btnAboutMe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAboutMe.Size = new System.Drawing.Size(200, 51);
            this.btnAboutMe.TabIndex = 19;
            this.btnAboutMe.Text = "អំពីខ្ញុំ";
            this.btnAboutMe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutMe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutMe.UseVisualStyleBackColor = true;
            this.btnAboutMe.Click += new System.EventHandler(this.btnAboutMe_Click);
            // 
            // pReport
            // 
            this.pReport.Controls.Add(this.btnMonth);
            this.pReport.Controls.Add(this.btnDay);
            this.pReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.pReport.Location = new System.Drawing.Point(0, 606);
            this.pReport.Name = "pReport";
            this.pReport.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pReport.Size = new System.Drawing.Size(200, 100);
            this.pReport.TabIndex = 18;
            // 
            // btnMonth
            // 
            this.btnMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Font = new System.Drawing.Font("Kh Content", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMonth.Image = global::MyAdmin.Properties.Resources.line_chart_24px;
            this.btnMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonth.Location = new System.Drawing.Point(20, 51);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(180, 51);
            this.btnMonth.TabIndex = 1;
            this.btnMonth.Text = "ប្រចាំខែ";
            this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnDay
            // 
            this.btnDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDay.FlatAppearance.BorderSize = 0;
            this.btnDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDay.Font = new System.Drawing.Font("Kh Content", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDay.Image = global::MyAdmin.Properties.Resources.ratings_24px;
            this.btnDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDay.Location = new System.Drawing.Point(20, 0);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(180, 51);
            this.btnDay.TabIndex = 0;
            this.btnDay.Text = "ប្រចាំថ្ងៃ";
            this.btnDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Kh Content", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Image = global::MyAdmin.Properties.Resources.analyze_24px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 555);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(200, 51);
            this.btnReport.TabIndex = 17;
            this.btnReport.Text = "របាយការណ៏";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // pSupplier
            // 
            this.pSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.pSupplier.Controls.Add(this.btnListProduct);
            this.pSupplier.Controls.Add(this.btnImport);
            this.pSupplier.Controls.Add(this.btnImportProduct);
            this.pSupplier.Controls.Add(this.btnAddSupplier);
            this.pSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSupplier.Location = new System.Drawing.Point(0, 347);
            this.pSupplier.Name = "pSupplier";
            this.pSupplier.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pSupplier.Size = new System.Drawing.Size(200, 208);
            this.pSupplier.TabIndex = 16;
            // 
            // btnListProduct
            // 
            this.btnListProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListProduct.FlatAppearance.BorderSize = 0;
            this.btnListProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListProduct.Font = new System.Drawing.Font("Kh Content", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListProduct.Image = global::MyAdmin.Properties.Resources.list_view_24px;
            this.btnListProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProduct.Location = new System.Drawing.Point(20, 153);
            this.btnListProduct.Name = "btnListProduct";
            this.btnListProduct.Size = new System.Drawing.Size(180, 51);
            this.btnListProduct.TabIndex = 3;
            this.btnListProduct.Text = "បញ្ជីរទំនិញ";
            this.btnListProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListProduct.UseVisualStyleBackColor = true;
            this.btnListProduct.Click += new System.EventHandler(this.btnListProduct_Click);
            // 
            // btnImport
            // 
            this.btnImport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Kh Content", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImport.Image = global::MyAdmin.Properties.Resources.import_24px;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(20, 102);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(180, 51);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "បន្ថែមទំនិញនាំចូល";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnImportProduct
            // 
            this.btnImportProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImportProduct.FlatAppearance.BorderSize = 0;
            this.btnImportProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportProduct.Font = new System.Drawing.Font("Kh Content", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImportProduct.Image = global::MyAdmin.Properties.Resources.edit_property_24px;
            this.btnImportProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportProduct.Location = new System.Drawing.Point(20, 51);
            this.btnImportProduct.Name = "btnImportProduct";
            this.btnImportProduct.Size = new System.Drawing.Size(180, 51);
            this.btnImportProduct.TabIndex = 1;
            this.btnImportProduct.Text = "បន្ថែមទំនិញ";
            this.btnImportProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImportProduct.UseVisualStyleBackColor = true;
            this.btnImportProduct.Click += new System.EventHandler(this.btnImportProduct_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Kh Content", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddSupplier.Image = global::MyAdmin.Properties.Resources.add_user_group_man_man_24px;
            this.btnAddSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.Location = new System.Drawing.Point(20, 0);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(180, 51);
            this.btnAddSupplier.TabIndex = 0;
            this.btnAddSupplier.Text = "បន្ថែមអ្នកផ្គត់ផ្គង់";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Kh Content", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSupplier.Image = global::MyAdmin.Properties.Resources.supplier_24px;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(0, 296);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(200, 51);
            this.btnSupplier.TabIndex = 15;
            this.btnSupplier.Text = "អ្នកផ្គត់ផ្គង់";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // pProduct
            // 
            this.pProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.pProduct.Controls.Add(this.btnAddProduct);
            this.pProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.pProduct.Location = new System.Drawing.Point(0, 240);
            this.pProduct.Name = "pProduct";
            this.pProduct.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pProduct.Size = new System.Drawing.Size(200, 56);
            this.pProduct.TabIndex = 14;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Kh Content", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(20, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(180, 51);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "បន្ថែមទំនិញ";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Kh Content", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnProduct.Image = global::MyAdmin.Properties.Resources.trolley_24px;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 189);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProduct.Size = new System.Drawing.Size(200, 51);
            this.btnProduct.TabIndex = 13;
            this.btnProduct.Text = "ទំនិញ";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // pCategory
            // 
            this.pCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.pCategory.Controls.Add(this.btnAddCategory);
            this.pCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCategory.Location = new System.Drawing.Point(0, 134);
            this.pCategory.Name = "pCategory";
            this.pCategory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pCategory.Size = new System.Drawing.Size(200, 55);
            this.pCategory.TabIndex = 12;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Kh Content", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCategory.Image = global::MyAdmin.Properties.Resources.edit_property_24px;
            this.btnAddCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.Location = new System.Drawing.Point(20, 0);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(180, 51);
            this.btnAddCategory.TabIndex = 0;
            this.btnAddCategory.Text = "បន្ថែមប្រភេទទំនិញ";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Kh Content", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategory.Image = global::MyAdmin.Properties.Resources.diversity_24px;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 83);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(200, 51);
            this.btnCategory.TabIndex = 11;
            this.btnCategory.Text = "ប្រភេទទំនិញ";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // dashboard
            // 
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Kh Content", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboard.Image = global::MyAdmin.Properties.Resources.dashboard_layout_24px;
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(0, 32);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.dashboard.Size = new System.Drawing.Size(200, 51);
            this.dashboard.TabIndex = 20;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 29);
            this.panel6.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 3);
            this.panel3.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Kh Content", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 757);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(200, 51);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "ចាកចេញ";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 69);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kh Content", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 46);
            this.label2.TabIndex = 0;
            this.label2.Text = " SODA CAFE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.lblDate);
            this.panel2.Controls.Add(this.circularPictureBox1);
            this.panel2.Controls.Add(this.lblAdmin);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(221, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 69);
            this.panel2.TabIndex = 1;
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Kh Content", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(859, 12);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(66, 31);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Admin";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Kh Content", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(136, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DASHBOARD";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(221, 69);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(937, 3);
            this.panel.TabIndex = 2;
            // 
            // pMain
            // 
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(221, 72);
            this.pMain.Name = "pMain";
            this.pMain.Padding = new System.Windows.Forms.Padding(20);
            this.pMain.Size = new System.Drawing.Size(937, 729);
            this.pMain.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(797, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(35, 24);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "time";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox1.BorderSize = 2;
            this.circularPictureBox1.GradientAngle = 50F;
            this.circularPictureBox1.Image = global::MyAdmin.Properties.Resources.female_user_40px;
            this.circularPictureBox1.Location = new System.Drawing.Point(807, 6);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(40, 40);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 2;
            this.circularPictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 801);
            this.ControlBox = false;
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1158, 746);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.pReport.ResumeLayout(false);
            this.pSupplier.ResumeLayout(false);
            this.pProduct.ResumeLayout(false);
            this.pCategory.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel pSupplier;
        private System.Windows.Forms.Button btnImportProduct;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel pReport;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnListProduct;
        private Component.CircularPictureBox circularPictureBox1;
        private System.Windows.Forms.Button btnAboutMe;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer;
    }
}