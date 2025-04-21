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
    public partial class frmListClient : Form
    {
        private DataTable _dtAllClient;
        private int _ClientID = -1;
        private clsClients _Client;
        
        public frmListClient()
        {
            InitializeComponent();
        }

        private void frmListClient_Load(object sender, EventArgs e)
        {
            _dtAllClient = clsClients.GetAllClients();
            dgvAllClient.DataSource = _dtAllClient;

            lbRecord.Text = _dtAllClient.Rows.Count.ToString();

            if(dgvAllClient.Rows.Count > 0 )
            {
                dgvAllClient.Columns[0].HeaderText = "Client ID";
                dgvAllClient.Columns[0].Width = 100;

                dgvAllClient.Columns[1].HeaderText = "Person ID";
                dgvAllClient.Columns[1].Width = 100;

                dgvAllClient.Columns[2].HeaderText = "Full Name";
                dgvAllClient.Columns[2].Width = 300;

                dgvAllClient.Columns[3].HeaderText = "Pin Code";
                dgvAllClient.Columns[3].Width = 110;

                dgvAllClient.Columns[4].HeaderText = "Account Number";
                dgvAllClient.Columns[4].Width = 150;

                dgvAllClient.Columns[5].HeaderText = "Account Balanc";
                dgvAllClient.Columns[5].Width = 150;


            }
            cbFilterBy.SelectedIndex = 0; 
            
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Visible = (cbFilterBy.Text == "None");
            if (txtFilter.Visible)
            {
                txtFilter.Visible = false;
            }
            else
            {
                txtFilter.Visible = true;
            }
                 txtFilter.Focus();

        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch(cbFilterBy.Text)
            {
                case "Client ID":
                    FilterColumn = "_ClientID";
                    break;
                case "Full Name":
                    FilterColumn = "FullName";
                    break;
                case "Pin Code":
                    FilterColumn = "PinCode";
                    break;
                case "Account Number":
                    FilterColumn = "AccountNumber";
                    break;
            }

            if(txtFilter.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllClient.DefaultView.RowFilter = "";
                lbRecord.Text = _dtAllClient.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "_ClientID")
                _dtAllClient.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txtFilter.Text.Trim());
            else
                _dtAllClient.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'",FilterColumn, txtFilter.Text.Trim());

            lbRecord.Text = _dtAllClient.Rows.Count. ToString();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cbFilterBy.Text == "Client ID")
                e.Handled = !char.IsDigit(e.KeyChar)&& !char.IsControl(e.KeyChar);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frm = new frmAddUpdateClient();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ClsGlobale.CurrentUser.CheckAccessPermission(clsUsers.enPermissions.eUpdateClient))
            {
                MessageBox.Show("Access Denied! Contact your Admin.");
                return;
            }
            
            int ClientID = (int)dgvAllClient.CurrentRow.Cells[0].Value;
            frmAddUpdateClient frm = new frmAddUpdateClient(ClientID);
            frm.ShowDialog();
        }

        private void showClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientInfo frm = new frmClientInfo((int)dgvAllClient.CurrentRow.Cells[0].Value);
            frm.ShowDialog();

            frmListClient_Load(null, null);
        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Suer you went Detele [ " + dgvAllClient.CurrentRow.Cells[0].Value+ "]","Confirm Detele",MessageBoxButtons.OKCancel,MessageBoxIcon.Question )==DialogResult.OK)
            {
                if (clsClients.DeleteClient((int)dgvAllClient.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Client Delete Successfully","Successfully",MessageBoxButtons.OK,MessageBoxIcon.Information );
                    frmListClient_Load(null,null);
                }
                else
                    MessageBox.Show("Client was not deleted because it has data linked to it.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
                   
        }
    }
}
