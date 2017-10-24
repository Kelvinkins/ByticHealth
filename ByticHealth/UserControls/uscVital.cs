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
    public partial class uscVital : UserControl
    {
        BHModel db = new BHModel();
        public static Patient patient;

        public uscVital()
        {
            InitializeComponent();

        }

        public uscVital(int PatNum)
        {

            InitializeComponent();
            patient = db.Patients.Find(PatNum);

        }

        private void uscVital_Load(object sender, EventArgs e)
        {
            dgvVitalHistory.DataSource = db.PatientVitals.Where(p => p.PatNum == patient.PatNum).ToList();
            lblName.Text = patient.FirstName + " " + patient.LastName;
            using (var ms = new MemoryStream(patient.PassportPhoto))
            {
                picPassport.Image = Image.FromStream(ms);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var vital = new PatientVital
            {
                PatientVitalID = Computation.GetPatientVitalID(1),
                BP = (float)Convert.ToDouble(txtBP.Text),
                BT = (float)Convert.ToDouble(txtBT.Text),
                RR = (float)Convert.ToDouble(txtRR.Text),
                PR = (float)Convert.ToDouble(txtPR.Text),
                PatNum = patient.PatNum,
                DateTime = DateTime.Now


            };
            db.PatientVitals.Add(vital);
            if (db.SaveChanges() > 0)
            {
                dgvVitalHistory.DataSource = db.PatientVitals.Where(p => p.PatNum == patient.PatNum).ToList();
                MessageBox.Show("Saved successfully");
            }
            else
            {
                MessageBox.Show("Error Saving record");
            }
        }
    }
}
