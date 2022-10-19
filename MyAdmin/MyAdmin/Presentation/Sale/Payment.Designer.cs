namespace MyAdmin.Presentation.Sale
{
    partial class Payment
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRemain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.txtReil = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMoneyType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "តម្លៃសុប";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(118, 24);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(180, 32);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.Text = "0.00";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(118, 170);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.ReadOnly = true;
            this.txtReceive.Size = new System.Drawing.Size(180, 32);
            this.txtReceive.TabIndex = 4;
            this.txtReceive.TextChanged += new System.EventHandler(this.txtReceive_TextChanged);
            this.txtReceive.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReceive_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "ប្រភេទប្រាក់";
            // 
            // txtRemain
            // 
            this.txtRemain.Location = new System.Drawing.Point(118, 221);
            this.txtRemain.Name = "txtRemain";
            this.txtRemain.ReadOnly = true;
            this.txtRemain.Size = new System.Drawing.Size(180, 32);
            this.txtRemain.TabIndex = 5;
            this.txtRemain.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(32, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "អាប់";
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.White;
            this.btnCommit.Enabled = false;
            this.btnCommit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCommit.Location = new System.Drawing.Point(223, 274);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 37);
            this.btnCommit.TabIndex = 2;
            this.btnCommit.Text = "បញ្ចូល";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // txtReil
            // 
            this.txtReil.Location = new System.Drawing.Point(118, 72);
            this.txtReil.Name = "txtReil";
            this.txtReil.ReadOnly = true;
            this.txtReil.Size = new System.Drawing.Size(180, 32);
            this.txtReil.TabIndex = 7;
            this.txtReil.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(32, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "ប្រាក់រៀល";
            // 
            // cboMoneyType
            // 
            this.cboMoneyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMoneyType.FormattingEnabled = true;
            this.cboMoneyType.Items.AddRange(new object[] {
            "ប្រាក់ដុល្លា",
            "ប្រាក់រៀល"});
            this.cboMoneyType.Location = new System.Drawing.Point(119, 118);
            this.cboMoneyType.MaxDropDownItems = 2;
            this.cboMoneyType.Name = "cboMoneyType";
            this.cboMoneyType.Size = new System.Drawing.Size(179, 32);
            this.cboMoneyType.TabIndex = 9;
            this.cboMoneyType.SelectionChangeCommitted += new System.EventHandler(this.cboMoneyType_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(32, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "ទទួលប្រាក់";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(118, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 37);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "បិទ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(85)))), ((int)(((byte)(168)))));
            this.ClientSize = new System.Drawing.Size(358, 350);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboMoneyType);
            this.Controls.Add(this.txtReil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.txtRemain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReceive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Kh Content", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(358, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(358, 350);
            this.Name = "Payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Payment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRemain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.TextBox txtReil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMoneyType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnExit;
    }
}