namespace SystemBank
{
    partial class frmClientInfo
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
            this.ctrPersonInfo1 = new SystemBank.ctrPersonInfo();
            this.label1 = new System.Windows.Forms.Label();
            this.ClientInf = new System.Windows.Forms.GroupBox();
            this.lbPinCode = new System.Windows.Forms.Label();
            this.lbAccountBalanc = new System.Windows.Forms.Label();
            this.lbAccountNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.ClientInf.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrPersonInfo1
            // 
            this.ctrPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonInfo1.Location = new System.Drawing.Point(4, 65);
            this.ctrPersonInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrPersonInfo1.Name = "ctrPersonInfo1";
            this.ctrPersonInfo1.Size = new System.Drawing.Size(835, 262);
            this.ctrPersonInfo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(825, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Detilse Client";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClientInf
            // 
            this.ClientInf.Controls.Add(this.lbPinCode);
            this.ClientInf.Controls.Add(this.lbAccountBalanc);
            this.ClientInf.Controls.Add(this.lbAccountNumber);
            this.ClientInf.Controls.Add(this.label4);
            this.ClientInf.Controls.Add(this.label3);
            this.ClientInf.Controls.Add(this.label2);
            this.ClientInf.Location = new System.Drawing.Point(4, 321);
            this.ClientInf.Name = "ClientInf";
            this.ClientInf.Size = new System.Drawing.Size(835, 77);
            this.ClientInf.TabIndex = 2;
            this.ClientInf.TabStop = false;
            this.ClientInf.Text = "ClientInfo";
            // 
            // lbPinCode
            // 
            this.lbPinCode.AutoSize = true;
            this.lbPinCode.Location = new System.Drawing.Point(108, 36);
            this.lbPinCode.Name = "lbPinCode";
            this.lbPinCode.Size = new System.Drawing.Size(45, 25);
            this.lbPinCode.TabIndex = 5;
            this.lbPinCode.Text = "???";
            // 
            // lbAccountBalanc
            // 
            this.lbAccountBalanc.AutoSize = true;
            this.lbAccountBalanc.Location = new System.Drawing.Point(678, 36);
            this.lbAccountBalanc.Name = "lbAccountBalanc";
            this.lbAccountBalanc.Size = new System.Drawing.Size(45, 25);
            this.lbAccountBalanc.TabIndex = 4;
            this.lbAccountBalanc.Text = "???";
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.AutoSize = true;
            this.lbAccountNumber.Location = new System.Drawing.Point(389, 36);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(45, 25);
            this.lbAccountNumber.TabIndex = 3;
            this.lbAccountNumber.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(533, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "AccountBalanc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Account Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pin Code:";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::SystemBank.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(698, 404);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(141, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(843, 441);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ClientInf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrPersonInfo1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClientInfo";
            this.Text = "frmClientInfo";
            this.Load += new System.EventHandler(this.frmClientInfo_Load);
            this.ClientInf.ResumeLayout(false);
            this.ClientInf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ctrPersonInfo ctrPersonInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ClientInf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPinCode;
        private System.Windows.Forms.Label lbAccountBalanc;
        private System.Windows.Forms.Label lbAccountNumber;
    }
}