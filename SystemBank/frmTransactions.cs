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
        public enum enTransaction { deposit=0,Withdraw=1}
        public enTransaction _Transaction = enTransaction.deposit;

        private clsClients _Client;
        private int _ClientID;

        private static DataTable _TotalBalance ;

        

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
            _TotalBalance = clsClients.GetTotalBalance();
           dgvTotalBalance.DataSource = _TotalBalance;
            lbRecord.Text = _TotalBalance.Rows.Count.ToString();

            if(_TotalBalance.Rows.Count > 0)
            {
                dgvTotalBalance.Columns[0].HeaderText = "Acc.Number";
                dgvTotalBalance.Columns[0].Width = 150;

                dgvTotalBalance.Columns[1].HeaderText = "Full Name";
                dgvTotalBalance.Columns[1].Width = 300;

                dgvTotalBalance.Columns[2].HeaderText = "Acc.Balance";
                dgvTotalBalance.Columns[2].Width = 150;
            }

          cbFilterBy.SelectedIndex = 0;
        
        }

        private void LoadDatadeposit(int  ClientID)
        {
          _Client =  clsClients.Find(ClientID);
            if (_Client == null)
            {
                MessageBox.Show("This Client is not found Please another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtAccountNumber.Text = _Client.AccountNumber;
            lbBalance.Text = _Client.AccountBalanc.ToString();
           

        }

        private void LoadDataWihtdraw(int ClientID)
        {
            _Client = clsClients.Find(ClientID);
            if (_Client == null)
            {
                MessageBox.Show("This Client is not found Please another one", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtAccountNumber.Text = _Client.AccountNumber;
            lbWithdraw.Text = _Client.AccountBalanc.ToString();


        }


        private void btnDeposit_Click(object sender, EventArgs e)
        {
            float Amount = 0;
            if (nudDeposit.Value < 0)
            {
                return;
            }
            else
            {
                Amount = (float)nudDeposit.Value;
                _Client.Deposit(Amount);
                LoadDatadeposit(_Client.ClientID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            LoadDatadeposit(int.Parse(txtAccountNumber.Text));
        }

        private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAccountNumber, "please insert  Account Number");
            }
            else
            {
                errorProvider1.SetError(txtAccountNumber,null);
            }

            
        }

        private void txtAccountNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                btnserch.PerformClick();
            }

            
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnWithdarw_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            LoadDataWihtdraw(int.Parse(textBox1.Text));
        }

        private void txtAccountNumber2_Validating(object sender, CancelEventArgs e)
        {
            //if (string.IsNullOrEmpty(txtAccountNumber2.Text))
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtAccountNumber2, "please insert  Account Number");
            //}
            //else
            //{
            //    errorProvider1.SetError(txtAccountNumber2, null);
            //}
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
    }
}
