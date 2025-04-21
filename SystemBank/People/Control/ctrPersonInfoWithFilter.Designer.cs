namespace SystemBank
{
    partial class ctrPersonInfoWithFilter
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
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddeNew = new System.Windows.Forms.Button();
            this.btnSerches = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrPersonInfo1 = new SystemBank.ctrPersonInfo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddeNew);
            this.gbFilter.Controls.Add(this.btnSerches);
            this.gbFilter.Controls.Add(this.txtFilter);
            this.gbFilter.Controls.Add(this.cbFilterBy);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(817, 77);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // btnAddeNew
            // 
            this.btnAddeNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddeNew.Image = global::SystemBank.Properties.Resources.AddPerson_321;
            this.btnAddeNew.Location = new System.Drawing.Point(632, 22);
            this.btnAddeNew.Name = "btnAddeNew";
            this.btnAddeNew.Size = new System.Drawing.Size(58, 40);
            this.btnAddeNew.TabIndex = 4;
            this.btnAddeNew.UseVisualStyleBackColor = true;
            this.btnAddeNew.Click += new System.EventHandler(this.btnAddeNew_Click);
            // 
            // btnSerches
            // 
            this.btnSerches.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSerches.Image = global::SystemBank.Properties.Resources.SearchPerson;
            this.btnSerches.Location = new System.Drawing.Point(560, 22);
            this.btnSerches.Name = "btnSerches";
            this.btnSerches.Size = new System.Drawing.Size(58, 40);
            this.btnSerches.TabIndex = 3;
            this.btnSerches.UseVisualStyleBackColor = true;
            this.btnSerches.Click += new System.EventHandler(this.btnSerches_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(327, 29);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(197, 30);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            this.txtFilter.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilter_Validating);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "NationalNo",
            "PersonID"});
            this.cbFilterBy.Location = new System.Drawing.Point(102, 26);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(208, 33);
            this.cbFilterBy.TabIndex = 1;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By :";
            // 
            // ctrPersonInfo1
            // 
            this.ctrPersonInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrPersonInfo1.Location = new System.Drawing.Point(0, 85);
            this.ctrPersonInfo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ctrPersonInfo1.Name = "ctrPersonInfo1";
            this.ctrPersonInfo1.Size = new System.Drawing.Size(830, 262);
            this.ctrPersonInfo1.TabIndex = 1;
            this.ctrPersonInfo1.Load += new System.EventHandler(this.ctrPersonInfo1_Load);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrPersonInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctrPersonInfo1);
            this.Controls.Add(this.gbFilter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ctrPersonInfoWithFilter";
            this.Size = new System.Drawing.Size(828, 344);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSerches;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnAddeNew;
        private ctrPersonInfo ctrPersonInfo1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
