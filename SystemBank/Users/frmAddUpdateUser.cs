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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SystemBank
{
    public partial class frmAddUpdateUser : Form
    {
        private int _UserID = -1;
         clsUsers _User;

        public enum enMode { AddNew =0, Update =1 }
        public enMode Mode = enMode.AddNew;

    
        public frmAddUpdateUser()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            Mode = enMode.Update;
        }

        private void _RestDefultValues()
        {
            if(Mode == enMode.AddNew)
            {
                lbTitel.Text = "Add New User";
                this.Text = lbTitel.Text;
                _User = new clsUsers();

                btnSave.Enabled = false;
                tbUserInfo.Enabled = false;

                ctrPersonInfoWithFilter1.FilterFoucs();

            }
            else
            {
                lbTitel.Text = "Update User";
                this.Text = lbTitel .Text;      

                btnSave.Enabled = true;
                tbUserInfo.Enabled = true;
            }

            lblUserID.Text = "???";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
        }

        public void LoadData()
        {
            _User = clsUsers.Find(_UserID);
             
            if( _User == null )
            {
               // MessageBox.Show("No,User With ID ="+_UserID,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            lblUserID.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            txtPassword.Text = _User.Password.ToString();
            txtConfirmPassword.Text = _User.Password.ToString();
            lbPermissions.Text = _User.Permissions.ToString();

            ctrPersonInfoWithFilter1.LoadPersonInfo(_User. UserID);
        }

        private int _GetPermission()
        {
            int permission = 0;
            if (chbSelectAll.Checked)
            {
                permission += (int)clsUsers.enPermissions.eAll;
                return -1;
            }

            if (chbClient.Checked)
            {
                permission += (int)clsUsers.enPermissions.eClients;
                
            }
            if (chbPeople.Checked)
            {
                permission += (int)clsUsers.enPermissions.ePeople;
                
            }
            if (chbUser.Checked)
            {
                permission += (int)clsUsers.enPermissions.eUsers;
               
            }
            if (chbTransaction.Checked)
            {
                permission += (int)clsUsers.enPermissions.eTransations;
                
            }
            if (chbEmployee.Checked)
            {
                permission += (int)clsUsers.enPermissions.eEmployees;
                
            }
           
            if (chbUpdateClient.Checked)
            {
                permission += (int)clsUsers.enPermissions.eUpdateClient;
               
            }
            
            
            if (chbUpdatePeople.Checked)
            {
                permission += (int)clsUsers.enPermissions.eUpdatePeople;
                
            }
            
            
            if (chbUpdateUser.Checked)
            {
                permission += (int)clsUsers.enPermissions.eUpdateUser;
               
            }
            
           
            if (chbUpdateEmployee.Checked)
            {
                permission += (int)clsUsers.enPermissions.eUpdateEmploeeys;
                
            }
           


            return permission;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Mode == enMode.Update)
            {
                if (clsUsers.IsExistUser(ctrPersonInfoWithFilter1.PersonID))
                {
                    _UserID = ctrPersonInfoWithFilter1.PersonID;

                    btnSave.Enabled = true;
                    tbUserInfo.Enabled = true;

                    tcUserInfo.SelectedTab = tcUserInfo.TabPages["tbUserInfo"];

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Select a another User ", "Select a User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            else
            {
                if (ctrPersonInfoWithFilter1.PersonID != -1)
                {
                    if (!clsUsers.IsExistUser(ctrPersonInfoWithFilter1.PersonID))
                    {
                        MessageBox.Show("select Person Already has a Clients, choese onather one", "Select onather Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        btnSave.Enabled = true;
                        tbUserInfo.Enabled = true;
                        tcUserInfo.SelectedTab = tcUserInfo.TabPages["tbUserInfo"];

                    }
                }
                else
                {
                    MessageBox.Show("Please Select a User", "Select a User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrPersonInfoWithFilter1.FilterFoucs();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                   "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User.PersonID = ctrPersonInfoWithFilter1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = chkIsActive.Checked;
            _User.Permissions = _GetPermission();

            if(_User.Save())
            {
                lblUserID.Text = _User.UserID.ToString();
                Mode = enMode.Update;
                lbTitel.Text = "Ubdate User";
                this.Text = lblUserID.Text;
               

                MessageBox.Show("Data Save Souccessfully.","Save",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data Save not successfully","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "User Name is cannot blank");
            }
            else
            {
                errorProvider1.SetError(txtUserName,null);
            }

            if(Mode == enMode.AddNew)
            {
                if (clsUsers.IsExistUser(txtUserName.Text.Trim()))
                {
                    e.Cancel=true;
                    errorProvider1.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    errorProvider1.SetError(txtUserName, null);
                }
            }
            else
            {
                if(_User.UserName != txtUserName.Text.Trim())
                {
                    if(clsUsers.IsExistUser(txtUserName.Text))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtUserName, null);
                    }
                }
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Password Is cannot be blank");
            }
            else
            {
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if(txtConfirmPassword.Text.Trim() !=txtPassword.Text.Trim())
            {
                e.Cancel=true;
                errorProvider1.SetError(txtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPassword,null);
            }
        }

        private void frmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _RestDefultValues();
            if(Mode == enMode.Update)
            {
                LoadData();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdateUser_Activated(object sender, EventArgs e)
        {
            ctrPersonInfoWithFilter1.FilterFoucs();
        }
    }
}
 


