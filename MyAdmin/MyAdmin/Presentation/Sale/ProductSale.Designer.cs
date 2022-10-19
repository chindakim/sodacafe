using System.Drawing;
using System.Windows.Forms;

namespace MyAdmin.Presentation.Sale
{
    partial class ProductSale
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.pbox = new MyAdmin.Presentation.Component.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(16, 10);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "ឈ្មោះ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Kh Content", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.lblPrice.Location = new System.Drawing.Point(16, 109);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 31);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "តម្លៃ";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(18, 62);
            this.lblSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(38, 25);
            this.lblSize.TabIndex = 8;
            this.lblSize.Text = "ទំហំ";
            // 
            // pbox
            // 
            this.pbox.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbox.BorderColor = System.Drawing.Color.RoyalBlue;
            this.pbox.BorderColor2 = System.Drawing.Color.HotPink;
            this.pbox.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.pbox.BorderSize = 5;
            this.pbox.GradientAngle = 50F;
            this.pbox.Image = global::MyAdmin.Properties.Resources.No;
            this.pbox.Location = new System.Drawing.Point(118, 24);
            this.pbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(99, 99);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox.TabIndex = 0;
            this.pbox.TabStop = false;
            // 
            // ProductSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbox);
            this.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ProductSale";
            this.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.Size = new System.Drawing.Size(228, 151);
            
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ProductSale_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Component.CircularPictureBox pbox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSize;

        public Image Pbox
        {
            get =>pbox.Image;
            set=>pbox.Image = value;
        }
        public string LblName
        {
            get=>lblName.Text;
            set => lblName.Text = value;
        }
        public string LblPrice
        {
            get => lblPrice.Text;
            set => lblPrice.Text = value;
        }
        public string LblSize
        {
            get=>lblSize.Text;
            set=>lblSize.Text = value;
        }
        public int Id { get; set; }
        public static DataGridViewRowCollection Rows { get; set; }
        public static TextBox Total { get; set; }
    }
}
