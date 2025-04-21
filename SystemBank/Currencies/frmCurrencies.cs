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
    public partial class frmCurrencies : Form
    {
        private int? _CurrenceID;
        private clsCurrence _Currence;

        private DataTable _DataTable;

        public frmCurrencies()
        {
            InitializeComponent();
        }

        private void frmCurrencies_Load(object sender, EventArgs e)
        {
            
            _DataTable = clsCurrence.AllCurrence();
            dgvCurrencies.DataSource = _DataTable;

           lbRecord.Text= dgvCurrencies.Rows.Count.ToString();
            if( dgvCurrencies.Rows.Count > 0 )
            {
                dgvCurrencies.Columns[0].HeaderText = "Currence ID";
                dgvCurrencies.Columns[0].Width = 100;

                dgvCurrencies.Columns[1].HeaderText = "Country ID";
                dgvCurrencies.Columns[1].Width = 220;

                dgvCurrencies.Columns[2].HeaderText = "Code ";
                dgvCurrencies.Columns[2].Width = 80;

                dgvCurrencies.Columns[3].HeaderText = "Name ";
                dgvCurrencies.Columns[3].Width = 190;

                dgvCurrencies.Columns[4].HeaderText = "Rate ";
                dgvCurrencies.Columns[4].Width = 100;
            }
        }

        private void eidtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int CurrenceID = (int)dgvCurrencies.CurrentRow.Cells[0].Value;
            frmUpdateCurrence frm = new frmUpdateCurrence(CurrenceID);
            frm.ShowDialog();
            frmCurrencies_Load(null,null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
