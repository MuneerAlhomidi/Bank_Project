using Bank_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SystemBank
{
    public partial class frmLogin : Form
    {
        private int Counter = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (ClsGlobale.GetStoredCredential1(ref UserName, ref Password))
            {
                txtUserName.Text = UserName;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
                chkRememberMe.Checked = false;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Password = clsHashing.ComputeHash(txtPassword.Text);
            clsUsers user = clsUsers.FindUserByUserNameAndPassword(txtUserName.Text.Trim(),txtPassword.Text.Trim());
            if (user != null)
            {

                if (chkRememberMe.Checked)
                {
                    //store username and password
                    ClsGlobale.RememberUsernameAndPassword1(txtUserName.Text.Trim(), Password);

                }
                else
                {
                    //store empty username and password
                    ClsGlobale.RememberUsernameAndPassword1("", "");

                }

                //incase the user is not active
                if (!user.IsActive)
                {

                    txtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClsGlobale.CurrentUser = user;
                this.Hide();
                FrmMenu frm = new FrmMenu(this);
                frm.ShowDialog();


            }
            else
            {
                

                txtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credintials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
               if (Counter <= 3)
                {
                    Counter++;
                    ClsGlobale.SaveToEventViewer("3 Fild Login Trials",System.Diagnostics.EventLogEntryType.Error);
                    btnLogin.Enabled = false;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
