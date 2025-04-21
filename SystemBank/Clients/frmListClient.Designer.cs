namespace SystemBank
{
    partial class frmListClient
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
            this.lbRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAllClient = new System.Windows.Forms.DataGridView();
            this.cmsClients = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.showClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClient)).BeginInit();
            this.cmsClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Location = new System.Drawing.Point(115, 601);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(45, 25);
            this.lbRecord.TabIndex = 19;
            this.lbRecord.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 601);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "#Recored";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(393, 248);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(253, 30);
            this.txtFilter.TabIndex = 15;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Client ID",
            "Full Name",
            "Pin Code",
            "AccountNumber"});
            this.cbFilterBy.Location = new System.Drawing.Point(126, 244);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(251, 33);
            this.cbFilterBy.TabIndex = 14;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Filter By:";
            // 
            // dgvAllClient
            // 
            this.dgvAllClient.AllowUserToAddRows = false;
            this.dgvAllClient.AllowUserToDeleteRows = false;
            this.dgvAllClient.AllowUserToOrderColumns = true;
            this.dgvAllClient.BackgroundColor = System.Drawing.Color.White;
            this.dgvAllClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClient.ContextMenuStrip = this.cmsClients;
            this.dgvAllClient.Location = new System.Drawing.Point(9, 284);
            this.dgvAllClient.Name = "dgvAllClient";
            this.dgvAllClient.ReadOnly = true;
            this.dgvAllClient.RowHeadersWidth = 51;
            this.dgvAllClient.RowTemplate.Height = 24;
            this.dgvAllClient.Size = new System.Drawing.Size(956, 304);
            this.dgvAllClient.TabIndex = 12;
            // 
            // cmsClients
            // 
            this.cmsClients.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientToolStripMenuItem,
            this.edteClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem});
            this.cmsClients.Name = "cmsClients";
            this.cmsClients.Size = new System.Drawing.Size(227, 146);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(8, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(957, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mange Clients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Image = global::SystemBank.Properties.Resources.Close_32;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(828, 590);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 39);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Cloes";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Image = global::SystemBank.Properties.Resources.Add_Person_72;
            this.btnAdd.Location = new System.Drawing.Point(876, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 67);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // showClientToolStripMenuItem
            // 
            this.showClientToolStripMenuItem.Image = global::SystemBank.Properties.Resources.PersonDetails_32;
            this.showClientToolStripMenuItem.Name = "showClientToolStripMenuItem";
            this.showClientToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.showClientToolStripMenuItem.Text = "Show Client";
            this.showClientToolStripMenuItem.Click += new System.EventHandler(this.showClientToolStripMenuItem_Click);
            // 
            // edteClientToolStripMenuItem
            // 
            this.edteClientToolStripMenuItem.Image = global::SystemBank.Properties.Resources.edit_32;
            this.edteClientToolStripMenuItem.Name = "edteClientToolStripMenuItem";
            this.edteClientToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.edteClientToolStripMenuItem.Text = "Edte Client";
            this.edteClientToolStripMenuItem.Click += new System.EventHandler(this.edteClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Image = global::SystemBank.Properties.Resources.Delete_32;
            this.deleteClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SystemBank.Properties.Resources.People_512;
            this.pictureBox1.Location = new System.Drawing.Point(358, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 641);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAllClient);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmListClient";
            this.Text = "List Client";
            this.Load += new System.EventHandler(this.frmListClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClient)).EndInit();
            this.cmsClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAllClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip cmsClients;
        private System.Windows.Forms.ToolStripMenuItem showClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edteClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
    }
}