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
    public partial class frmAddUpdateClient : Form
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public delegate void DataBackHandel(object sender, int PersonID);
        public event DataBackHandel DataBack;

        private int _ClientID = -1;
        private int _SelectedPersonID = 0;
        public int CLientID
        {
            get { return ctrPersonInfoWithFilter1.PersonID; }
        }
        //
        private clsClients _Client;

        public frmAddUpdateClient()
        {
            InitializeComponent();
            Mode = enMode.AddNew;
        }

        public frmAddUpdateClient(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
            Mode = enMode.Update;

           
        }

        private void frmAddUpdateClient_Load(object sender, EventArgs e)
        {
            _RestDefultValue();

            if(Mode == enMode.Update)

                LoadData();

            
          
        }

        private void _RestDefultValue()
        {
            if (Mode == enMode.AddNew)
            {
                lbTital.Text = "Add New Client";
                this.Text = lbTital.Text;
                _Client = new clsClients();

                btnSave.Enabled = false;
                tbClientInfo.Enabled = false;

                ctrPersonInfoWithFilter1.FilterFoucs();
            }
            else
            {
                lbTital.Text = "Update Client";
                this.Text = lbTital.Text;
                btnSave.Enabled = true;
                tbClientInfo.Enabled = true;
            }


            txtPinCode.Text = "";
            txtAccountBalanc.Text = "";
            txtAccountNumber.Text = "";
            txtConfirmPinCode.Text = "";
        }

        public void LoadData()
        { 
                _Client = clsClients.Find(_ClientID);

            if(_Client == null)
            {
               // MessageBox.Show("No,Client with ID = "+ _ClientID , "Client Not Found",MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;
            }

            lbClientID.Text = _Client.ClientID.ToString();
            txtAccountNumber.Text = _Client.AccountNumber;
            txtAccountBalanc.Text = _Client.AccountBalanc.ToString();
            txtPinCode.Text = _Client.PinCode;
            txtConfirmPinCode.Text = _Client.PinCode;

            ctrPersonInfoWithFilter1.LoadPersonInfo(_Client.ClientID);
           
        }

        public  void DataBackEvent(object sender, int ClientID)
        {
            // Handle the data received
            ctrPersonInfoWithFilter1.PersonID = ClientID;

        }

      

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (Mode == enMode.Update)
            {

                if (clsClients.IsExistClientForPerson(ctrPersonInfoWithFilter1.PersonID))
                {

                    _ClientID = ctrPersonInfoWithFilter1.PersonID;

                    btnSave.Enabled = true;
                    tbClientInfo.Enabled = true;
                    tcPersonInfo.SelectedTab = tcPersonInfo.TabPages["tbClientInfo"];
                    
                    LoadData();
                    
                }
                else
                {

                    MessageBox.Show("Please Select a Client", "Select a Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrPersonInfoWithFilter1.FilterFoucs();
                }



                return;
            }
            else
            {

                if (ctrPersonInfoWithFilter1.PersonID != -1)
                {
                    if (clsClients.IsExistClientForPerson(ctrPersonInfoWithFilter1.PersonID))
                    {
                        MessageBox.Show("Selected person already has a Client, choose another one.", "Select another Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ctrPersonInfoWithFilter1.FilterFoucs();
                    }
                    else
                    {

                        btnSave.Enabled = true;
                        tbClientInfo.Enabled = true;
                        tcPersonInfo.SelectedTab = tcPersonInfo.TabPages["tbClientInfo"];
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a Client", "Select a Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrPersonInfoWithFilter1.FilterFoucs();
                }
            }
            
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);
            if(string.IsNullOrEmpty(temp.Text) )
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "this fild requerd!");
            }
            else
            {
                errorProvider1.SetError(temp,null);
            }
        }

        private void txtConfirmPinCode_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtConfirmPinCode.Text.Trim()))
            {
                e.Cancel= true;
                errorProvider1.SetError(txtConfirmPinCode, "This Fild Requerd!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPinCode, null);
            }

            if(txtConfirmPinCode.Text.Trim() != txtPinCode.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPinCode, "Pin Code Confirmation does not match Pin Code!");
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

            _Client.PinCode = txtPinCode.Text;
            _Client.PersonID = ctrPersonInfoWithFilter1.PersonID;
            _Client.AccountNumber = txtAccountNumber.Text;
            _Client.AccountBalanc =Convert.ToSingle( txtAccountBalanc.Text);
            
            if(_Client.Save())
            {

                lbClientID.Text = _Client.ClientID.ToString();
                Mode = enMode.Update;
                lbTital.Text = "Update Client";
                this.Text = lbTital.Text;
                MessageBox.Show("Data Save SuccessFully","Save",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            MessageBox.Show("Data is Not Save Succssfully","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCloes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrPersonInfoWithFilter1_OnPersonSelected(int obj)
        {
            _SelectedPersonID = obj;

            if(ctrPersonInfoWithFilter1.PersonID != -1 )
            {
                ctrPersonInfoWithFilter1.FilterEnable = false;
            }

            MessageBox.Show("select person with ID = " + _SelectedPersonID, "Select", MessageBoxButtons.OK);


        }

        private void frmAddUpdateClient_Activated(object sender, EventArgs e)
        {
            ctrPersonInfoWithFilter1.FilterFoucs();
        }
    }
}
