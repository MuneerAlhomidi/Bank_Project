using Bank_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBank.Properties;

namespace SystemBank
{
    public partial class ctrPersonInfo : UserControl
    {
        private int _PersonID = -1;
        private clsPerson _Person;
        public ctrPersonInfo()
        {
            InitializeComponent();
        }

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectPersonInfo
        { get { return _Person; } }

        private void FillPersonInfo()
        {
            llbEditPersonInfo.Enabled = true;
            _PersonID = _Person.PersonID;
            lbpersonID.Text = _Person.PersonID.ToString();
            lbName.Text = _Person.FullName;
            lbDateOfBirth.Text =_Person.DateOfBirth.ToShortDateString();
            lbGender.Text = _Person.Gendor == 0 ? "Male" : "Female";
            lbAddress.Text = _Person.Address;
            lbCountry.Text = _Person.countriesInfo.CountryName;
            lbEmail.Text = _Person.Email;
            lbPhone.Text = _Person.Phone;
            lbNationalNo.Text = _Person.NationalNo;
            ChengeImage();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.FindPerson(PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No, Person Info With ID = " + PersonID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.FindPerson(NationalNo);
            if (_Person == null)
            {
                MessageBox.Show("No,Person Info With National No = " + NationalNo, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FillPersonInfo();
        }

        public void RestDefultValue()
        {

            _PersonID = -1;
            lbpersonID.Text = "[????]";
            lbNationalNo.Text = "[????]";
            lbName.Text = "[????]";
            pbGender.Image = Resources.Man_32;
            lbGender.Text = "[????]";
            lbEmail.Text = "[????]";
            lbPhone.Text = "[????]";
            lbDateOfBirth.Text = "[????]";
            lbCountry.Text = "[????]";
            lbAddress.Text = "[????]";
            pbImagePath.Image = Resources.Male_512;

        }

        public void ChengeImage()
        {
            if (_Person.Gendor == 0)
                pbImagePath.Image = Resources.Male_512;
            else
                pbImagePath.Image = Resources.Female_512;
            string ImagePath = _Person.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    pbImagePath.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Cloud not Found this Image " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        private void llbEditPersonInfo_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson frm = new frmAddUpdatePerson(_PersonID);
            frm.ShowDialog();

        }
    }
}
