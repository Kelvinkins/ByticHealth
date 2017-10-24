using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ByticHealth.App_Data;
using System.IO;

namespace ByticHealth.UserControls
{
    public partial class uscBills : UserControl
    {
        public uscBills()
        {
            InitializeComponent();
        }
        public static Patient patient;

        public uscBills(int PatNum)
        {
            InitializeComponent();
            patient = db.Patients.Find(PatNum);
            
        }

        BHModel db = new BHModel();
        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uscBills_Load(object sender, EventArgs e)
        {

            // BindingSource billBindingSource = new BindingSource();
            // billBindingSource.DataSource = db.Bills.Where(p=>p.PatNum==patient.PatNum).ToList() ;

            // BindingSource lineItemBindingSouce = new BindingSource();
            // lineItemBindingSouce.DataSource = billBindingSource;
            // lineItemBindingSouce.DataMember = "Bill";

            // dgvBills.DataSource = billBindingSource;
            //dgvLineItems.DataSource = lineItemBindingSouce;
            using (var ms = new MemoryStream(patient.PassportPhoto))
            {
                picPassport.Image = Image.FromStream(ms);

            }
            lblTotalAcumBill.Text = db.Bills.Where(p => p.PatNum == patient.PatNum).Sum(s => s.GrandTotal).ToString();

            this.billsTableAdapter.Fill(bHDataSet.Bills, patient.PatNum);
            

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void txtBillID_TextChanged(object sender, EventArgs e)
        {
            if (txtBillID.Text == string.Empty)
            {
                dgvLineItems.Refresh();
            }else
            {
                this.billDetailsTableAdapter.Fill(bHDataSet.BillDetails, Convert.ToInt32(txtBillID.Text));
            }
        }
    }
}
