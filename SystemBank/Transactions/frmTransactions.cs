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
    public partial class frmTransactions : Form
    {
        public delegate void BackEventHandler(object sender, int ClientID);
        public event BackEventHandler DataBackHandler;

        private clsClients _Client;
        private int _ClientID = -1;

        private int _SouresID = -1;
        private int _DesposationID = -1;
        
        private static DataTable _TotalBalance ;

        private static DataTable _TransferLog ;

     
        public frmTransactions()
        {
            InitializeComponent();
        }

        public frmTransactions(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            TransLog();
            TotalBalance();
            ctrFilterClientWithID1.FilterFoucstcr();
        }

        private void TransLog()
        {
            _TransferLog = ClsTransferLog.GetAllTransferLog();
            dgvTransferLog.DataSource = _TransferLog;
            lbRecordRegistory.Text = dgvTransferLog.Rows.Count.ToString();

            if (dgvTransferLog.Rows.Count > 0)
            {
                dgvTransferLog.Columns[0].HeaderText = "Data time";
                dgvTransferLog.Columns[0].Width = 170;

                dgvTransferLog.Columns[1].HeaderText = "Sourse.Acc";
                dgvTransferLog.Columns[1].Width = 110;

                dgvTransferLog.Columns[2].HeaderText = "Destintion.Acc";
                dgvTransferLog.Columns[2].Width = 110;

                dgvTransferLog.Columns[3].HeaderText = "Amount";
                dgvTransferLog.Columns[3].Width = 110;

                dgvTransferLog.Columns[4].HeaderText = "Soures.Blan";
                dgvTransferLog.Columns[4].Width = 110;

                dgvTransferLog.Columns[5].HeaderText = "Destintion.Bala";
                dgvTransferLog.Columns[5].Width = 110;
            }
        }

        private void TotalBalance()
        {
            _TotalBalance = clsClients.GetTotalBalance();
            dgvTotalBalance.DataSource = _TotalBalance;
            lbRecord.Text = _TotalBalance.Rows.Count.ToString();

            if (_TotalBalance.Rows.Count > 0)
            {
                dgvTotalBalance.Columns[0].HeaderText = "Acc.Number";
                dgvTotalBalance.Columns[0].Width = 170;

                dgvTotalBalance.Columns[1].HeaderText = "Full Name";
                dgvTotalBalance.Columns[1].Width = 370;

                dgvTotalBalance.Columns[2].HeaderText = "Acc.Balance";
                dgvTotalBalance.Columns[2].Width = 170;
            }

            

            cbFilterBy.SelectedIndex = 0;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            float Amount = 0;

                if(_ClientID == -1)
            {
                return;
            }

                if (nudDeposit.Value < 0)
                {
                MessageBox.Show("Insufficient funds. Please enter a valid Deposit amount.");
                return;
                }
                else
                {
                    Amount = (float)nudDeposit.Value;
                    _Client.Deposit(Amount);
                
                     MessageBox.Show("Withdrawal successful. Your new balance is: " + _Client.AccountBalanc);
                     btnDeposit.Enabled = false;
                }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;
            }
           else
                txtFilterValue.Visible= true;
            FilterFoucs();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
       {
            string ColumanFilter = "";

            switch(cbFilterBy.Text)
            {
                case "Acc.Number":
                    ColumanFilter = "AccountNumber";
                    break;
                case "Full Name":
                    ColumanFilter = "fullName";
                    break;
                default: ColumanFilter = "None";
                    break;
            }

            if (  txtFilterValue.Text.Trim() == "" || ColumanFilter == "None")
            {
                _TotalBalance.DefaultView.RowFilter = "";
                lbRecord.Text = _TotalBalance.Rows.Count.ToString();
                return;
            }

            if (ColumanFilter == "fullName" || ColumanFilter == "AccountNumber")
              
            _TotalBalance.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'",ColumanFilter,txtFilterValue.Text.Trim());
            lbRecord.Text = _TotalBalance.Rows.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FilterFoucs()
        {
            txtFilterValue.Focus();
        }

        private void SoursAccount_Click(object sender, EventArgs e)
        {
            _Client = clsClients.Find(_ClientID);
            if (_Client == null)
            {
                MessageBox.Show("This Client is Not Found.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtFilterValue.Text = _Client.ClientID.ToString();
            }
        }

        private void btnWithdarw_Click_1(object sender, EventArgs e)
        {
            float amount = (float)nudWithdraw.Value;
            int ClientId = -1;
            if (amount > _Client.AccountBalanc)
            {
                MessageBox.Show("Insufficient funds. Please enter a valid withdrawal amount.");
                return;
            }
            else
            {
               
                _Client.WithDraw(amount);
               
                btnDeposit.Enabled = false;
                 MessageBox.Show("Withdrawal successful. Your new balance is: " + _Client.AccountBalanc);
            }
        }

        private void ctrFilterClientWithID1_Load(object sender, EventArgs e)
        {
             ctrFilterClientWithID1.Focus();
        }

        private void ctrFilterClientWithID4_OnClientSelected(int obj)
        {
            int ClientID = obj;

            _Client = clsClients.Find(ClientID);
            if(_Client == null)
            {
                MessageBox.Show("This Client is not Found ,Pleaes Select another Client");
            }
            MessageBox.Show("ClientID With : " + _Client.AccountNumber);
            _ClientID = ClientID;

        }

        private void ctrFilterClientWithID3_OnClientSelected(int obj)
        {
            int ClientID = obj;

            _Client = clsClients.Find(ClientID);
            if (_Client == null)
            {
                MessageBox.Show("This Client is not Found ,Pleaes Select another Client");
            }
            MessageBox.Show ("ClientID With : " +  _Client.AccountNumber);
            _DesposationID = ClientID;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            float Amount = (float)nudTransferAmount.Value;

            if(_SouresID == _DesposationID)
            {
                MessageBox.Show("please enter onather client");
                return;
            }
           
            if (Amount > _Client.AccountBalanc)
            {
                MessageBox.Show("Insufficient funds for transfer. Please enter a valid amount.");
            }

            if(TransferFunds(_SouresID,_DesposationID,Amount)) 
                {
                    MessageBox.Show("Transfer successful. Your new balance is: " + (_Client.AccountBalanc + Amount));
                }
               else
            {
                MessageBox.Show("Transfer failed. Please try again.");
            }
        }

        private bool TransferFunds(int SourseID, int targetAccountID, float amount)
        {
            clsClients clientSource = clsClients.Find(SourseID);
            clsClients clientDestination = clsClients.Find(targetAccountID);

            if (clientSource == null || clientDestination == null)
            {
                MessageBox.Show("Error: Source or Destination client not found.");
                return false;
            }

            if (clientSource.AccountBalanc < amount)
            {
                MessageBox.Show("Error: Insufficient funds in source account.");
                return false;
            }

            clientSource.WithDraw(amount);
            clientDestination.Deposit(amount);

            ClsTransferLog transferLog = new ClsTransferLog();

            transferLog.dateTime = DateTime.Now;
            transferLog.SourceAccount = clientSource.AccountNumber;
            transferLog.SourceBalance = clientSource.AccountBalanc;
            transferLog.Amount = amount;
            transferLog.DestinationAccount = clientDestination.AccountNumber;
            transferLog.DestinationBalance = clientDestination.AccountBalanc;
            transferLog.UserName = ClsGlobale.CurrentUser.UserName ;

            if (transferLog.Save())
            {

                MessageBox.Show("Data Save SuccessFully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Data, Not Save Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return true;
        }

        private void ctrFilterClientWithID2_OnClientSelected(int obj)
        {
            int ClientID = obj;

            _Client = clsClients.Find(ClientID);
            if (_Client == null)
            {
                MessageBox.Show("This Client is not Found ,Pleaes Select another Client");
            }
            MessageBox.Show("ClientID With : " + _Client.AccountNumber);
            _SouresID = ClientID;
        }

        private void ctrFilterClientWithID1_OnClientSelected(int obj)
        {
            int ClientID = obj;

            _Client = clsClients.Find(ClientID);
            if (_Client == null)
            {
                MessageBox.Show("This Client is not Found ,Pleaes Select another Client");
            }
            MessageBox.Show("ClientID With : " + _Client.AccountNumber);
            _DesposationID = ClientID;
        }

        private void frmTransactions_Activated(object sender, EventArgs e)
        {
            ctrFilterClientWithID1.FilterFoucstcr();
        }
    }
    
}
