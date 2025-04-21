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
    public partial class frmUpdateCurrence : Form
    {
        private int _CurrenceID =-1;
        private clsCurrence _Currencre;

        public frmUpdateCurrence(int currenceID)
        {
            InitializeComponent();
            _CurrenceID = currenceID;
        }

        private void frmUpdateCurrence_Load(object sender, EventArgs e)
        {
            lbCurrenceID.Text = _CurrenceID.ToString();
            _Currencre = clsCurrence.Find(_CurrenceID);

            if (_Currencre != null)
            {
                txtCountryName.Text = _Currencre.Name;
                txtRate.Text = _Currencre.Rate.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Currencre.Name = txtCountryName.Text.Trim();
            _Currencre.Rate = Convert.ToSingle(txtRate.Text.Trim());


            if (_Currencre.save())
            {
                MessageBox.Show("Data Save Sucsessfully.","Save",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data is Not Save Sucsessfully","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void txtCountryName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCountryName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtCountryName, "is Faild is Not Empty");
            }
            else
            {
                errorProvider1.SetError(txtCountryName, null);
            };
        }

        private void txtRate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtRate.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtRate, "is Faild is Not Empty");
            }
            else
            {
                errorProvider1.SetError(txtRate, null);
            };
        }

        private void btnCloes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
