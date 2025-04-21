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
    public partial class frmDetilsPerson : Form
    {
        //public enum enMode { AddNew =0,Update=1};
        //public enMode Mode = enMode.AddNew;

        private int _PersonID = -1;
        clsPerson _Person;

        public frmDetilsPerson(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        public frmDetilsPerson()
        {
            InitializeComponent();
           
        }

        private void frmDetilsPerson_Load(object sender, EventArgs e)
        {
            ctrPersonInfo1.LoadPersonInfo(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrPersonInfo1_Load(object sender, EventArgs e)
        {

        }
    }
}
