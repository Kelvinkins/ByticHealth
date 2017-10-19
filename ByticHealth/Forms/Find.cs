using ByticHealth.App_Data;
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
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }
        BHModel db = new BHModel();

        private void Find_Load(object sender, EventArgs e)
        {
           
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {

                int PatNum = Convert.ToInt32(txtPatNum.Text);
                var patient = db.Patients.Find(PatNum);
                if (patient == null)
                {
                    MessageBox.Show("Sorry, there is not patient with the specified patient code.");
                }
                else
                {

                    frmPatRegistration patReg = new frmPatRegistration(patient.PatNum);
                    patReg.Text = "PATIENT RECORD [" + patient.PatNum + ":" + patient.FirstName + " " + patient.LastName + "]";
                    patReg.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
