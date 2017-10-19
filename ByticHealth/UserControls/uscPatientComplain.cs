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
    public partial class uscPatientComplain : UserControl
    {
        BHModel db = new BHModel();
        public static Patient patient;
        public uscPatientComplain()
        {
            InitializeComponent();
           cmbItem.DataSource = Enum.GetValues(typeof(Enumerations.enumSystemsReview));

        }

        public uscPatientComplain(int PatNum)
        {
            InitializeComponent();
            patient = db.Patients.Find(PatNum);
            cmbItem.DataSource = db.SystemReviewLists.ToList();
            cmbItem.ValueMember = "SystemReviewListID";
            cmbItem.DisplayMember = "Name";

                /*Enum.GetValues(typeof(Enumerations.enumSystemsReview));*/

        }

        private void uscPatientComplain_Load(object sender, EventArgs e)
        {
            dgvRecords.DataSource = db.PatientSystemReviews.Where(p => p.PatNum == patient.PatNum).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var patientSystemReview = new PatientSystemReview
            {
                PatientSystemReviewID = Computation.GetPatientSystemReviewID(1),
                PatNum = patient.PatNum,
                SystemReviewListID = (int)cmbItem.SelectedValue,
                Details = rtbDetails.Text
            };
            db.PatientSystemReviews.Add(patientSystemReview);
            if(db.SaveChanges()>0)
            {
                dgvRecords.DataSource = db.PatientSystemReviews.Where(p => p.PatNum == patient.PatNum).ToList();
                MessageBox.Show("Record Saved Successfully");
            }
            else
            {
                MessageBox.Show("Error saving records");
            }
        }
    }
}
