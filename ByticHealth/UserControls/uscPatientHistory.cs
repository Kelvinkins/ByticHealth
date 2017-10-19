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
    public partial class uscPatientHistory : UserControl
    {
        public static uscPastMedicalHistory uscMedHistory;
        public static uscCurrentMedication uscCurtMedication;
        public static uscFamilyHistory uscFamHistory;
        public static uscPatientComplain uscPatientReview;
        public static uscWomensProductiveHistory uscWomenProHistory;
        public static uscSubstanceUse uscSubUse;
        public Patient patient;
        BHModel db = new BHModel();

        public uscPatientHistory()
        {
            InitializeComponent();
            //patient = db.Patients.Find(uscPatientRegistration.PatNum);
            

        }

        private void uscPatientHistory_Load(object sender, EventArgs e)
        {
            uscMedHistory = new uscPastMedicalHistory(uscPatientRegistration.PatNum);
            uscMedHistory.Dock = DockStyle.Fill;
            tabPagePatientMedicalHistory.Controls.Add(uscMedHistory);


            uscCurtMedication = new uscCurrentMedication(uscPatientRegistration.PatNum);
            uscCurtMedication.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(uscCurtMedication);

            uscFamHistory = new uscFamilyHistory(uscPatientRegistration.PatNum);
            uscFamHistory.Dock = DockStyle.Fill;
            tabPageFamilyHistory.Controls.Add(uscFamHistory);

            uscPatientReview = new uscPatientComplain(uscPatientRegistration.PatNum);
            uscPatientReview.Dock = DockStyle.Fill;
            tabPagePatientSystemReview.Controls.Add(uscPatientReview);

            uscWomenProHistory = new uscWomensProductiveHistory(uscPatientRegistration.PatNum);
            uscWomenProHistory.Dock = DockStyle.Fill;
            tabPageWomenProductiveHistory.Controls.Add(uscWomenProHistory);


            uscSubUse = new uscSubstanceUse(uscPatientRegistration.PatNum);
            uscSubUse.Dock = DockStyle.Fill;
            tabPageSubstanceUse.Controls.Add(uscSubUse);

        }
    }
}
