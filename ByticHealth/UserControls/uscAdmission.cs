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
using ByticHealth.Enumerations;

namespace ByticHealth.UserControls
{
    public partial class uscAdmission : UserControl
    {
        public uscAdmission()
        {
            InitializeComponent();
        }

        BHModel db = new BHModel();
        public static Patient patient;
        private void btnFind_Click(object sender, EventArgs e)
        {
            int PatNum = Convert.ToInt32(nupPatNum.Value);

            try
            {
                 patient = db.Patients.Find(PatNum);
          

            using (var ms = new MemoryStream(patient.PassportPhoto))
            {
                picPassport.Image = Image.FromStream(ms);

            }
            txtDateOfBirth.Text = patient.DateOfBirth.ToString();
            txtFullName.Text = patient.FirstName + " " + patient.LastName;
            txtPhoneNo.Text = patient.CellPhone;
            txtGender.Text = patient.Sex;
            txtSSN.Text = patient.SSN;
            lblPatNum.Text = patient.PatNum.ToString();
            dgvAdmissionHistory.DataSource = db.Admissions.Where(adm => adm.PatNum == patient.PatNum).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, there is no patient with the entered code,\n Please try again");
            }


        }

        private void uscAptNew_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    dgvAppointments.DataSource = db.Appointments/*.Where(apt => apt.AptDateTime == DateTime.Today)*/.ToList();
            //    cmbSpecialist.DataSource = db.Staffs.Where(s => s.StaffCategoryCode == 1).ToList();
            //    cmbSpecialist.ValueMember = "StaffID";
            //    cmbSpecialist.DisplayMember = "Fullname";
            //}catch(Exception)
            //{

            //}
        }

        private void cmbSpecialist_SelectedIndexChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    int staffId = Convert.ToInt32(cmbSpecialist.SelectedValue);
            //    var staff = db.Staffs.Find(staffId);
            //    txtSpFullName.Text = staff.Fullname;
            //    txtSpGender.Text = staff.Sex;
            //    txtSpPhoneNo.Text = staff.PhoneNo;
            //    lblSpNum.Text = staff.StaffID.ToString();
            //}catch(Exception)
            //{

            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var admission = new Admission
            {
                AdmNum=Computation.GetAdmissionID(1),
                AdmissionDate = dteAdmissionDate.Value.Date,
                AdmissionTime = dteAdmissionTime.Value.TimeOfDay,
                AdmissionDateTime = dteAdmissionTime.Value,
                PatNum = patient.PatNum,
                BedNo=(int)cmbBed.SelectedValue,     
            };
            db.Admissions.Add(admission);
            if(db.SaveChanges()>0)
            {
                dgvAdmissionHistory.DataSource = db.Admissions.Where(adm=>adm.PatNum==patient.PatNum).ToList();
                MessageBox.Show("Record saved successfully");

            }
            else
            {
                MessageBox.Show("Error saving record");
            }
        }
    }
}
