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
    public partial class uscDischarge : UserControl
    {
        public uscDischarge()
        {
            InitializeComponent();
            try
            {
                cmbDischargeType.DataSource = Enum.GetValues(typeof(Enumerations.DischargeMethod));
               
            }catch(Exception)
            {

            }

        }

        BHModel db = new BHModel();
        public static Admission admission;
        private void btnFind_Click(object sender, EventArgs e)
        {
            int AdmNum = Convert.ToInt32(nupAdmNum.Value);
          
            try
            {
                cmbHospitalSite.DataSource = db.HospitalSites.ToList();
                cmbHospitalSite.DisplayMember = "Name";
                cmbHospitalSite.ValueMember = "ID";

                admission = db.Admissions.Find(AdmNum);
                if (admission.IsDischarged)
                {
                    MessageBox.Show("Sorry, this patient was discharged on: " + admission.DischargeDate);
                }
                else
                {
                    using (var ms = new MemoryStream(admission.Patient.PassportPhoto))
                    {
                        picPassport.Image = Image.FromStream(ms);

                    }
                    txtDateOfBirth.Text = admission.Patient.DateOfBirth.ToString();
                    txtFullName.Text = admission.Patient.FirstName + " " + admission.Patient.LastName;
                    txtPhoneNo.Text = admission.Patient.CellPhone;
                    txtGender.Text = admission.Patient.Sex;
                    txtSSN.Text = admission.Patient.SSN;
                    lblPatNum.Text = admission.Patient.PatNum.ToString();
                    txtBed.Text = admission.Bed.Name + " :" + admission.Bed.BedNo;
                    txtBedStatus.Text = admission.Bed.Status;
                    txtBedRemark.Text = admission.Bed.remark;
                    txtAdmissionDate.Text = admission.AdmissionDate.Date.ToString();
                    lblStat.Text = admission.Bed.Ward.WardNo + ":" + admission.Bed.BedNo;
                    txtAdmissionDateTime.Text = admission.AdmissionDateTime.Hour.ToString() + ":" + admission.AdmissionDateTime.Minute.ToString(); ;
                    txtWardRoom.Text = admission.Bed.Ward.Name + " :" + admission.Bed.Ward.WardNo + " Type[" + admission.Bed.Ward.WardType + "]";
                    dgvDischargeHistory.DataSource = db.Discharges.Where(adm => adm.PatNum == admission.Patient.PatNum).ToList();

                }
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


            //cmbWardRoom.Enabled = rdbRoom.Checked || rdbWard.Checked;
            //cmbBed.Enabled = rdbRoom.Checked || rdbWard.Checked;
            //groupBoxAdmission.Enabled = rdbRoom.Checked || rdbWard.Checked;
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
            var discharge = new Discharge
            {
                //AdmNum = Computation.GetAdmissionID(1),
                //AdmissionDate = dteAdmissionDate.Value.Date,
                //AdmissionTime = dteAdmissionTime.Value.TimeOfDay,
                //AdmissionDateTime = dteAdmissionTime.Value,
                //PatNum = patient.PatNum,
                //BedNo=(int)cmbBed.SelectedValue
                DgNum = Computation.GetDischargeID(1),
                AdmNum = admission.AdmNum,
                ID = (int)cmbHospitalSite.SelectedValue,
                PatientDied = chkPatientDied.Checked,
                PostMortemFlag = chkPostMortemFlag.Checked,
                Remark = rtbRemark.Text,
                DischargeDateTime=dteDischargeTime.Value,
                DischargeDate=dteDichargeDate.Value.Date
               
               
                                                      
            };

            if(chkPatientDied.Checked)
            {
                discharge.DeathTime = dteDeathDate.Value.Date;
                discharge.DeathDate = dteDeathTime.Value;
            }
            else
            {
                discharge.DeathTime = null;
                discharge.DeathDate =null;
            }
         
            db.Discharges.Add(discharge);
            if (db.SaveChanges() > 0)
            {
                dgvDischargeHistory.DataSource = db.Discharges.Where(adm => adm.PatNum == admission.Patient.PatNum).ToList();
                MessageBox.Show("Record saved successfully");

            }
            else
            {
                MessageBox.Show("Error saving record");
            }
        }

        private void rdbWard_CheckedChanged(object sender, EventArgs e)
        {
            //cmbWardRoom.Enabled = rdbRoom.Checked || rdbWard.Checked;
            //cmbBed.Enabled = rdbRoom.Checked || rdbWard.Checked;
            //cmbWardRoom.DataSource = null;
            //cmbWardRoom.DataSource = db.Wards.ToList();
            //cmbWardRoom.ValueMember = "WardNo";
            //cmbWardRoom.DisplayMember = "Name";
        }

        private void rdbRoom_CheckedChanged(object sender, EventArgs e)
        {
            //cmbWardRoom.Enabled = rdbRoom.Checked || rdbWard.Checked;
            //cmbBed.Enabled = rdbRoom.Checked || rdbWard.Checked;
            //cmbWardRoom.DataSource = null;
            //cmbWardRoom.DataSource = db.Wards.ToList();
            //cmbWardRoom.ValueMember = "WardNo";
            //cmbWardRoom.DisplayMember = "Name";
        }

        private void cmbWardRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (rdbWard.Checked)
            //    {
            //        int wardNo = Convert.ToInt32(cmbWardRoom.SelectedValue);
            //        cmbBed.DataSource = db.Beds.Where(b => b.WardNo == wardNo).ToList();
            //        cmbBed.ValueMember = "BedNo";
            //        cmbBed.DisplayMember = "Name";
            //    }
            //    else if (rdbRoom.Checked)
            //    {
            //        int bedNo = Convert.ToInt32(cmbWardRoom.SelectedValue);
            //        cmbBed.DataSource = db.Beds.Where(rb => rb.BedNo == bedNo).ToList();
            //        cmbBed.ValueMember = "RoomBedNo";
            //        cmbBed.DisplayMember = "Name";
            //    }
            //}catch(Exception)
            //{

            //}
        }

        private void cmbBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (rdbWard.Checked)
            //    {
            //        int bedId = Convert.ToInt32(cmbBed.SelectedValue);
            //        var bed = db.Beds.Find(bedId);
            //        lblStat.Text = bed.WardNo + ":" + bed.BedNo;
            //        txtBedStatus.Text = bed.Status;
            //        txtBedRemark.Text = bed.remark;
            //    }
            //    else if (rdbRoom.Checked)
            //    {
            //        int bedId = Convert.ToInt32(cmbBed.SelectedValue);
            //        var bed = db.Beds.Find(bedId);
            //        lblStat.Text = bed.WardNo + ":" + bed.BedNo;
            //        txtBedStatus.Text = bed.Status;
            //        txtBedRemark.Text = bed.remark;
            //    }
            //}catch(Exception)
            //{
            //}
        }

        private void splitContainer13_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void cmbHospitalSite_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(cmbHospitalSite.SelectedValue);
                rtbHospitalStateDescription.Text = db.HospitalSites.Find(id).Description;
            }
            catch(Exception)
            {
                MessageBox.Show("Sorry, Error has occured!");
            }
        }

        private void chkPatientDied_CheckedChanged(object sender, EventArgs e)
        {
            grbDeath.Enabled = chkPatientDied.Checked;
        }
    }
}
