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
    public partial class uscCurrentMedication : UserControl
    {
        BHModel db = new BHModel();
        public static Patient patient;
        public uscCurrentMedication()
        {
            InitializeComponent();
            
        }

        public uscCurrentMedication(int PatNum)
        {
            InitializeComponent();
            patient = db.Patients.Find(PatNum);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uscCurrentMedication_Load(object sender, EventArgs e)
        {
            dgvRecords.DataSource = db.CurrentMedications.Where(p => p.PatNum == patient.PatNum).ToList();
            dgvDrugAllerg.DataSource = db.DrugAllergies.Where(p => p.PatNum == patient.PatNum).ToList();

            cmbDrugs.DataSource = db.Drugs.ToList();
            cmbDrugs.ValueMember = "DrugID";
            cmbDrugs.DisplayMember = "DrugName";

            cmbDrugAllerg.DataSource = db.Drugs.ToList();
            cmbDrugAllerg.ValueMember = "DrugID";
            cmbDrugAllerg.DisplayMember = "DrugName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var curmed = new CurrentMedication
            {
                CurrentMedicationID = Computation.GetCurMedID(1),
                DrugID = Convert.ToInt32(cmbDrugs.SelectedValue),
                HowLong = txtHowLong.Text,
                NumberOfPill = (int)nupNumberOfPills.Value,
                PatNum=patient.PatNum

            };
            db.CurrentMedications.Add(curmed);
            if(db.SaveChanges()>0)
            {
                dgvRecords.DataSource = db.CurrentMedications.Where(p => p.PatNum == patient.PatNum).ToList();
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("Error Saving Record");

            }
        }

        private void btnDrugAllerg_Click(object sender, EventArgs e)
        {
            var drugAllerg = new DrugAllergy
            {
                DrugsAllergyID = Computation.GetDrugAllerg(1),
                DrugID = (int)cmbDrugAllerg.SelectedValue,
                PatNum = patient.PatNum

            };
            db.DrugAllergies.Add(drugAllerg);
            if(db.SaveChanges()>0)
            {
                dgvDrugAllerg.DataSource = db.DrugAllergies.Where(p => p.PatNum == patient.PatNum).ToList();
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("Error Saving Record");
            }

        }
    }
}
