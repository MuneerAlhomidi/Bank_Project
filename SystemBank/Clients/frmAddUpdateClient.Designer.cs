namespace SystemBank
{
    partial class frmAddUpdateClient
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
            this.tcPersonInfo = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.ctrPersonInfoWithFilter1 = new SystemBank.ctrPersonInfoWithFilter();
            this.tbClientInfo = new System.Windows.Forms.TabPage();
            this.lbClientID = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtConfirmPinCode = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAccountBalanc = new System.Windows.Forms.TextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCloes = new System.Windows.Forms.Button();
            this.lbTital = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcPersonInfo.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPersonInfo
            // 
            this.tcPersonInfo.Controls.Add(this.tbPersonInfo);
            this.tcPersonInfo.Controls.Add(this.tbClientInfo);
            this.tcPersonInfo.Location = new System.Drawing.Point(3, 79);
            this.tcPersonInfo.Name = "tcPersonInfo";
            this.tcPersonInfo.SelectedIndex = 0;
            this.tcPersonInfo.Size = new System.Drawing.Size(846, 439);
            this.tcPersonInfo.TabIndex = 0;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.btnNext);
            this.tbPersonInfo.Controls.Add(this.ctrPersonInfoWithFilter1);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 34);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(838, 401);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Image = global::SystemBank.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(692, 356);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(133, 36);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ctrPersonInfoWithFilter1
            // 
            this.ctrPersonInfoWithFilter1.AddNew = false;
            this.ctrPersonInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrPersonInfoWithFilter1.FilterEnable = true;
            this.ctrPersonInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonInfoWithFilter1.Location = new System.Drawing.Point(8, 8);
            this.ctrPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrPersonInfoWithFilter1.Name = "ctrPersonInfoWithFilter1";
            this.ctrPersonInfoWithFilter1.PersonID = -1;
            this.ctrPersonInfoWithFilter1.Showfilter = true;
            this.ctrPersonInfoWithFilter1.Size = new System.Drawing.Size(828, 344);
            this.ctrPersonInfoWithFilter1.TabIndex = 0;
            this.ctrPersonInfoWithFilter1.OnPersonSelected += new System.Action<int>(this.ctrPersonInfoWithFilter1_OnPersonSelected);
            // 
            // tbClientInfo
            // 
            this.tbClientInfo.Controls.Add(this.lbClientID);
            this.tbClientInfo.Controls.Add(this.pictureBox6);
            this.tbClientInfo.Controls.Add(this.pictureBox5);
            this.tbClientInfo.Controls.Add(this.pictureBox4);
            this.tbClientInfo.Controls.Add(this.pictureBox3);
            this.tbClientInfo.Controls.Add(this.pictureBox1);
            this.tbClientInfo.Controls.Add(this.txtConfirmPinCode);
            this.tbClientInfo.Controls.Add(this.txtAccountNumber);
            this.tbClientInfo.Controls.Add(this.txtAccountBalanc);
            this.tbClientInfo.Controls.Add(this.txtPinCode);
            this.tbClientInfo.Controls.Add(this.label7);
            this.tbClientInfo.Controls.Add(this.label6);
            this.tbClientInfo.Controls.Add(this.label5);
            this.tbClientInfo.Controls.Add(this.label4);
            this.tbClientInfo.Controls.Add(this.label3);
            this.tbClientInfo.Controls.Add(this.label2);
            this.tbClientInfo.Location = new System.Drawing.Point(4, 34);
            this.tbClientInfo.Name = "tbClientInfo";
            this.tbClientInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbClientInfo.Size = new System.Drawing.Size(838, 401);
            this.tbClientInfo.TabIndex = 1;
            this.tbClientInfo.Text = "ClientInfo";
            this.tbClientInfo.UseVisualStyleBackColor = true;
            // 
            // lbClientID
            // 
            this.lbClientID.AutoSize = true;
            this.lbClientID.Location = new System.Drawing.Point(248, 46);
            this.lbClientID.Name = "lbClientID";
            this.lbClientID.Size = new System.Drawing.Size(45, 25);
            this.lbClientID.TabIndex = 20;
            this.lbClientID.Text = "???";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SystemBank.Properties.Resources.Number_32;
            this.pictureBox6.Location = new System.Drawing.Point(194, 85);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(38, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SystemBank.Properties.Resources.Number_32;
            this.pictureBox5.Location = new System.Drawing.Point(194, 121);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SystemBank.Properties.Resources.Number_32;
            this.pictureBox4.Location = new System.Drawing.Point(194, 162);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(38, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SystemBank.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(194, 198);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemBank.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(194, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtConfirmPinCode
            // 
            this.txtConfirmPinCode.Location = new System.Drawing.Point(253, 195);
            this.txtConfirmPinCode.Name = "txtConfirmPinCode";
            this.txtConfirmPinCode.PasswordChar = '*';
            this.txtConfirmPinCode.Size = new System.Drawing.Size(245, 30);
            this.txtConfirmPinCode.TabIndex = 3;
            this.txtConfirmPinCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPinCode_Validating);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(253, 80);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(245, 30);
            this.txtAccountNumber.TabIndex = 0;
            this.txtAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // txtAccountBalanc
            // 
            this.txtAccountBalanc.Location = new System.Drawing.Point(253, 122);
            this.txtAccountBalanc.Name = "txtAccountBalanc";
            this.txtAccountBalanc.Size = new System.Drawing.Size(245, 30);
            this.txtAccountBalanc.TabIndex = 1;
            this.txtAccountBalanc.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // txtPinCode
            // 
            this.txtPinCode.Location = new System.Drawing.Point(253, 158);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PasswordChar = '*';
            this.txtPinCode.Size = new System.Drawing.Size(245, 30);
            this.txtPinCode.TabIndex = 2;
            this.txtPinCode.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "AccountNumber :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Account Balanc :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Pin Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Confirm Pin Code :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "client ID :";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::SystemBank.Properties.Resources.Save_321;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(709, 526);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCloes
            // 
            this.btnCloes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloes.Image = global::SystemBank.Properties.Resources.Close_32;
            this.btnCloes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloes.Location = new System.Drawing.Point(565, 526);
            this.btnCloes.Name = "btnCloes";
            this.btnCloes.Size = new System.Drawing.Size(126, 36);
            this.btnCloes.TabIndex = 2;
            this.btnCloes.Text = "Close";
            this.btnCloes.UseVisualStyleBackColor = true;
            this.btnCloes.Click += new System.EventHandler(this.btnCloes_Click);
            // 
            // lbTital
            // 
            this.lbTital.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTital.ForeColor = System.Drawing.Color.Firebrick;
            this.lbTital.Location = new System.Drawing.Point(7, 9);
            this.lbTital.Name = "lbTital";
            this.lbTital.Size = new System.Drawing.Size(842, 58);
            this.lbTital.TabIndex = 4;
            this.lbTital.Text = "Edit application Type";
            this.lbTital.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(848, 565);
            this.Controls.Add(this.lbTital);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCloes);
            this.Controls.Add(this.tcPersonInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateClient";
            this.Text = "`";
            this.Activated += new System.EventHandler(this.frmAddUpdateClient_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateClient_Load);
            this.tcPersonInfo.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbClientInfo.ResumeLayout(false);
            this.tbClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPersonInfo;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private ctrPersonInfoWithFilter ctrPersonInfoWithFilter1;
        private System.Windows.Forms.TabPage tbClientInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCloes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTital;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPinCode;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAccountBalanc;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbClientID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}