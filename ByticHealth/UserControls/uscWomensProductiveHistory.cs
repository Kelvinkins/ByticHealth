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
    public partial class uscWomensProductiveHistory : UserControl
    {
        public uscWomensProductiveHistory()
        {
            InitializeComponent();
        }
        BHModel db = new BHModel();
        public static Patient patient;
        public uscWomensProductiveHistory(int PatNum)
        {
            patient = db.Patients.Find(PatNum);
            InitializeComponent();
            if (patient.Sex.ToUpper() == Enumerations.enumSex.Female.ToString().ToUpper())
            {
               Enabled = true;
            }
            else
            {
                Enabled = false;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var womenProductiveHistory = new WomenProductiveHistory
            {
                PatNum = patient.PatNum,
                Abortions = (int)nupAbotions.Value,
                AgeOfFirstPeriod = (int)nupAgeOfirstPeriod.Value,
                AGeOfMenopause = (int)nupAgeMenopause.Value,
                Pregnancies = (int)nupPregnancies.Value,
                Miscarriages = (int)nupMiscarriages.Value,

            };
            if(rdbMenopauseYes.Checked)
            {
                womenProductiveHistory.Menopause = true;
            }
            else
            {
                womenProductiveHistory.Menopause = false;

            }
            if (rdbRegularPeriodYes.Checked)
            {
                womenProductiveHistory.RegularPeriod = true;
            }
            else
            {
                womenProductiveHistory.RegularPeriod = false;

            }
            db.WomenProductiveHistories.Add(womenProductiveHistory);
            if(db.SaveChanges()>0)
            {
                btnSave.Enabled = false;
                MessageBox.Show("Saved successfully");
            }
            else
            {
                MessageBox.Show("Error saving records");
                btnSave.Enabled = true;
            }
        }

        private void uscWomensProductiveHistory_Load(object sender, EventArgs e)
        {
            try
            {
                var womenProductiveHistory = db.WomenProductiveHistories.Where(p => p.PatNum == patient.PatNum).FirstOrDefault();
          
            if (womenProductiveHistory!=null)
            {
                btnSave.Enabled = false;
            }
            nupAbotions.Value = womenProductiveHistory.Abortions;
            nupAgeMenopause.Value = womenProductiveHistory.AGeOfMenopause;
            nupAgeOfirstPeriod.Value = womenProductiveHistory.AgeOfFirstPeriod;
            nupMiscarriages.Value = womenProductiveHistory.Miscarriages;
            nupPregnancies.Value = womenProductiveHistory.Pregnancies;
            if(womenProductiveHistory.Menopause)
            {
                rdbMenopauseYes.Checked = true;
            }
            else
            {
                rdbMenopauseNo.Checked = true;
            }

            if (womenProductiveHistory.RegularPeriod)
            {
                rdbRegularPeriodYes.Checked = true;
            }
            else
            {
                rdbPeriodNo.Checked = true;
            }
            }
            catch (Exception)
            {

            }

        }
    }
}
