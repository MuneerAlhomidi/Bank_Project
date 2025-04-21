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
    public partial class FrmMenu : Form
    {
        frmLogin _Login;
        public FrmMenu(frmLogin frm)
        {
            InitializeComponent();
            CustamazDesign();
            _Login = frm;
        }

        public FrmMenu()
        {
            InitializeComponent();
           
        }
        private int _PersonID = -1;
        clsPerson _Person;


       private void CustamazDesign()
        {
            panelUser.Visible = false;
            panelClients.Visible = false;
            panelEmployees.Visible = false;
            panelTransaction.Visible = false;
            panelPeople.Visible = false;
        }

      private void hidSubMenu()
        {
            if(panelPeople.Visible == true)
                panelPeople.Visible = false;
            if(panelClients.Visible == true)
                panelClients.Visible = false;
            if(panelEmployees.Visible == true)
                panelEmployees.Visible = false;
            if(panelTransaction.Visible == true)
                panelTransaction.Visible = false;
            if(panelUser.Visible == true)
                panelUser.Visible = false;
        }

        private void ShowSubMenu(Panel SubMenu)
        {
            if(SubMenu.Visible == false)
            {
                hidSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }

       public  bool CheckPermissionRight(clsUsers.enPermissions permissions)
        {
            if(!ClsGlobale.CurrentUser.CheckAccessPermission(permissions))
            {
                MessageBox.Show("Access Denied! Contact your Admin.");
                return false;
            }
            else
                return true;
        }

        private void btnTransation_Click(object sender, EventArgs e)
        {
            if (!CheckPermissionRight(clsUsers.enPermissions.eTransations))
            {
                return;
            }
            ShowSubMenu(panelTransaction);
        }

        private void btnPeople_Click(object sender, EventArgs e)
        {
            if(!CheckPermissionRight(clsUsers.enPermissions.ePeople))
            {
                return;
            }
            ShowSubMenu(panelPeople);
           
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            if (!CheckPermissionRight(clsUsers.enPermissions.eEmployees))
            {
                return;
            }
            ShowSubMenu(panelEmployees);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            if (!CheckPermissionRight(clsUsers.enPermissions.eClients))
            {
                return;
            }
            ShowSubMenu(panelClients);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!CheckPermissionRight(clsUsers.enPermissions.eUsers))
            {
                return;
            }
            ShowSubMenu(panelUser);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!CheckPermissionRight(clsUsers.enPermissions.eUpdatePeople))
            {
                return;
            }
            frmListPeople frm = new frmListPeople();
            frm.ShowDialog();
            
        }

        private void btnListPeople_Click(object sender, EventArgs e)
        {
            frmListPeople frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void btbListEmployees_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmAddUpdateClient frm = new frmAddUpdateClient();
            frm.ShowDialog();
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if(!CheckPermissionRight(clsUsers.enPermissions.eUpdateClient))
            {
                return;
            }
            frmAddUpdateClient frm = new frmAddUpdateClient(_PersonID);
            
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmListClient frm = new frmListClient();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(!CheckPermissionRight(clsUsers.enPermissions.eUpdateEmploeeys))
            {
                return;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            frmAddUpdateUser frm = new frmAddUpdateUser();
            frm.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!CheckPermissionRight(clsUsers.enPermissions.eUpdateUser))
            {
                return;
            }
            frmAddUpdateUser frm = new frmAddUpdateUser(_PersonID);
            frm.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            frmListUser frm = new frmListUser();
            frm.ShowDialog();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            frmCurrencies frm = new frmCurrencies();
            frm.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            frmTransactions frm = new frmTransactions();    
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ClsGlobale.CurrentUser = null;
            _Login.Show();
            this.Close();
        }

        //private void button21_Click(object sender, EventArgs e)
        //{
        //    frmListUsers frm = new frmListUsers();
        //    frm.ShowDialog();
        //}
    }
}
