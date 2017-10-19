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
    public partial class uscRelative : UserControl
    {
        public uscRelative()
        {
            InitializeComponent();
        }
        BHModel db = new BHModel();
        public static Patient patient;
        public uscRelative(int PatNum)
        {
            InitializeComponent();
            patient = db.Patients.Find(PatNum);
            cmbRelationshipToPatient.DataSource = db.RelationTypeLists.ToList();
            cmbRelationshipToPatient.ValueMember = "RelationTypeListID";
            cmbRelationshipToPatient.DisplayMember = "Name";
        }

        private void uscRelative_Load(object sender, EventArgs e)
        {
            dgvRecords.DataSource = db.Relatives.Where(p => p.PatNum == patient.PatNum).ToList();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var relative = new Relative
            {
                RelativeID = Computation.GetRelativeID(1),
                Fullname = txtNameRelativeNotLeavingClose.Text,
                HomePhoneNo = txtRelativeHomePhone.Text,
                PatNum = patient.PatNum,
                WorkPhoneNo = txtRelativeWorkPhone.Text,
                RelationshipTypeListID = (int)cmbRelationshipToPatient.SelectedValue,
                CallForEmergency=chkCallForEmergency.Checked
               
            };

            db.Relatives.Add(relative);
            if(db.SaveChanges()>0)
            {
                dgvRecords.DataSource = db.Relatives.Where(p => p.PatNum == patient.PatNum).ToList();
                MessageBox.Show("Saved successfully");
            }
            else
            {
                MessageBox.Show("Error saving record");
            }
        }
    }
}
