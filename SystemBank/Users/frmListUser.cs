using Bank_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemBank
{
    public partial class frmListUser : Form
    {
        public frmListUser()
        {
            InitializeComponent();
        }

        public DataTable _dtAllUsers;
        

     
        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            La.Text = _dtAllUsers.Rows.Count.ToString();

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FiltrColumn = "";
            switch (cbFilterBy.Text)
            {
                case "User ID":
                    FiltrColumn = "UserID";
                    break;
                case "Person ID":
                    FiltrColumn = "PersonID";
                    break;
                case "User Name ":
                    FiltrColumn = "UserName";
                    break;
                case "Is Active":
                    FiltrColumn = "IsActive";
                    break;

                default:
                    FiltrColumn = "None";
                    break;
            }

            if (FiltrColumn == "None" || txtFilter.Text.Trim() == "")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                La.Text = _dtAllUsers.Rows.Count.ToString();
                return;
            }

            if (FiltrColumn == "UserName")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FiltrColumn, txtFilter.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FiltrColumn, txtFilter.Text.Trim());

            La.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        public void FilterFoucs()
        {
            txtFilter.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sour you went Delete Client [" + dgvAllUsers.CurrentRow.Cells[0].Value + "]", "Confirm Detele", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPerson.Delete((int)dgvAllUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Delete Successfully.", "Confirm Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmListUser_Load(null, null);
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void eidtUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser((int)dgvAllUsers.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmListUser_Load(null, null);
        }

        private void frmListUser_Load(object sender, EventArgs e)
        {
            _dtAllUsers = clsUsers.GetAllUser();
            dgvAllUsers.DataSource = _dtAllUsers;

            La.Text = _dtAllUsers.Rows.Count.ToString();
            if (dgvAllUsers.Rows.Count > 0)
            {
                dgvAllUsers.Columns[0].HeaderText = "User ID";
                dgvAllUsers.Columns[0].Width = 100;

                dgvAllUsers.Columns[1].HeaderText = "Person ID";
                dgvAllUsers.Columns[1].Width = 100;

                dgvAllUsers.Columns[2].HeaderText = "User Name";
                dgvAllUsers.Columns[2].Width = 120;

                dgvAllUsers.Columns[3].HeaderText = "Password";
                dgvAllUsers.Columns[3].Width = 120;

                dgvAllUsers.Columns[4].HeaderText = "Is Active";
                dgvAllUsers.Columns[4].Width = 120;

                dgvAllUsers.Columns[5].HeaderText = "Permission ";
                dgvAllUsers.Columns[5].Width = 120;


            }

            cbFilterBy.SelectedIndex = 0;
        }

        private void cbFilterBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "Is Active")
            {
                txtFilter.Visible = false;
                cbIsActive.Visible = true;
                cbIsActive.Focus();
                cbIsActive.SelectedIndex = 0;
            }
            else
            {
                txtFilter.Visible = (cbFilterBy.Text != "None");
                cbIsActive.Visible = false;
                if (cbFilterBy.Text == "None")
                {
                    txtFilter.Enabled = false;

                }
                else
                {
                    txtFilter.Enabled = true;
                    FilterFoucs();
                }
                txtFilter.Text = "";
                
            }
        }

        private void cbIsActive_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            string FilterColumn = "IsActive";
            string FilterValue = cbIsActive.Text;

            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }


            if (FilterValue == "All")
                _dtAllUsers.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            La.Text = _dtAllUsers.Rows.Count.ToString();

        }

        private void txtFilter_TextChanged_1(object sender, EventArgs e)
        {
            string FiltrColumn = "";
            switch (cbFilterBy.Text)
            {
                case "User ID":
                    FiltrColumn = "UserID";
                    break;
                case "Person ID":
                    FiltrColumn = "PersonID";
                    break;
                case "User Name ":
                    FiltrColumn = "UserName";
                    break;
                case "Password":
                    FiltrColumn = "Password";
                    break;
                case "Is Active":
                    FiltrColumn = "IsActive";
                    break;

                default:
                    FiltrColumn = "None";
                    break;
            }

            if (FiltrColumn == "None" || txtFilter.Text.Trim() == "")
            {
                _dtAllUsers.DefaultView.RowFilter = "";
                La.Text = _dtAllUsers.Rows.Count.ToString();
                return;
            }

            if (FiltrColumn != "UserName")
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FiltrColumn, txtFilter.Text.Trim());
            else
                _dtAllUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FiltrColumn, txtFilter.Text.Trim());

            La.Text = _dtAllUsers.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
            frmListUser_Load(null, null);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFilter_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "User ID" || cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

