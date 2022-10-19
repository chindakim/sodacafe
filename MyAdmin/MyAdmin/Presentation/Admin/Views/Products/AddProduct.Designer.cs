namespace MyAdmin.Presentation.Admin.Views.Products
{
    partial class AddProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboAddProduct = new System.Windows.Forms.GroupBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCatId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.gboListProduct = new System.Windows.Forms.GroupBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Panel();
            this.list = new System.Windows.Forms.Panel();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gboAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.gboListProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.add.SuspendLayout();
            this.list.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboAddProduct
            // 
            this.gboAddProduct.Controls.Add(this.cboSize);
            this.gboAddProduct.Controls.Add(this.btnDelete);
            this.gboAddProduct.Controls.Add(this.btnSave);
            this.gboAddProduct.Controls.Add(this.btnNew);
            this.gboAddProduct.Controls.Add(this.pbox);
            this.gboAddProduct.Controls.Add(this.label7);
            this.gboAddProduct.Controls.Add(this.txtPrice);
            this.gboAddProduct.Controls.Add(this.label5);
            this.gboAddProduct.Controls.Add(this.label4);
            this.gboAddProduct.Controls.Add(this.cboCatId);
            this.gboAddProduct.Controls.Add(this.label2);
            this.gboAddProduct.Controls.Add(this.txtName);
            this.gboAddProduct.Controls.Add(this.label1);
            this.gboAddProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboAddProduct.Location = new System.Drawing.Point(5, 5);
            this.gboAddProduct.Name = "gboAddProduct";
            this.gboAddProduct.Padding = new System.Windows.Forms.Padding(5);
            this.gboAddProduct.Size = new System.Drawing.Size(621, 725);
            this.gboAddProduct.TabIndex = 0;
            this.gboAddProduct.TabStop = false;
            this.gboAddProduct.Text = "បញ្ចូលទំនិញ";
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "S",
            "M",
            "L"});
            this.cboSize.Location = new System.Drawing.Point(410, 92);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(193, 32);
            this.cboSize.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(554, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 37);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "លុប";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(474, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(410, 141);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(54, 37);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "ថ្មី";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // pbox
            // 
            this.pbox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbox.Image = global::MyAdmin.Properties.Resources.No;
            this.pbox.Location = new System.Drawing.Point(109, 141);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(193, 173);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox.TabIndex = 13;
            this.pbox.TabStop = false;
            this.pbox.Click += new System.EventHandler(this.pbox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "រូបភាព";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(109, 96);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(193, 32);
            this.txtPrice.TabIndex = 2;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "ថ្លៃលក់ចេញ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "ទំហំ";
            // 
            // cboCatId
            // 
            this.cboCatId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatId.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCatId.FormattingEnabled = true;
            this.cboCatId.Location = new System.Drawing.Point(410, 46);
            this.cboCatId.Name = "cboCatId";
            this.cboCatId.Size = new System.Drawing.Size(193, 32);
            this.cboCatId.TabIndex = 3;
            this.cboCatId.SelectedValueChanged += new System.EventHandler(this.cboCatId_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ប្រភេទទំនិញ";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(109, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(193, 32);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ឈ្មោះ";
            // 
            // ofd
            // 
            this.ofd.Filter = "Image file (*.png; *.jpg; *.gif)|*.png; *.jpg; *.gif";
            // 
            // gboListProduct
            // 
            this.gboListProduct.Controls.Add(this.dgvProduct);
            this.gboListProduct.Controls.Add(this.panel1);
            this.gboListProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboListProduct.Location = new System.Drawing.Point(5, 5);
            this.gboListProduct.Name = "gboListProduct";
            this.gboListProduct.Padding = new System.Windows.Forms.Padding(5);
            this.gboListProduct.Size = new System.Drawing.Size(534, 725);
            this.gboListProduct.TabIndex = 1;
            this.gboListProduct.TabStop = false;
            this.gboListProduct.Text = "បញ្ជីទំនិញ";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.check});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(5, 74);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 34;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(524, 646);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 44);
            this.panel1.TabIndex = 0;
            // 
            // txtSearh
            // 
            this.txtSearh.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearh.Location = new System.Drawing.Point(111, 5);
            this.txtSearh.Name = "txtSearh";
            this.txtSearh.Size = new System.Drawing.Size(214, 32);
            this.txtSearh.TabIndex = 6;
            this.txtSearh.TextChanged += new System.EventHandler(this.txtSearh_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "ស្វែងរកឈ្មោះ";
            // 
            // add
            // 
            this.add.Controls.Add(this.gboAddProduct);
            this.add.Dock = System.Windows.Forms.DockStyle.Left;
            this.add.Location = new System.Drawing.Point(0, 0);
            this.add.Name = "add";
            this.add.Padding = new System.Windows.Forms.Padding(5);
            this.add.Size = new System.Drawing.Size(631, 735);
            this.add.TabIndex = 2;
            // 
            // list
            // 
            this.list.Controls.Add(this.gboListProduct);
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Location = new System.Drawing.Point(631, 0);
            this.list.Name = "list";
            this.list.Padding = new System.Windows.Forms.Padding(5);
            this.list.Size = new System.Drawing.Size(544, 735);
            this.list.TabIndex = 3;
            // 
            // check
            // 
            this.check.HeaderText = "";
            this.check.MinimumWidth = 6;
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Width = 80;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.list);
            this.Controls.Add(this.add);
            this.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddProduct";
            this.Size = new System.Drawing.Size(1175, 735);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.gboAddProduct.ResumeLayout(false);
            this.gboAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.gboListProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.add.ResumeLayout(false);
            this.list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboCatId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gboListProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtSearh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Panel list;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
    }
}
