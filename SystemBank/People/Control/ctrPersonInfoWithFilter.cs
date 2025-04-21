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
    public partial class ctrPersonInfoWithFilter : UserControl
    {

        public event Action<int> OnPersonSelected;
        // Create a protected method to raise the event with a parameter
        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;
            if (handler != null)
            {
                handler(PersonID); // Raise the event with the parameter
            }
        }

        private int _PersonID = -1;
        public int PersonID
        {
            get { return ctrPersonInfo1.PersonID; }
            set {  _PersonID = value; }
        }
        public clsPerson SelectPersonInfo
        {
            get { return ctrPersonInfo1.SelectPersonInfo; }
        }

        
        public ctrPersonInfoWithFilter()
        {
            InitializeComponent();
        }

        private bool _ShowAddPerson = true;
        public bool Showfilter
        {
            get {
                return _ShowAddPerson; }
            set {
                _ShowAddPerson = value;
                btnAddeNew.Visible = true;
            }
        }

        private bool _FilterEnable = true;
        public bool FilterEnable
        {
            get
            {
                return _FilterEnable;
            }
            set
            {
                _FilterEnable = value;
                gbFilter.Enabled = _FilterEnable;
            }
        }

        private bool _AddNew = true;
        public bool AddNew
        {
            get { return _AddNew; }
            set
            {
                _AddNew = value;
                btnAddeNew.Visible = _AddNew;
            }
        }

        public void LoadPersonInfo(int PersonID)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilter.Text = PersonID.ToString();
            FindNew();

        }

        public void FindNew()
        {
            switch(cbFilterBy.Text)
            {
                case "PersonID":
                     ctrPersonInfo1.LoadPersonInfo(int.Parse(txtFilter.Text));
                    break;
                case "NationalNo":
                    ctrPersonInfo1.LoadPersonInfo(txtFilter.Text);
                    break;
                default:
                    break;
            }

            if (OnPersonSelected != null && FilterEnable)
                // Raise the event with a parameter
                OnPersonSelected(ctrPersonInfo1.PersonID);
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            txtFilter.Focus();
        }

        private void ctrPersonInfo1_Load(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 1;
            txtFilter.Focus();
        }

        private void txtFilter_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtFilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFilter, "Same Fild Requerd!");
            }
            else
            {
                errorProvider1.SetError(txtFilter,null);
            }
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
       
        {
            if (e.KeyChar == (char)13)
            {

                btnSerches.PerformClick();
            }

            if (cbFilterBy.Text == "PersonID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnAddeNew_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson();
            frm.ShowDialog();
            
        }

        private void btnSerches_Click(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FindNew();
        }

        public void FilterFoucs()
        {
            txtFilter.Focus();
        }

        public void DataBackEvent(object sender, int PersonID)
        {
            cbFilterBy.SelectedIndex = 0;
            txtFilter.Text = PersonID.ToString();
            ctrPersonInfo1.LoadPersonInfo(PersonID);
        }

       
    }
}
