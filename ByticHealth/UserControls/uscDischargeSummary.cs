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

namespace ByticHealth.UserControls
{
    public partial class uscDischargeSummary : UserControl
    {
        public uscDischargeSummary()
        {
            InitializeComponent();
        }

        BHModel db = new BHModel();
        public static Discharge discharge;
        public uscDischargeSummary(int DsgNum)
        {
            InitializeComponent();
            discharge = db.Discharges.Find(DsgNum);
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int DsgNum = Convert.ToInt32(txtDischargeCode.Text);
                discharge = db.Discharges.Find(DsgNum);
                if (discharge != null)
                {

                    txtFullname.Text = discharge.Patient.FirstName + " " + discharge.Patient.LastName + " [" + discharge.Patient.PatNum + "]";
                }
                else
                {
                    MessageBox.Show("Sorry, the specified Discharge code does not exist in the database.");
                }
            }catch(Exception)
            {

            }
        }
    }
}
