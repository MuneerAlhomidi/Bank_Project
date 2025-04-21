namespace SystemBank
{
    partial class frmTransactions
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
            this.tbcTransaction = new System.Windows.Forms.TabControl();
            this.tpDeposit = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btnserch = new System.Windows.Forms.Button();
            this.lbBalance = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudDeposit = new System.Windows.Forms.NumericUpDown();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.tpWithDraw = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbWithdraw = new System.Windows.Forms.Label();
            this.btnWithdarw = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tpTotalBalance = new System.Windows.Forms.TabPage();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbRecord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTotalBalance = new System.Windows.Forms.DataGridView();
            this.tbTransfer = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbLogregister = new System.Windows.Forms.TabPage();
            this.tbcTransaction.SuspendLayout();
            this.tpDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit)).BeginInit();
            this.tpWithDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tpTotalBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTransaction
            // 
            this.tbcTransaction.Controls.Add(this.tpDeposit);
            this.tbcTransaction.Controls.Add(this.tpWithDraw);
            this.tbcTransaction.Controls.Add(this.tpTotalBalance);
            this.tbcTransaction.Controls.Add(this.tbTransfer);
            this.tbcTransaction.Controls.Add(this.tbLogregister);
            this.tbcTransaction.Location = new System.Drawing.Point(0, 0);
            this.tbcTransaction.Name = "tbcTransaction";
            this.tbcTransaction.SelectedIndex = 0;
            this.tbcTransaction.Size = new System.Drawing.Size(661, 500);
            this.tbcTransaction.TabIndex = 0;
            // 
            // tpDeposit
            // 
            this.tpDeposit.Controls.Add(this.label2);
            this.tpDeposit.Controls.Add(this.btnserch);
            this.tpDeposit.Controls.Add(this.lbBalance);
            this.tpDeposit.Controls.Add(this.btnDeposit);
            this.tpDeposit.Controls.Add(this.label5);
            this.tpDeposit.Controls.Add(this.label3);
            this.tpDeposit.Controls.Add(this.label1);
            this.tpDeposit.Controls.Add(this.nudDeposit);
            this.tpDeposit.Controls.Add(this.txtAccountNumber);
            this.tpDeposit.Location = new System.Drawing.Point(4, 34);
            this.tpDeposit.Name = "tpDeposit";
            this.tpDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeposit.Size = new System.Drawing.Size(653, 462);
            this.tpDeposit.TabIndex = 0;
            this.tpDeposit.Text = "Deposit";
            this.tpDeposit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(249, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "$";
            // 
            // btnserch
            // 
            this.btnserch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnserch.Image = global::SystemBank.Properties.Resources.SearchPerson;
            this.btnserch.Location = new System.Drawing.Point(343, 90);
            this.btnserch.Name = "btnserch";
            this.btnserch.Size = new System.Drawing.Size(42, 37);
            this.btnserch.TabIndex = 15;
            this.btnserch.UseVisualStyleBackColor = true;
            this.btnserch.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.ForeColor = System.Drawing.Color.Green;
            this.lbBalance.Location = new System.Drawing.Point(265, 156);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(45, 25);
            this.lbBalance.TabIndex = 14;
            this.lbBalance.Text = "$$$";
            // 
            // btnDeposit
            // 
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(85, 343);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(214, 50);
            this.btnDeposit.TabIndex = 13;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Current Balance Is:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Deposit Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "AccountNumber:";
            // 
            // nudDeposit
            // 
            this.nudDeposit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.nudDeposit.Location = new System.Drawing.Point(80, 278);
            this.nudDeposit.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nudDeposit.Name = "nudDeposit";
            this.nudDeposit.Size = new System.Drawing.Size(219, 30);
            this.nudDeposit.TabIndex = 9;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtAccountNumber.Location = new System.Drawing.Point(79, 93);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(220, 30);
            this.txtAccountNumber.TabIndex = 8;
            this.txtAccountNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAccountNumber_KeyPress);
            this.txtAccountNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtAccountNumber_Validating);
            // 
            // tpWithDraw
            // 
            this.tpWithDraw.Controls.Add(this.label6);
            this.tpWithDraw.Controls.Add(this.button1);
            this.tpWithDraw.Controls.Add(this.lbWithdraw);
            this.tpWithDraw.Controls.Add(this.btnWithdarw);
            this.tpWithDraw.Controls.Add(this.label8);
            this.tpWithDraw.Controls.Add(this.label9);
            this.tpWithDraw.Controls.Add(this.label10);
            this.tpWithDraw.Controls.Add(this.numericUpDown1);
            this.tpWithDraw.Controls.Add(this.textBox1);
            this.tpWithDraw.Location = new System.Drawing.Point(4, 34);
            this.tpWithDraw.Name = "tpWithDraw";
            this.tpWithDraw.Padding = new System.Windows.Forms.Padding(3);
            this.tpWithDraw.Size = new System.Drawing.Size(653, 462);
            this.tpWithDraw.TabIndex = 1;
            this.tpWithDraw.Text = "WithDraw";
            this.tpWithDraw.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(246, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "$";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Image = global::SystemBank.Properties.Resources.SearchPerson;
            this.button1.Location = new System.Drawing.Point(340, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 37);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbWithdraw
            // 
            this.lbWithdraw.AutoSize = true;
            this.lbWithdraw.ForeColor = System.Drawing.Color.Green;
            this.lbWithdraw.Location = new System.Drawing.Point(262, 183);
            this.lbWithdraw.Name = "lbWithdraw";
            this.lbWithdraw.Size = new System.Drawing.Size(45, 25);
            this.lbWithdraw.TabIndex = 23;
            this.lbWithdraw.Text = "$$$";
            // 
            // btnWithdarw
            // 
            this.btnWithdarw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWithdarw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdarw.Location = new System.Drawing.Point(82, 370);
            this.btnWithdarw.Name = "btnWithdarw";
            this.btnWithdarw.Size = new System.Drawing.Size(214, 50);
            this.btnWithdarw.TabIndex = 22;
            this.btnWithdarw.Text = "Withdarw";
            this.btnWithdarw.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Current Balance Is:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Deposit Amount:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "AccountNumber:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.numericUpDown1.Location = new System.Drawing.Point(77, 305);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(219, 30);
            this.numericUpDown1.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.textBox1.Location = new System.Drawing.Point(76, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 30);
            this.textBox1.TabIndex = 17;
            // 
            // tpTotalBalance
            // 
            this.tpTotalBalance.Controls.Add(this.txtFilterValue);
            this.tpTotalBalance.Controls.Add(this.cbFilterBy);
            this.tpTotalBalance.Controls.Add(this.label11);
            this.tpTotalBalance.Controls.Add(this.btnClose);
            this.tpTotalBalance.Controls.Add(this.lbRecord);
            this.tpTotalBalance.Controls.Add(this.label4);
            this.tpTotalBalance.Controls.Add(this.dgvTotalBalance);
            this.tpTotalBalance.Location = new System.Drawing.Point(4, 34);
            this.tpTotalBalance.Name = "tpTotalBalance";
            this.tpTotalBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tpTotalBalance.Size = new System.Drawing.Size(653, 462);
            this.tpTotalBalance.TabIndex = 2;
            this.tpTotalBalance.Text = "TotalBalance";
            this.tpTotalBalance.UseVisualStyleBackColor = true;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(252, 66);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(171, 30);
            this.txtFilterValue.TabIndex = 8;
            this.txtFilterValue.TextChanged += new System.EventHandler(this.txtFilterValue_TextChanged);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Acc.Number",
            "Full Name"});
            this.cbFilterBy.Location = new System.Drawing.Point(102, 66);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(144, 33);
            this.cbFilterBy.TabIndex = 7;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Filter By:";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::SystemBank.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(512, 413);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecord.Location = new System.Drawing.Point(97, 425);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(48, 25);
            this.lbRecord.TabIndex = 2;
            this.lbRecord.Text = "???";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "#Record:";
            // 
            // dgvTotalBalance
            // 
            this.dgvTotalBalance.AllowUserToAddRows = false;
            this.dgvTotalBalance.AllowUserToDeleteRows = false;
            this.dgvTotalBalance.AllowUserToOrderColumns = true;
            this.dgvTotalBalance.BackgroundColor = System.Drawing.Color.White;
            this.dgvTotalBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTotalBalance.Location = new System.Drawing.Point(-1, 116);
            this.dgvTotalBalance.Name = "dgvTotalBalance";
            this.dgvTotalBalance.ReadOnly = true;
            this.dgvTotalBalance.RowHeadersWidth = 51;
            this.dgvTotalBalance.RowTemplate.Height = 24;
            this.dgvTotalBalance.Size = new System.Drawing.Size(651, 291);
            this.dgvTotalBalance.TabIndex = 0;
            // 
            // tbTransfer
            // 
            this.tbTransfer.Location = new System.Drawing.Point(4, 34);
            this.tbTransfer.Name = "tbTransfer";
            this.tbTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tbTransfer.Size = new System.Drawing.Size(653, 462);
            this.tbTransfer.TabIndex = 3;
            this.tbTransfer.Text = "Transfer";
            this.tbTransfer.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbLogregister
            // 
            this.tbLogregister.Location = new System.Drawing.Point(4, 34);
            this.tbLogregister.Name = "tbLogregister";
            this.tbLogregister.Padding = new System.Windows.Forms.Padding(3);
            this.tbLogregister.Size = new System.Drawing.Size(653, 462);
            this.tbLogregister.TabIndex = 4;
            this.tbLogregister.Text = "Logregister";
            this.tbLogregister.UseVisualStyleBackColor = true;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 504);
            this.Controls.Add(this.tbcTransaction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.tbcTransaction.ResumeLayout(false);
            this.tpDeposit.ResumeLayout(false);
            this.tpDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit)).EndInit();
            this.tpWithDraw.ResumeLayout(false);
            this.tpWithDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tpTotalBalance.ResumeLayout(false);
            this.tpTotalBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTransaction;
        private System.Windows.Forms.TabPage tpDeposit;
        private System.Windows.Forms.TabPage tpWithDraw;
        private System.Windows.Forms.TabPage tpTotalBalance;
        private System.Windows.Forms.TabPage tbTransfer;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudDeposit;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnserch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWithdarw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbWithdraw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvTotalBalance;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tbLogregister;
    }
}