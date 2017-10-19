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
    public partial class uscPastMedicalHistory : UserControl
    {
        public uscPastMedicalHistory()
        {
            InitializeComponent();
            cmbItem.DataSource = Enum.GetValues(typeof(Enumerations.enumSystemsReview));

            Key = Convert.ToInt32(uscPatientRegistration.PatNum);
            patient = db.Patients.Find(Key);
            //if (patient == null)
            //{
            //    this.Enabled = false;
            //}
        }

        public uscPastMedicalHistory(int PatNum)
        {
            InitializeComponent();
            cmbItem.DataSource = Enum.GetValues(typeof(Enumerations.enumSystemsReview));
            patient = db.Patients.Find(PatNum);

        }

        public int Key;
        public Patient patient;
        BHModel db = new BHModel();



        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void uscPastMedicalHistory_Load(object sender, EventArgs e)
        {
            try
            {
                dgvRecords.DataSource = db.PastMedicalHistories.Where(i => i.PatNum == patient.PatNum).ToList();
            }catch(Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (patient != null)
            {
                var medhistory = new PastMedicalHistory
                {
                    PatNum = patient.PatNum,
                    itemCode = Convert.ToInt32(cmbItem.SelectedItem),
                    DateAdded = DateTime.Now,
                    PastMedicalHistoryID = Computation.GetPastHistoryID(1),
                    Details=txtDetails.Text
                
                };
                db.PastMedicalHistories.Add(medhistory);
                if(db.SaveChanges()>0)
                {
                    dgvRecords.DataSource = db.PastMedicalHistories.Where(i => i.PatNum == patient.PatNum).ToList();
                    MessageBox.Show("Saved successfully");

                }
                else
                {
                    MessageBox.Show("Error saving record.");
                }



            }
        }
    }
}
