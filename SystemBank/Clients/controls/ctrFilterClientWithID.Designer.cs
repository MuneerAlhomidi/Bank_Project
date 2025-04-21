namespace SystemBank
{
    partial class ctrFilterClientWithID
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
            this.components = new System.ComponentModel.Container();
            this.label7 = new System.Windows.Forms.Label();
            this.lbcurrentBalanceSoursAccount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSerch = new System.Windows.Forms.Button();
            this.FromAccountNumber = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbClientName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(283, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 25);
            this.label7.TabIndex = 42;
            this.label7.Text = "$";
            // 
            // lbcurrentBalanceSoursAccount
            // 
            this.lbcurrentBalanceSoursAccount.AutoSize = true;
            this.lbcurrentBalanceSoursAccount.ForeColor = System.Drawing.Color.Green;
            this.lbcurrentBalanceSoursAccount.Location = new System.Drawing.Point(307, 135);
            this.lbcurrentBalanceSoursAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcurrentBalanceSoursAccount.Name = "lbcurrentBalanceSoursAccount";
            this.lbcurrentBalanceSoursAccount.Size = new System.Drawing.Size(45, 25);
            this.lbcurrentBalanceSoursAccount.TabIndex = 41;
            this.lbcurrentBalanceSoursAccount.Text = "$$$";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 25);
            this.label14.TabIndex = 40;
            this.label14.Text = "Current Balance Is:";
            // 
            // btnSerch
            // 
            this.btnSerch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSerch.Image = global::SystemBank.Properties.Resources.SearchPerson;
            this.btnSerch.Location = new System.Drawing.Point(316, 38);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(59, 44);
            this.btnSerch.TabIndex = 39;
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.Serch_Click);
            // 
            // FromAccountNumber
            // 
            this.FromAccountNumber.AutoSize = true;
            this.FromAccountNumber.Location = new System.Drawing.Point(20, 15);
            this.FromAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FromAccountNumber.Name = "FromAccountNumber";
            this.FromAccountNumber.Size = new System.Drawing.Size(174, 25);
            this.FromAccountNumber.TabIndex = 38;
            this.FromAccountNumber.Text = " Account .Number:";
            // 
            // txtClientID
            // 
            this.txtClientID.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtClientID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClientID.Location = new System.Drawing.Point(25, 45);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(274, 30);
            this.txtClientID.TabIndex = 37;
            this.txtClientID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilerValue_KeyPress);
            this.txtClientID.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilerValue_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "Client Name:";
            // 
            // lbClientName
            // 
            this.lbClientName.AutoSize = true;
            this.lbClientName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbClientName.Location = new System.Drawing.Point(163, 100);
            this.lbClientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClientName.Name = "lbClientName";
            this.lbClientName.Size = new System.Drawing.Size(34, 25);
            this.lbClientName.TabIndex = 44;
            this.lbClientName.Text = "??";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrFilterClientWithID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbClientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbcurrentBalanceSoursAccount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSerch);
            this.Controls.Add(this.FromAccountNumber);
            this.Controls.Add(this.txtClientID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrFilterClientWithID";
            this.Size = new System.Drawing.Size(474, 182);
            this.Load += new System.EventHandler(this.ctrFilterClientWithID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbcurrentBalanceSoursAccount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSerch;
        private System.Windows.Forms.Label FromAccountNumber;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbClientName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
