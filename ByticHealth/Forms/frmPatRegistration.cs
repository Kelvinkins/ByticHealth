using ByticHealth.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByticHealth.Forms
{
    public partial class frmPatRegistration : Form
    {
        public frmPatRegistration()
        {
            InitializeComponent();
        }
        public static uscPatientRegistration uscPatientBioData;
        public static uscRelative uscRelate;
        public static uscPatientHistory uscPatHistory;
        public frmPatRegistration(int PatNum)
        {
            InitializeComponent();
            uscPatientRegistration.PatNum = PatNum;
        }
        public static Bitmap image;

        private void frmPatRegistration_Load(object sender, EventArgs e)
        {
            if (uscPatientRegistration.PatNum < 1)
            {
                uscPatientBioData = new uscPatientRegistration();
                uscPatientBioData.Dock = DockStyle.Fill;
                uscPatientBioData.AutoScroll = true;
                tabPagePatientBio.Controls.Add(uscPatientBioData);


            }
            else
            {
                uscPatientBioData = new uscPatientRegistration(uscPatientRegistration.PatNum);
                uscPatientBioData.Dock = DockStyle.Fill;
                uscPatientBioData.AutoScroll = true;
                tabPagePatientBio.Controls.Add(uscPatientBioData);
            }

        }

        private void tabControlPatientBio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab.Name == "tabPageRelative")
            {
                uscRelate = new uscRelative(uscPatientRegistration.PatNum);
                uscRelate.Dock = DockStyle.Fill;
                uscRelate.AutoScroll = true;
                tabPageRelative.Controls.Add(uscRelate);
            }
            else if(tabControl1.SelectedTab.Name== "tabPagePatientHistory")
            {
                uscPatHistory = new uscPatientHistory();
                uscPatHistory.Dock = DockStyle.Fill;
                uscPatHistory.AutoScroll = true;
                splitContainer1.Panel2.Controls.Add(uscPatHistory);
            }

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (uscPatientRegistration.PatNum == 0)
            {
                e.Cancel = true;
            }
        }
    }
}

