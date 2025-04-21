using Bank_Buisness;
using System;
using System.Windows.Forms;

namespace SystemBank
{
    public partial class ctrFilterClientWithID : UserControl
    {
        public event Action<int> OnClientSelected;

        protected virtual void ClientSelected (int ClientID)
        {
            Action<int> handler = OnClientSelected;
            if(handler != null)
            {
                handler (ClientID);
            }
        }

        private int _ClientID = -1;

        public clsClients _Client;

        public clsClients SelectClientInfo
        {
            get { return _Client; }
        }

        public int clientID
        { 
            get { return _ClientID; }
        }
      
      
        public ctrFilterClientWithID()
        {
            InitializeComponent();
        }

       
        public void LoadClientInfo(int ClientID)
        {
          
            _Client = clsClients.Find(int.Parse(txtClientID.Text));
            

            if (_Client == null)
            {
                MessageBox.Show("Sorry,this client is not Found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lbClientName.Text = _Client.PersonInfo.FullName;
            lbcurrentBalanceSoursAccount.Text = _Client.AccountBalanc.ToString();

            if(OnClientSelected != null)
                ClientSelected(_Client.ClientID);
            
        }

        private void Serch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FilterFoucstcr();
                return;
            }
            LoadClientInfo(clientID);
            
        }

        private void txtFilerValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btnSerch.PerformClick();
            }
           
           e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtFilerValue_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtClientID.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtClientID, "Same fild requerd!");
            }
            else
            {
                errorProvider1.SetError( txtClientID,null);
            }
        }

        public void FilterFoucstcr()
        {
            txtClientID.Focus();  
        }

        private void ctrFilterClientWithID_Load(object sender, EventArgs e)
        {
            FilterFoucstcr();
        }
    }
}
