namespace SystemBank
{
    partial class frmAddUpdateUser
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
            this.tcUserInfo = new System.Windows.Forms.TabControl();
            this.tbPersonInfo = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.lbTitel = new System.Windows.Forms.Label();
            this.ctrPersonInfoWithFilter1 = new SystemBank.ctrPersonInfoWithFilter();
            this.tbUserInfo = new System.Windows.Forms.TabPage();
            this.lbPermissions = new System.Windows.Forms.Label();
            this.gbPermissions = new System.Windows.Forms.GroupBox();
            this.chbSelectAll = new System.Windows.Forms.CheckBox();
            this.chbUpdateEmployee = new System.Windows.Forms.CheckBox();
            this.chbPeople = new System.Windows.Forms.CheckBox();
            this.chbClient = new System.Windows.Forms.CheckBox();
            this.chbUser = new System.Windows.Forms.CheckBox();
            this.chbEmployee = new System.Windows.Forms.CheckBox();
            this.chbTransaction = new System.Windows.Forms.CheckBox();
            this.chbUpdatePeople = new System.Windows.Forms.CheckBox();
            this.chbUpdateClient = new System.Windows.Forms.CheckBox();
            this.chbUpdateUser = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIsActive = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcUserInfo.SuspendLayout();
            this.tbPersonInfo.SuspendLayout();
            this.tbUserInfo.SuspendLayout();
            this.gbPermissions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUserInfo
            // 
            this.tcUserInfo.Controls.Add(this.tbPersonInfo);
            this.tcUserInfo.Controls.Add(this.tbUserInfo);
            this.tcUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tcUserInfo.Name = "tcUserInfo";
            this.tcUserInfo.SelectedIndex = 0;
            this.tcUserInfo.Size = new System.Drawing.Size(832, 505);
            this.tcUserInfo.TabIndex = 0;
            // 
            // tbPersonInfo
            // 
            this.tbPersonInfo.Controls.Add(this.btnNext);
            this.tbPersonInfo.Controls.Add(this.lbTitel);
            this.tbPersonInfo.Controls.Add(this.ctrPersonInfoWithFilter1);
            this.tbPersonInfo.Location = new System.Drawing.Point(4, 34);
            this.tbPersonInfo.Name = "tbPersonInfo";
            this.tbPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonInfo.Size = new System.Drawing.Size(824, 467);
            this.tbPersonInfo.TabIndex = 0;
            this.tbPersonInfo.Text = "Person Info";
            this.tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Image = global::SystemBank.Properties.Resources.Next_32;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(681, 419);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(135, 37);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbTitel
            // 
            this.lbTitel.BackColor = System.Drawing.Color.White;
            this.lbTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitel.ForeColor = System.Drawing.Color.Red;
            this.lbTitel.Location = new System.Drawing.Point(0, 8);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(821, 56);
            this.lbTitel.TabIndex = 1;
            this.lbTitel.Text = "Add Eidt User";
            this.lbTitel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctrPersonInfoWithFilter1
            // 
            this.ctrPersonInfoWithFilter1.AddNew = true;
            this.ctrPersonInfoWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrPersonInfoWithFilter1.FilterEnable = true;
            this.ctrPersonInfoWithFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonInfoWithFilter1.Location = new System.Drawing.Point(4, 72);
            this.ctrPersonInfoWithFilter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrPersonInfoWithFilter1.Name = "ctrPersonInfoWithFilter1";
            this.ctrPersonInfoWithFilter1.PersonID = -1;
            this.ctrPersonInfoWithFilter1.Showfilter = true;
            this.ctrPersonInfoWithFilter1.Size = new System.Drawing.Size(820, 344);
            this.ctrPersonInfoWithFilter1.TabIndex = 0;
            // 
            // tbUserInfo
            // 
            this.tbUserInfo.Controls.Add(this.lbPermissions);
            this.tbUserInfo.Controls.Add(this.gbPermissions);
            this.tbUserInfo.Controls.Add(this.label5);
            this.tbUserInfo.Controls.Add(this.pictureBox2);
            this.tbUserInfo.Controls.Add(this.lblUserID);
            this.tbUserInfo.Controls.Add(this.label4);
            this.tbUserInfo.Controls.Add(this.chkIsActive);
            this.tbUserInfo.Controls.Add(this.txtUserName);
            this.tbUserInfo.Controls.Add(this.txtConfirmPassword);
            this.tbUserInfo.Controls.Add(this.label1);
            this.tbUserInfo.Controls.Add(this.label3);
            this.tbUserInfo.Controls.Add(this.label2);
            this.tbUserInfo.Controls.Add(this.txtPassword);
            this.tbUserInfo.Controls.Add(this.pictureBox1);
            this.tbUserInfo.Controls.Add(this.pictureBox8);
            this.tbUserInfo.Controls.Add(this.pictureBox3);
            this.tbUserInfo.Location = new System.Drawing.Point(4, 34);
            this.tbUserInfo.Name = "tbUserInfo";
            this.tbUserInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbUserInfo.Size = new System.Drawing.Size(824, 467);
            this.tbUserInfo.TabIndex = 1;
            this.tbUserInfo.Text = "User Info";
            this.tbUserInfo.UseVisualStyleBackColor = true;
            // 
            // lbPermissions
            // 
            this.lbPermissions.AutoSize = true;
            this.lbPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPermissions.Location = new System.Drawing.Point(676, 25);
            this.lbPermissions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPermissions.Name = "lbPermissions";
            this.lbPermissions.Size = new System.Drawing.Size(48, 25);
            this.lbPermissions.TabIndex = 163;
            this.lbPermissions.Text = "???";
            // 
            // gbPermissions
            // 
            this.gbPermissions.Controls.Add(this.chbSelectAll);
            this.gbPermissions.Controls.Add(this.chbUpdateEmployee);
            this.gbPermissions.Controls.Add(this.chbPeople);
            this.gbPermissions.Controls.Add(this.chbClient);
            this.gbPermissions.Controls.Add(this.chbUser);
            this.gbPermissions.Controls.Add(this.chbEmployee);
            this.gbPermissions.Controls.Add(this.chbTransaction);
            this.gbPermissions.Controls.Add(this.chbUpdatePeople);
            this.gbPermissions.Controls.Add(this.chbUpdateClient);
            this.gbPermissions.Controls.Add(this.chbUpdateUser);
            this.gbPermissions.Location = new System.Drawing.Point(402, 59);
            this.gbPermissions.Name = "gbPermissions";
            this.gbPermissions.Size = new System.Drawing.Size(419, 257);
            this.gbPermissions.TabIndex = 162;
            this.gbPermissions.TabStop = false;
            this.gbPermissions.Text = "Permissions";
            // 
            // chbSelectAll
            // 
            this.chbSelectAll.AutoSize = true;
            this.chbSelectAll.Location = new System.Drawing.Point(109, 29);
            this.chbSelectAll.Name = "chbSelectAll";
            this.chbSelectAll.Size = new System.Drawing.Size(116, 29);
            this.chbSelectAll.TabIndex = 179;
            this.chbSelectAll.Text = "Select All";
            this.chbSelectAll.UseVisualStyleBackColor = true;
            // 
            // chbUpdateEmployee
            // 
            this.chbUpdateEmployee.AutoSize = true;
            this.chbUpdateEmployee.Location = new System.Drawing.Point(213, 169);
            this.chbUpdateEmployee.Name = "chbUpdateEmployee";
            this.chbUpdateEmployee.Size = new System.Drawing.Size(189, 29);
            this.chbUpdateEmployee.TabIndex = 176;
            this.chbUpdateEmployee.Text = "Update Employee";
            this.chbUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // chbPeople
            // 
            this.chbPeople.AutoSize = true;
            this.chbPeople.Location = new System.Drawing.Point(32, 65);
            this.chbPeople.Name = "chbPeople";
            this.chbPeople.Size = new System.Drawing.Size(95, 29);
            this.chbPeople.TabIndex = 175;
            this.chbPeople.Text = "People";
            this.chbPeople.UseVisualStyleBackColor = true;
            // 
            // chbClient
            // 
            this.chbClient.AutoSize = true;
            this.chbClient.Location = new System.Drawing.Point(213, 61);
            this.chbClient.Name = "chbClient";
            this.chbClient.Size = new System.Drawing.Size(94, 29);
            this.chbClient.TabIndex = 174;
            this.chbClient.Text = "Clients";
            this.chbClient.UseVisualStyleBackColor = true;
            // 
            // chbUser
            // 
            this.chbUser.AutoSize = true;
            this.chbUser.Location = new System.Drawing.Point(32, 141);
            this.chbUser.Name = "chbUser";
            this.chbUser.Size = new System.Drawing.Size(85, 29);
            this.chbUser.TabIndex = 173;
            this.chbUser.Text = "Users";
            this.chbUser.UseVisualStyleBackColor = true;
            // 
            // chbEmployee
            // 
            this.chbEmployee.AutoSize = true;
            this.chbEmployee.Location = new System.Drawing.Point(213, 133);
            this.chbEmployee.Name = "chbEmployee";
            this.chbEmployee.Size = new System.Drawing.Size(131, 29);
            this.chbEmployee.TabIndex = 172;
            this.chbEmployee.Text = "Employees";
            this.chbEmployee.UseVisualStyleBackColor = true;
            // 
            // chbTransaction
            // 
            this.chbTransaction.AutoSize = true;
            this.chbTransaction.Location = new System.Drawing.Point(109, 214);
            this.chbTransaction.Name = "chbTransaction";
            this.chbTransaction.Size = new System.Drawing.Size(137, 29);
            this.chbTransaction.TabIndex = 171;
            this.chbTransaction.Text = "Transaction";
            this.chbTransaction.UseVisualStyleBackColor = true;
            // 
            // chbUpdatePeople
            // 
            this.chbUpdatePeople.AutoSize = true;
            this.chbUpdatePeople.Location = new System.Drawing.Point(32, 103);
            this.chbUpdatePeople.Name = "chbUpdatePeople";
            this.chbUpdatePeople.Size = new System.Drawing.Size(163, 29);
            this.chbUpdatePeople.TabIndex = 168;
            this.chbUpdatePeople.Text = "Update People";
            this.chbUpdatePeople.UseVisualStyleBackColor = true;
            // 
            // chbUpdateClient
            // 
            this.chbUpdateClient.AutoSize = true;
            this.chbUpdateClient.Location = new System.Drawing.Point(213, 97);
            this.chbUpdateClient.Name = "chbUpdateClient";
            this.chbUpdateClient.Size = new System.Drawing.Size(152, 29);
            this.chbUpdateClient.TabIndex = 164;
            this.chbUpdateClient.Text = "Update Client";
            this.chbUpdateClient.UseVisualStyleBackColor = true;
            // 
            // chbUpdateUser
            // 
            this.chbUpdateUser.AutoSize = true;
            this.chbUpdateUser.Location = new System.Drawing.Point(32, 179);
            this.chbUpdateUser.Name = "chbUpdateUser";
            this.chbUpdateUser.Size = new System.Drawing.Size(143, 29);
            this.chbUpdateUser.TabIndex = 163;
            this.chbUpdateUser.Text = "Update User";
            this.chbUpdateUser.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(534, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 144;
            this.label5.Text = "Permissions:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SystemBank.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(183, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 143;
            this.pictureBox2.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(223, 36);
            this.lblUserID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(48, 25);
            this.lblUserID.TabIndex = 142;
            this.lblUserID.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(92, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 141;
            this.label4.Text = "UserID:";
            // 
            // chkIsActive
            // 
            this.chkIsActive.AutoSize = true;
            this.chkIsActive.Checked = true;
            this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIsActive.Location = new System.Drawing.Point(221, 192);
            this.chkIsActive.Name = "chkIsActive";
            this.chkIsActive.Size = new System.Drawing.Size(108, 29);
            this.chkIsActive.TabIndex = 140;
            this.chkIsActive.Text = "Is Active";
            this.chkIsActive.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(221, 74);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(167, 30);
            this.txtUserName.TabIndex = 131;
            this.txtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtUserName_Validating);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(221, 146);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmPassword.MaxLength = 50;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(167, 30);
            this.txtConfirmPassword.TabIndex = 137;
            this.txtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtConfirmPassword_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 25);
            this.label1.TabIndex = 133;
            this.label1.Text = "UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 25);
            this.label3.TabIndex = 138;
            this.label3.Text = "Confirm Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 134;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(221, 110);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 30);
            this.txtPassword.TabIndex = 132;
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemBank.Properties.Resources.Number_32;
            this.pictureBox1.Location = new System.Drawing.Point(183, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 139;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::SystemBank.Properties.Resources.Person_32;
            this.pictureBox8.Location = new System.Drawing.Point(183, 72);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 136;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SystemBank.Properties.Resources.Number_32;
            this.pictureBox3.Location = new System.Drawing.Point(183, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 135;
            this.pictureBox3.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Image = global::SystemBank.Properties.Resources.Save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(685, 511);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 37);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::SystemBank.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(534, 511);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 552);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tcUserInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAddUpdateUser";
            this.Text = "Add Update User";
            this.Activated += new System.EventHandler(this.frmAddUpdateUser_Activated);
            this.Load += new System.EventHandler(this.frmAddUpdateUser_Load);
            this.tcUserInfo.ResumeLayout(false);
            this.tbPersonInfo.ResumeLayout(false);
            this.tbUserInfo.ResumeLayout(false);
            this.tbUserInfo.PerformLayout();
            this.gbPermissions.ResumeLayout(false);
            this.gbPermissions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcUserInfo;
        private System.Windows.Forms.TabPage tbPersonInfo;
        private ctrPersonInfoWithFilter ctrPersonInfoWithFilter1;
        private System.Windows.Forms.TabPage tbUserInfo;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIsActive;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPermissions;
        private System.Windows.Forms.CheckBox chbUpdateEmployee;
        private System.Windows.Forms.CheckBox chbPeople;
        private System.Windows.Forms.CheckBox chbClient;
        private System.Windows.Forms.CheckBox chbUser;
        private System.Windows.Forms.CheckBox chbEmployee;
        private System.Windows.Forms.CheckBox chbTransaction;
        private System.Windows.Forms.CheckBox chbUpdatePeople;
        private System.Windows.Forms.CheckBox chbUpdateClient;
        private System.Windows.Forms.CheckBox chbUpdateUser;
        private System.Windows.Forms.CheckBox chbSelectAll;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbPermissions;
    }
}