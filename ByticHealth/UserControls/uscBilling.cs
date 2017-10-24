using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByticHealth.UserControls
{
    public partial class uscBilling : UserControl
    {
        public static uscNewBill uscBillForm;
        public static uscBills uscPatientBills;
        public uscBilling()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {         
          
            uscBillForm = new uscNewBill(uscPatientRegistration.PatNum);
            splitContainerBill.Panel2.Controls.Clear();
            uscBillForm.Dock = DockStyle.Fill;
            splitContainerBill.Panel2.Controls.Add(uscBillForm);
        }

        private void btnBillHistory_Click(object sender, EventArgs e)
        {
            uscPatientBills = new uscBills(uscPatientRegistration.PatNum);
            splitContainerBill.Panel2.Controls.Clear();
            uscPatientBills.Dock = DockStyle.Fill;
            splitContainerBill.Panel2.Controls.Add(uscPatientBills);
        }

        private void uscBilling_Load(object sender, EventArgs e)
        {

            btnBillHistory_Click(sender, e);

        }
    }
}
