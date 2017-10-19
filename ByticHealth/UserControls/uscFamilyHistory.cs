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
    public partial class uscFamilyHistory : UserControl
    {
        public uscFamilyHistory()
        {
            InitializeComponent();
        }
        BHModel db = new BHModel();
        public static Patient patient;
        public uscFamilyHistory(int PatNum)
        {
            InitializeComponent();
            patient = db.Patients.Find(PatNum);
            cmbRelationshipType.DataSource = db.RelationTypeLists.ToList();
            cmbRelationshipType.ValueMember = "RelationTypeListID";
            cmbRelationshipType.DisplayMember = "Name";

        }

        private void uscFamilyHistory_Load(object sender, EventArgs e)
        {
            dgvPsychiaRecords.DataSource = db.FamilyPsychiaPromblems.Where(p => p.PatNum == patient.PatNum).ToList();
            dgvRecords.DataSource = db.FamilyHistories.Where(p => p.PatNum == patient.PatNum).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var familyHistory = new FamilyHistory
            {
                FamilyHistoryID = Computation.GetFamilyHistoryID(1),
                Age = (int)nupAge.Value,
                AgeOfDeath = (int)nupDeathAge.Value,
                Details = txtDetails.Text,
                Fullname = txtFullname.Text,
                PatNum = patient.PatNum,
                RelationshipTypeListID = (int)cmbRelationshipType.SelectedValue,
                Deceased=chkDeseased.Checked
            };

            if(chkDeseased.Checked)
            {
                if (txtCauseOfDeath.Text == string.Empty)
                {
                    familyHistory.CauseOfDeath = "OMT"; //OMT means omitted
                }
                else
                {
                    familyHistory.CauseOfDeath = txtCauseOfDeath.Text;
                }

            }
            else
            {
                familyHistory.CauseOfDeath = "NS";

            }

            db.FamilyHistories.Add(familyHistory);
            if(db.SaveChanges()>0)
            {
                dgvRecords.DataSource = db.FamilyHistories.Where(p => p.PatNum == patient.PatNum).ToList();
                MessageBox.Show("Saved Successfully");

            }
            else
            {
                MessageBox.Show("Error saving record");

            }

        }

        private void btnSavePsychia_Click(object sender, EventArgs e)
        {
            var famPsychia = new FamilyPsychiaPromblem
            {
                FamilyPsychiaPromblemID = Computation.GetFamilyPsychiaPromblemID(1),
                Fullname = txtRelative.Text,
                PatNum = patient.PatNum
            };
            if(rdbMaternal.Checked)
            {
                famPsychia.Side = rdbMaternal.Text;
                
            }
            else if(rdbParternal.Checked)
            {
                famPsychia.Side = rdbParternal.Text;
            }
            else
            {
                famPsychia.Side = "NS";
            }

            db.FamilyPsychiaPromblems.Add(famPsychia);
           if(db.SaveChanges()>0)
            {
                dgvPsychiaRecords.DataSource = db.FamilyPsychiaPromblems.Where(p => p.PatNum == patient.PatNum).ToList();
                MessageBox.Show("Save Successfully");
            }
           else
            {
                MessageBox.Show("Error saving record");

            }
        }

        private void chkDeseased_CheckedChanged(object sender, EventArgs e)
        {
            grbCauseOfDeath.Enabled = chkDeseased.Checked;
        }
    }
}
