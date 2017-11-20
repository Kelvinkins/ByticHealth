using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByticHealth.UserControls
{
    public partial class uscPatientMaintenance : UserControl
    {
        public uscPatientMaintenance()
        {
            InitializeComponent();
        }

        public static int PatNum;

        public uscPatientMaintenance(int PN)
        {
            InitializeComponent();
            PatNum = PN;
            lblTitle.Text = lblTitle.Text + " [" + PatNum + "]";
        }

        public static uscVital vitals;

        private void uscPatientMaintenance_Load(object sender, EventArgs e)
        {
            {
                vitals = new uscVital(PatNum);
                vitals.Dock = DockStyle.Fill;
                vitals.AutoScroll = true;
                splitContainerPatientVital.Panel2.Controls.Add(vitals);
            }
        }
    }
}
