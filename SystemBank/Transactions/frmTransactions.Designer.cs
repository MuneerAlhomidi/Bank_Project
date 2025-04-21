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
            this.ctrFilterClientWithID4 = new SystemBank.ctrFilterClientWithID();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDeposit = new System.Windows.Forms.NumericUpDown();
            this.tpWithDraw = new System.Windows.Forms.TabPage();
            this.ctrFilterClientWithID3 = new SystemBank.ctrFilterClientWithID();
            this.btnWithdarw = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.nudWithdraw = new System.Windows.Forms.NumericUpDown();
            this.tptotalBalance = new System.Windows.Forms.TabPage();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTotalBalance = new System.Windows.Forms.DataGridView();
            this.tbTransfer = new System.Windows.Forms.TabPage();
            this.nudTransferAmount = new System.Windows.Forms.NumericUpDown();
            this.ctrFilterClientWithID2 = new SystemBank.ctrFilterClientWithID();
            this.ctrFilterClientWithID1 = new SystemBank.ctrFilterClientWithID();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbtrancferLog = new System.Windows.Forms.TabPage();
            this.lbRecordRegistory = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransferLog = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbcTransaction.SuspendLayout();
            this.tpDeposit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit)).BeginInit();
            this.tpWithDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdraw)).BeginInit();
            this.tptotalBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalance)).BeginInit();
            this.tbTransfer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransferAmount)).BeginInit();
            this.tbtrancferLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcTransaction
            // 
            this.tbcTransaction.Controls.Add(this.tpDeposit);
            this.tbcTransaction.Controls.Add(this.tpWithDraw);
            this.tbcTransaction.Controls.Add(this.tptotalBalance);
            this.tbcTransaction.Controls.Add(this.tbTransfer);
            this.tbcTransaction.Controls.Add(this.tbtrancferLog);
            this.tbcTransaction.Location = new System.Drawing.Point(0, 0);
            this.tbcTransaction.Name = "tbcTransaction";
            this.tbcTransaction.SelectedIndex = 0;
            this.tbcTransaction.Size = new System.Drawing.Size(849, 506);
            this.tbcTransaction.TabIndex = 0;
            // 
            // tpDeposit
            // 
            this.tpDeposit.Controls.Add(this.ctrFilterClientWithID4);
            this.tpDeposit.Controls.Add(this.btnDeposit);
            this.tpDeposit.Controls.Add(this.label3);
            this.tpDeposit.Controls.Add(this.nudDeposit);
            this.tpDeposit.Location = new System.Drawing.Point(4, 34);
            this.tpDeposit.Name = "tpDeposit";
            this.tpDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tpDeposit.Size = new System.Drawing.Size(841, 468);
            this.tpDeposit.TabIndex = 0;
            this.tpDeposit.Text = "Deposit";
            this.tpDeposit.UseVisualStyleBackColor = true;
            // 
            // ctrFilterClientWithID4
            // 
            this.ctrFilterClientWithID4.BackColor = System.Drawing.Color.White;
            this.ctrFilterClientWithID4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrFilterClientWithID4.Location = new System.Drawing.Point(4, 20);
            this.ctrFilterClientWithID4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrFilterClientWithID4.Name = "ctrFilterClientWithID4";
            this.ctrFilterClientWithID4.Size = new System.Drawing.Size(474, 182);
            this.ctrFilterClientWithID4.TabIndex = 14;
            this.ctrFilterClientWithID4.OnClientSelected += new System.Action<int>(this.ctrFilterClientWithID4_OnClientSelected);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Deposit Amount:";
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
            // tpWithDraw
            // 
            this.tpWithDraw.Controls.Add(this.ctrFilterClientWithID3);
            this.tpWithDraw.Controls.Add(this.btnWithdarw);
            this.tpWithDraw.Controls.Add(this.label9);
            this.tpWithDraw.Controls.Add(this.nudWithdraw);
            this.tpWithDraw.Location = new System.Drawing.Point(4, 34);
            this.tpWithDraw.Name = "tpWithDraw";
            this.tpWithDraw.Padding = new System.Windows.Forms.Padding(3);
            this.tpWithDraw.Size = new System.Drawing.Size(841, 468);
            this.tpWithDraw.TabIndex = 1;
            this.tpWithDraw.Text = "WithDraw";
            this.tpWithDraw.UseVisualStyleBackColor = true;
            // 
            // ctrFilterClientWithID3
            // 
            this.ctrFilterClientWithID3.BackColor = System.Drawing.Color.White;
            this.ctrFilterClientWithID3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrFilterClientWithID3.Location = new System.Drawing.Point(4, 21);
            this.ctrFilterClientWithID3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrFilterClientWithID3.Name = "ctrFilterClientWithID3";
            this.ctrFilterClientWithID3.Size = new System.Drawing.Size(474, 182);
            this.ctrFilterClientWithID3.TabIndex = 23;
            this.ctrFilterClientWithID3.OnClientSelected += new System.Action<int>(this.ctrFilterClientWithID3_OnClientSelected);
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
            this.btnWithdarw.Click += new System.EventHandler(this.btnWithdarw_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Withdraw Amount:";
            // 
            // nudWithdraw
            // 
            this.nudWithdraw.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.nudWithdraw.Location = new System.Drawing.Point(77, 305);
            this.nudWithdraw.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nudWithdraw.Name = "nudWithdraw";
            this.nudWithdraw.Size = new System.Drawing.Size(219, 30);
            this.nudWithdraw.TabIndex = 18;
            // 
            // tptotalBalance
            // 
            this.tptotalBalance.Controls.Add(this.txtFilterValue);
            this.tptotalBalance.Controls.Add(this.cbFilterBy);
            this.tptotalBalance.Controls.Add(this.label11);
            this.tptotalBalance.Controls.Add(this.lbRecord);
            this.tptotalBalance.Controls.Add(this.label4);
            this.tptotalBalance.Controls.Add(this.dgvTotalBalance);
            this.tptotalBalance.Location = new System.Drawing.Point(4, 34);
            this.tptotalBalance.Name = "tptotalBalance";
            this.tptotalBalance.Padding = new System.Windows.Forms.Padding(3);
            this.tptotalBalance.Size = new System.Drawing.Size(841, 468);
            this.tptotalBalance.TabIndex = 2;
            this.tptotalBalance.Text = "TotalBalance";
            this.tptotalBalance.UseVisualStyleBackColor = true;
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(252, 26);
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
            this.cbFilterBy.Location = new System.Drawing.Point(102, 26);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(144, 33);
            this.cbFilterBy.TabIndex = 7;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 25);
            this.label11.TabIndex = 6;
            this.label11.Text = "Filter By:";
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
            this.dgvTotalBalance.Location = new System.Drawing.Point(3, 65);
            this.dgvTotalBalance.Name = "dgvTotalBalance";
            this.dgvTotalBalance.ReadOnly = true;
            this.dgvTotalBalance.RowHeadersWidth = 51;
            this.dgvTotalBalance.RowTemplate.Height = 24;
            this.dgvTotalBalance.Size = new System.Drawing.Size(835, 343);
            this.dgvTotalBalance.TabIndex = 0;
            // 
            // tbTransfer
            // 
            this.tbTransfer.Controls.Add(this.nudTransferAmount);
            this.tbTransfer.Controls.Add(this.ctrFilterClientWithID2);
            this.tbTransfer.Controls.Add(this.ctrFilterClientWithID1);
            this.tbTransfer.Controls.Add(this.btnTransfer);
            this.tbTransfer.Controls.Add(this.label13);
            this.tbTransfer.Location = new System.Drawing.Point(4, 34);
            this.tbTransfer.Name = "tbTransfer";
            this.tbTransfer.Padding = new System.Windows.Forms.Padding(3);
            this.tbTransfer.Size = new System.Drawing.Size(841, 468);
            this.tbTransfer.TabIndex = 3;
            this.tbTransfer.Text = "Transfer";
            this.tbTransfer.UseVisualStyleBackColor = true;
            // 
            // nudTransferAmount
            // 
            this.nudTransferAmount.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.nudTransferAmount.Location = new System.Drawing.Point(296, 233);
            this.nudTransferAmount.Maximum = new decimal(new int[] {
            -1530494976,
            232830,
            0,
            0});
            this.nudTransferAmount.Name = "nudTransferAmount";
            this.nudTransferAmount.Size = new System.Drawing.Size(219, 30);
            this.nudTransferAmount.TabIndex = 36;
            // 
            // ctrFilterClientWithID2
            // 
            this.ctrFilterClientWithID2.BackColor = System.Drawing.Color.White;
            this.ctrFilterClientWithID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrFilterClientWithID2.Location = new System.Drawing.Point(4, 8);
            this.ctrFilterClientWithID2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrFilterClientWithID2.Name = "ctrFilterClientWithID2";
            this.ctrFilterClientWithID2.Size = new System.Drawing.Size(410, 160);
            this.ctrFilterClientWithID2.TabIndex = 35;
            this.ctrFilterClientWithID2.OnClientSelected += new System.Action<int>(this.ctrFilterClientWithID2_OnClientSelected);
            // 
            // ctrFilterClientWithID1
            // 
            this.ctrFilterClientWithID1.BackColor = System.Drawing.Color.White;
            this.ctrFilterClientWithID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrFilterClientWithID1.Location = new System.Drawing.Point(402, 8);
            this.ctrFilterClientWithID1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrFilterClientWithID1.Name = "ctrFilterClientWithID1";
            this.ctrFilterClientWithID1.Size = new System.Drawing.Size(431, 160);
            this.ctrFilterClientWithID1.TabIndex = 34;
            this.ctrFilterClientWithID1.OnClientSelected += new System.Action<int>(this.ctrFilterClientWithID1_OnClientSelected);
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTransfer.Location = new System.Drawing.Point(334, 269);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(146, 43);
            this.btnTransfer.TabIndex = 33;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(316, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "Transfer Amount:";
            // 
            // tbtrancferLog
            // 
            this.tbtrancferLog.Controls.Add(this.lbRecordRegistory);
            this.tbtrancferLog.Controls.Add(this.label2);
            this.tbtrancferLog.Controls.Add(this.label1);
            this.tbtrancferLog.Controls.Add(this.dgvTransferLog);
            this.tbtrancferLog.Location = new System.Drawing.Point(4, 34);
            this.tbtrancferLog.Name = "tbtrancferLog";
            this.tbtrancferLog.Padding = new System.Windows.Forms.Padding(3);
            this.tbtrancferLog.Size = new System.Drawing.Size(841, 468);
            this.tbtrancferLog.TabIndex = 4;
            this.tbtrancferLog.Text = "TransferLog";
            this.tbtrancferLog.UseVisualStyleBackColor = true;
            // 
            // lbRecordRegistory
            // 
            this.lbRecordRegistory.AutoSize = true;
            this.lbRecordRegistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordRegistory.Location = new System.Drawing.Point(103, 417);
            this.lbRecordRegistory.Name = "lbRecordRegistory";
            this.lbRecordRegistory.Size = new System.Drawing.Size(48, 25);
            this.lbRecordRegistory.TabIndex = 3;
            this.lbRecordRegistory.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "#Record:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(835, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "TransferLog";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTransferLog
            // 
            this.dgvTransferLog.AllowUserToAddRows = false;
            this.dgvTransferLog.AllowUserToDeleteRows = false;
            this.dgvTransferLog.AllowUserToOrderColumns = true;
            this.dgvTransferLog.BackgroundColor = System.Drawing.Color.White;
            this.dgvTransferLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransferLog.Location = new System.Drawing.Point(8, 80);
            this.dgvTransferLog.Name = "dgvTransferLog";
            this.dgvTransferLog.ReadOnly = true;
            this.dgvTransferLog.RowHeadersWidth = 51;
            this.dgvTransferLog.RowTemplate.Height = 24;
            this.dgvTransferLog.Size = new System.Drawing.Size(826, 324);
            this.dgvTransferLog.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 510);
            this.Controls.Add(this.tbcTransaction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTransactions";
            this.Text = "frmTransactions";
            this.Activated += new System.EventHandler(this.frmTransactions_Activated);
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.tbcTransaction.ResumeLayout(false);
            this.tpDeposit.ResumeLayout(false);
            this.tpDeposit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeposit)).EndInit();
            this.tpWithDraw.ResumeLayout(false);
            this.tpWithDraw.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWithdraw)).EndInit();
            this.tptotalBalance.ResumeLayout(false);
            this.tptotalBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTotalBalance)).EndInit();
            this.tbTransfer.ResumeLayout(false);
            this.tbTransfer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTransferAmount)).EndInit();
            this.tbtrancferLog.ResumeLayout(false);
            this.tbtrancferLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransferLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcTransaction;
        private System.Windows.Forms.TabPage tpDeposit;
        private System.Windows.Forms.TabPage tpWithDraw;
        private System.Windows.Forms.TabPage tptotalBalance;
        private System.Windows.Forms.TabPage tbTransfer;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDeposit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnWithdarw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudWithdraw;
        private System.Windows.Forms.DataGridView dgvTotalBalance;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tbtrancferLog;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTransfer;
        private ctrFilterClientWithID ctrFilterClientWithID2;
        private ctrFilterClientWithID ctrFilterClientWithID1;
        private ctrFilterClientWithID ctrFilterClientWithID4;
        private ctrFilterClientWithID ctrFilterClientWithID3;
        private System.Windows.Forms.NumericUpDown nudTransferAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTransferLog;
        private System.Windows.Forms.Label lbRecordRegistory;
        private System.Windows.Forms.Label label2;
    }
}