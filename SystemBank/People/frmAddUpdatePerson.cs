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
using SystemBank.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.ConstrainedExecution;

namespace SystemBank
{
    public partial class frmAddUpdatePerson : Form
    {
       

        public delegate void DataBackHandel(object sender, int PersonID);
        public event DataBackHandel DataBack;

        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;

        private enum enGengor { Male = 0, Female = 1 }

        private int _PersonID = -1;
        clsPerson _Person;

     

        public frmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _Mode = enMode.Update;
        }

        public frmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        private void _FillCountryComboBox()
        {
            DataTable dt = clsCountry.GetAllCountries();
            foreach (DataRow Row in dt.Rows)
            {
                cbCountry.Items.Add(Row["CountryName"]);
            }
        }

        private void _RestDefultValues()
        {
            _FillCountryComboBox();
            if (_Mode == enMode.AddNew)
            {
                lbTitle.Text = "Add Person";
                this.Text = lbTitle.Text;
                _Person = new clsPerson();

            }
            else
            {
                lbTitle.Text = "Update Person";
                this.Text = lbTitle.Text;
            }

            if (rbMale.Checked)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            llRemoveImage.Visible = (pbPersonImage.Image != null);

            cbCountry.SelectedIndex = cbCountry.FindString("Jordan");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";

        }

        public void _LoadPerson()
        {
            _Person = clsPerson.FindPerson(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No,person With ID = " + _PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName.ToString();
            txtSecondName.Text = _Person.SecondName.ToString();
            txtThirdName.Text = _Person.ThirdName.ToString();
            txtLastName.Text = _Person.LastName.ToString();
            txtNationalNo.Text = _Person.NationalNo.ToString();
            txtPhone.Text = _Person.Phone.ToString();
            txtEmail.Text = _Person.Email.ToString();
            txtAddress.Text = _Person.Address.ToString();
            cbCountry.SelectedIndex = cbCountry.FindString(_Person.countriesInfo.CountryName);

            if (_Person.Gendor == 0)
                rbMale.Enabled = true;
            else
                rbFemale.Enabled = true;

            if (_Person.ImagePath != "")
                pbPersonImage.ImageLocation = _Person.ImagePath.ToString();

            llRemoveImage.Visible = (_Person.ImagePath != "");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some Faild is valid! put  the mouse over the red icon(s)" +
                                  " to see the erro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            int NationalityCountryID = clsCountry.Find(cbCountry.Text).CountryID;
            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            if (txtThirdName.Text != "")
                _Person.ThirdName = txtThirdName.Text.Trim();
            else
                _Person.ThirdName = "";
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Address = txtAddress.Text.Trim();
            _Person.Phone = txtPhone.Text.Trim();
            if (_Person.Email != "")
                _Person.Email = txtEmail.Text.Trim();
            else
                _Person.Email = "";
            _Person.NationalityCountryID = NationalityCountryID;

            if (rbMale.Checked)
                _Person.Gendor = (byte)enGengor.Male;
            else
                _Person.Gendor = (byte)enGengor.Female;

            if (pbPersonImage.ImageLocation != null)
                _Person.ImagePath = pbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                lblPersonID.Text = _Person.PersonID.ToString();
                _Mode = enMode.Update;
                lbTitle.Text = "Update Person";

                MessageBox.Show("Data Save SuccessFully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DataBack?.Invoke(this, _PersonID);
            }
            else
                MessageBox.Show("Data, Not Save Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void frmAddUpdatePerson_Load_1(object sender, EventArgs e)
        {
            _RestDefultValues();
            if (_Mode == enMode.Update)
            {
                _LoadPerson();
            }
        }

        private void llSetImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string ImagePath = openFileDialog1.FileName;
                pbPersonImage.Load(ImagePath);
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (_Person.ImagePath == null)
            {
                if (rbMale.Checked)
                    pbPersonImage.Image = Resources.Male_512;
                else
                    pbPersonImage.Image = Resources.Female_512;
                llRemoveImage.Visible = false;
            }
        }

        private void txtNationalNo_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This Faild Requird!");
            }
            else
            {
                errorProvider1.SetError(null, null);
            }

            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsExistPerson(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This Person Already have NationalNo ");
            }
            else
            {
                errorProvider1.SetError(null, null);
            }
        }

        private void Validite_ComboxText(object sender, CancelEventArgs e)
        {
            TextBox temp = ((TextBox)sender);
            if (string.IsNullOrEmpty(temp.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(temp, "This Faild Requird!");
            }
            else
            {
                errorProvider1.SetError(temp, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddUpdatePerson_Validating(object sender, CancelEventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMale.Checked)
            {
                pbPersonImage.Image = Resources.Male_512;
            }
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
                pbPersonImage.Image = Resources.Female_512;
        }
    }
}
