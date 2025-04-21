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
    public partial class frmClientInfo : Form
    {
        private int _ClientID = -1;
        private clsClients _Clients;
        public frmClientInfo(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID;
        }

        private void frmClientInfo_Load(object sender, EventArgs e)
        {
            ctrPersonInfo1.LoadPersonInfo(_ClientID);
            LoadInfo(_ClientID);
        }

        private void LoadInfo(int  ClientID)
        {
            _Clients = clsClients.Find(_ClientID);
            if( _Clients == null )
            {
                MessageBox.Show("Client Id is not Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            lbAccountBalanc.Text = _Clients.AccountBalanc.ToString();
            lbAccountNumber.Text = _Clients.AccountNumber.ToString();
            lbPinCode.Text = _Clients.PinCode.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
