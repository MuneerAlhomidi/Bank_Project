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
    public partial class frmListPeople : Form
    {
       

        private static DataTable _dtAllPeople = clsPerson.GetAllPerson();
        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo", "FirstName",
                                                                              "SecondName", "ThirdName", "LastName",
                                                                               "DateOfBirth", "GendorCaption", "Phone",
                                                                               "CountryName", "Email", "ImagePath");

        private int _PersonID;
        private clsPerson _Person;

        public frmListPeople()
        {
            InitializeComponent();
        }

        private void frmListPeople_Load(object sender, EventArgs e)
        {

            dgvAllPeople.DataSource = _dtPeople;

            lbRecord.Text = _dtAllPeople.Rows.Count.ToString();
            if (dgvAllPeople.Rows.Count > 0)
            {
                dgvAllPeople.Columns[0].HeaderText = "Person ID";
                dgvAllPeople.Columns[0].Width = 100;

                dgvAllPeople.Columns[1].HeaderText = "National No";
                dgvAllPeople.Columns[1].Width = 110;

                dgvAllPeople.Columns[2].HeaderText = "First Name";
                dgvAllPeople.Columns[2].Width = 110;

                dgvAllPeople.Columns[3].HeaderText = "Second Name";
                dgvAllPeople.Columns[3].Width = 110;

                dgvAllPeople.Columns[4].HeaderText = "Third Name";
                dgvAllPeople.Columns[4].Width = 110;

                dgvAllPeople.Columns[5].HeaderText = "Last Name";
                dgvAllPeople.Columns[5].Width = 110;

                dgvAllPeople.Columns[6].HeaderText = "Date Of Birth";
                dgvAllPeople.Columns[6].Width = 140;

                dgvAllPeople.Columns[7].HeaderText = "Gengor";
                dgvAllPeople.Columns[7].Width = 100;

                dgvAllPeople.Columns[8].HeaderText = "Phone";
                dgvAllPeople.Columns[8].Width = 120;

                dgvAllPeople.Columns[9].HeaderText = "Nationalty";
                dgvAllPeople.Columns[9].Width = 120;


                dgvAllPeople.Columns[10].HeaderText = "Email";
                dgvAllPeople.Columns[10].Width = 170;
            }
            cbFilterBy.SelectedIndex = 0; 
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbFilterBy.Text == "None")
            {
                txtFilter.Visible = false;
            }
            else
            {
                txtFilter.Visible = true;
                FilterFoucs();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string ColumnFilter = "";
            switch (cbFilterBy.Text)
            {
                case "Person ID":
                    ColumnFilter = "PersonID";
                    break;
                case "National No":
                    ColumnFilter = "NationalNo";
                    break;
                case "First Name":
                    ColumnFilter = "FirstName";
                    break;
                case "Last Name":
                    ColumnFilter = "LastNAme";
                    break;
                case "Date Of Birth":
                    ColumnFilter = "DateOfBirth";
                    break;
                case "Gendor":
                    ColumnFilter = "Gendor";
                    break;
                case "Phone":
                    ColumnFilter = "Phone";
                    break;
                case "Email":
                    ColumnFilter = "Email";
                    break;

            }

            if (txtFilter.Text.Trim() == "" || ColumnFilter == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lbRecord.Text = _dtPeople.Rows.Count.ToString();
                return;
            }

            if(ColumnFilter == "PersonID")
            
              // _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}",ColumnFilter,txtFilter.Text.Trim());
             _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", ColumnFilter, txtFilter.Text.Trim());


            else
                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE  '{1}%'",ColumnFilter,txtFilter.Text.Trim());

            lbRecord.Text = _dtPeople.Rows.Count.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            frmListPeople_Load(null,null);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FilterFoucs()
        {
            txtFilter.Focus();
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetilsPerson frm = new frmDetilsPerson((int)dgvAllPeople.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (!ClsGlobale.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.eUpdatePeople))
            {
                MessageBox.Show("Access Denied! Contact your Admin.");
                return ;
            }
           
                
            int PersonID = (int)dgvAllPeople.CurrentRow.Cells[0].Value;
            frmAddUpdatePerson frm = new frmAddUpdatePerson(PersonID);
            frm.ShowDialog();
            frmListPeople_Load(null,null);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sour you went Delete Client ["+ dgvAllPeople.CurrentRow.Cells[0].Value +"]","Confirm Detele",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)== DialogResult.OK)
            {
                if (clsPerson.Delete((int)dgvAllPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Delete Successfully.","Confirm Delete",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    frmListPeople_Load(null, null);
                }
                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
