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
    public partial class uscSubstanceUse : UserControl
    {
        public uscSubstanceUse()
        {
            InitializeComponent();
        }

        BHModel db = new BHModel();
        public static Patient patient;
        public uscSubstanceUse(int PatNum)
        {
            InitializeComponent();
            patient = db.Patients.Find(PatNum);

        }

        private void uscSubstanceUse_Load(object sender, EventArgs e)
        {
            try
            {
                cmbDrugCategory.DataSource = db.DrugCategories.ToList();
                cmbDrugCategory.ValueMember = "DrugCategoryID";
                cmbDrugCategory.DisplayMember = "Name";
                dgvRecords.DataSource = db.SubstanceUses.Where(p => p.PatNum == patient.PatNum).ToList();
            }
            catch (Exception)
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var subUse = new SubstanceUse
            {
                SubstanceUseID = Computation.GetGetDrugCategoryID(1),
                Age = (int)nupAgeOfFirstUse.Value,
                Years = (int)nupYears.Value,
                CurrentlyUsed = chkYES.Checked,
                DrugCategoryID = (int)cmbDrugCategory.SelectedValue,
                HowOften = txtHowOften.Text,
                PatNum = patient.PatNum
            };

            db.SubstanceUses.Add(subUse);
            if(db.SaveChanges()>0)
            {
                dgvRecords.DataSource = db.SubstanceUses.Where(p => p.PatNum == patient.PatNum).ToList();
                MessageBox.Show("Saved Successfully");
            }
            else
            {
                MessageBox.Show("Error saving record");

            }
        }
    }
}
