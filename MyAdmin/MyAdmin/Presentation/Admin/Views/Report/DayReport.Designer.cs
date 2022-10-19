namespace MyAdmin.Presentation.Admin.Views.Report
{
    partial class DayReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hearder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dPicker = new System.Windows.Forms.DateTimePicker();
            this.center = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.bottom = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hearder.SuspendLayout();
            this.center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // hearder
            // 
            this.hearder.Controls.Add(this.label1);
            this.hearder.Controls.Add(this.dPicker);
            this.hearder.Dock = System.Windows.Forms.DockStyle.Top;
            this.hearder.Location = new System.Drawing.Point(0, 0);
            this.hearder.Name = "hearder";
            this.hearder.Padding = new System.Windows.Forms.Padding(10);
            this.hearder.Size = new System.Drawing.Size(952, 50);
            this.hearder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ស្វែងរកតាមថ្ងៃ";
            // 
            // dPicker
            // 
            this.dPicker.CustomFormat = "yyyy-MM-dd";
            this.dPicker.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dPicker.Location = new System.Drawing.Point(108, 10);
            this.dPicker.Name = "dPicker";
            this.dPicker.Size = new System.Drawing.Size(200, 32);
            this.dPicker.TabIndex = 0;
            this.dPicker.ValueChanged += new System.EventHandler(this.dPicker_ValueChanged);
            // 
            // center
            // 
            this.center.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.center.Controls.Add(this.dgvData);
            this.center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center.Location = new System.Drawing.Point(0, 50);
            this.center.Name = "center";
            this.center.Padding = new System.Windows.Forms.Padding(5);
            this.center.Size = new System.Drawing.Size(952, 542);
            this.center.TabIndex = 1;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Kh Content", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Kh Content", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvData.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(5, 5);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 34;
            this.dgvData.Size = new System.Drawing.Size(940, 530);
            this.dgvData.TabIndex = 0;
            // 
            // bottom
            // 
            this.bottom.Controls.Add(this.txtTotal);
            this.bottom.Controls.Add(this.label2);
            this.bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom.Location = new System.Drawing.Point(0, 592);
            this.bottom.Name = "bottom";
            this.bottom.Size = new System.Drawing.Size(952, 48);
            this.bottom.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(108, 9);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(225, 32);
            this.txtTotal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ទឹកប្រាក់សរុប";
            // 
            // DayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.center);
            this.Controls.Add(this.hearder);
            this.Controls.Add(this.bottom);
            this.Font = new System.Drawing.Font("Kh Content", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DayReport";
            this.Size = new System.Drawing.Size(952, 640);
            this.Load += new System.EventHandler(this.DayReport_Load);
            this.hearder.ResumeLayout(false);
            this.hearder.PerformLayout();
            this.center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.bottom.ResumeLayout(false);
            this.bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel hearder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dPicker;
        private System.Windows.Forms.Panel center;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Panel bottom;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label2;
    }
}
