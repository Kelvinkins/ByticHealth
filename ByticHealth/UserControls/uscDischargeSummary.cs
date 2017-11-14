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
    public partial class uscDischargeSummary : UserControl
    {
        public uscDischargeSummary()
        {
            InitializeComponent();
        }

        BHModel db = new BHModel();
        public static int AdmNum;
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
                    txtPhone.Text = discharge.Patient.CellPhone + "," + discharge.Patient.HomePhoneNo;
                    txtAdmissionDate.Text = discharge.Admission.AdmissionDate.ToShortDateString();
                    txtDischargeDate.Text = discharge.DischargeDate.ToShortDateString();
                    AdmNum = Convert.ToInt32(discharge.AdmNum);
                    using (var ms = new MemoryStream(discharge.Patient.PassportPhoto))
                    {
                        picPassport.Image = Image.FromStream(ms);

                    }
                    if (discharge.DischargeMethod==(int)Enumerations.DischargeMethod.CD)
                    {
                        txtDischargeMethod.Text = Enumerations.DischargeMethod.CD.ToString();

                    }
                    else if(discharge.DischargeMethod==(int)Enumerations.DischargeMethod.SD)
                    {
                        txtDischargeMethod.Text = Enumerations.DischargeMethod.SD.ToString();
                    }
                    txtGender.Text = discharge.Patient.Sex;
                    txtDead.Text = discharge.PatientDied.ToString();
                    if(discharge.Admission.AdmissionMethod==(int)Enumerations.AdmissionMethod.Elective)
                    {
                        txtAdmissionType.Text = Enumerations.AdmissionMethod.Elective.ToString();


                    }
                    else if(discharge.Admission.AdmissionMethod==(int) Enumerations.AdmissionMethod.Emmergency)
                    {
                        txtAdmissionType.Text = Enumerations.AdmissionMethod.Emmergency.ToString();
                    }
                    else if(discharge.Admission.AdmissionMethod==(int)Enumerations.AdmissionMethod.Transfer)
                    {
                        txtAdmissionType.Text = Enumerations.AdmissionMethod.Transfer.ToString();
                    }
                    else
                    {
                        txtAdmissionType.Text = Enumerations.AdmissionMethod.NA.ToString();
                    }

                    txtPmFlag.Text = discharge.PostMortemFlag.ToString();
                    txtSSN.Text = discharge.Patient.SSN;
                    dgvDiagnosis.DataSource = db.PatientDiagnoses.Where(p => p.Admission.AdmNum == discharge.AdmNum).ToList();
                    dgvOperationAndProcedure.DataSource = db.OperationAndProcedures.Where(p => p.Admission.AdmNum == discharge.AdmNum).ToList();
                    dgvDiet.DataSource = db.Diets.Where(p => p.Admission.AdmNum == discharge.AdmNum).ToList();
                    dgvImmunization.DataSource = db.Immunisations.Where(p => p.Admission.AdmNum == discharge.AdmNum).ToList();
                    dgvMedicationDischarge.DataSource = db.MedicationOnDischarges.Where(p => p.Discharge.DgNum == discharge.DgNum).ToList();
                    dgvMedicationStoppedOrWithheld.DataSource = db.MedicationOnDischarges.Where(p => p.Discharge.DgNum == discharge.DgNum).ToList();
                    dgvActions.DataSource = db.Actions.Where(p => p.Discharge.DgNum == discharge.DgNum).ToList();

                }
                else
                {
                    MessageBox.Show("Sorry, the specified Discharge code does not exist in the database.");
                }
            }catch(Exception)
            {

            }
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dischargeSum = new DischargeSummary
            {
                AdmNum = Convert.ToInt32(discharge.AdmNum),
                DgNum = discharge.DgNum,
                PatNum = discharge.PatNum,
                SumID = Computation.GetDischargeSummaryID(1),



            };

            db.DischargeSummaries.Add(dischargeSum);
            if(db.SaveChanges()>0)
            {
                MessageBox.Show("Saved successfully");
            }
            else
            {
                MessageBox.Show("Error saving record");
            }

        }
    }
}
