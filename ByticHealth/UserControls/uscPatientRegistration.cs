using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ByticHealth.Common;
using ByticHealth.App_Data;
//using Syncfusion.Windows.Forms.Barcode;

namespace ByticHealth.UserControls
{
    public partial class uscPatientRegistration : UserControl
    {
        public uscPatientRegistration()
        {
            
            InitializeComponent();
            lblTodayDate.Text = DateTime.Now.ToShortDateString();
            cmbMaritalStatus.DataSource = Enum.GetValues(typeof(Enumerations.enumMaritalStatus));
            cmbRelationshipToPatient.DataSource = Enum.GetValues(typeof(Enumerations.enumRelationType));
            cmbPatRelationshipToSubscriber.DataSource = Enum.GetValues(typeof(Enumerations.enumRelationType));
            cmbSex.DataSource = Enum.GetValues(typeof(Enumerations.enumSex));
            cmbPatRelationshipToSubscriber.DataSource = Enum.GetValues(typeof(Enumerations.enumRelationType));

        }


        public uscPatientRegistration(int PatNum)
        {

            InitializeComponent();
            lblTodayDate.Text = DateTime.Now.ToShortDateString();

        }

        private void autoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void autoLabel4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExt3_TextChanged(object sender, EventArgs e)
        {

        }

        private void autoLabel7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox22_Enter(object sender, EventArgs e)
        {

        }

        private void autoLabel38_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExt21_TextChanged(object sender, EventArgs e)
        {

        }

        private void uscPatientRegistration_Load(object sender, EventArgs e)
        {

            //BarcodeSymbolType.Code11:
            //bcPatientNo.Symbology = BarcodeSymbolType.Code11;
            // Code11Setting code11 = new Code11Setting();
            //code11.BarHeight = 130;
            //bcPatientNo.SymbologySettings = code11;
            //string code = "01234567";
            //bcPatientNo.DisplayText = true;
            //bcPatientNo.Text = code;
        }

        private void textBoxExt29_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdv5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdv7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxExt21_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxExt25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxExt23_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbInsuranceBillPersonPatientHereYES_CheckChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdv6_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Repositories repo = new Repositories();
            CommonCode common = new CommonCode();
            var pat = new Patient
            {
                PatNum = 001,
                CellPhone = txtCellPhone.Text,
                DateOfBirth = dteDateOfBirth.Value.Date,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                MiddleName = txtMiddleName.Text,
                FormerName = txtFormerName.Text,
                LegalName = txtLegalName.Text,
                HomePhoneNo = txtHomePhone.Text,
                Occupation = txtOccupation.Text,
                SSN = txtSSN.Text,
                Referral = txtReferedDoctorName.Text,
                MaritalStatus = Convert.ToInt32(cmbMaritalStatus.SelectedValue),
                PassportPhoto = CommonCode.converterTo(picPassport.Image),
                Barcode = CommonCode.converterTo(picBarcode.Image),
                Signature = CommonCode.converterTo(picSignature.Image)


            };

            if (rdbLegalYes.Checked)
            {
                pat.IsLegalName = true;
            }
            else if (rdbLegalNo.Checked)
            {
                pat.IsLegalName = false;
            }

            var employer = new Employer
            {
                EmployerID = 001,
                Fullname = txtEmployer.Text,
                PhoneNo = txtEmployerPhoneNo.Text
            };

            var insurance = new PrimaryInsurance
            {
                Copayment = txtInsuranceCopayment.Text,
                DateOfBirth = dteInsuranceSubscriberDateOfBirth.Value.Date,
                GroupNo = txtInsuranceGroupNo.Text,
                GroupPolicy = txtInsuranceGroupNo.Text,
                InsuranceName = cmbPrimaryInsurance.SelectedText,
                SubscriberName = txtSubscriberName.Text,
                SubscriberSSN = txtSubscriberSSN.Text,
                PrimaryInsuranceID = 001
            };

            var secInsurance = new SecondaryInsurance
            {
                DateOfBirth = dteSecInsuranceDateOfBirth.Value.Date,
                GroupNo = txtSecInsuranceGroupNo.Text,
                InsuranceName = txtSecInsurance.SelectedText,
                SubscriberName = txtSecInsuranceSubscriber.Text,
                PolicyNo = txtSecInsurancePolicyNo.Text,
                SecondaryInsuranceID = 001
            };
            var relative = new Relative
            {
                Fullname = txtNameRelativeNotLeavingClose.Text,
                HomePhoneNo = txtRelativeHomePhone.Text,
                RelationshipToPatient = cmbRelationshipToPatient.SelectedValue.ToString(),
                WorkPhoneNo = txtRelativeWorkPhone.Text,
                RelativeID = 001
            };
            var billee = new Billee
            {
                Address = txtInsuranceBillPersonAddress.Text,
                DateOfBirth = dteInsuranceBillPersonDateOfBirth.Value.Date,
                Fullname = txtInsuranceBillPerson.Text,
                HomePhone = txtInsuranceBillPersonHomePhoneNo.Text,
                BilleeID = 001
            };
            if (rdbInsuranceBillPersonCoveredByInsuranceYES.Checked)
            {
                billee.IsCoveredByInsurance = true;
            }
            else if (rdbInsuranceBillPersonCoveredByInsuranceNO.Checked)
            {
                billee.IsCoveredByInsurance = false;
            }
            if (rdbInsuranceBillPersonPatientHereYES.Checked)
            {
                billee.IsPatient = true;
            }
            else if (rdbInsuranceBillPersonPatientHereNO.Checked)
            {
                billee.IsPatient = false;
            }

            try
            {
                int statusCode = repo.AddPatient(pat, insurance, secInsurance, employer, relative, billee);
                if (statusCode > 0)
                {
                    MessageBox.Show("Record saved successfully");
                }
                else
                {
                    MessageBox.Show("Error saving patient record. Details: ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving patient record. Details: " + ex.Message);

            }
        }

        private void txtWorkPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox27_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadPassportPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif;*.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picPassport.Image = new Bitmap(open.FileName);
            }
        }

        private void btnUploadThumbPrint_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif;*.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picThumbPrint.Image = new Bitmap(open.FileName);
            }
        }

        private void btnUploadSignature_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif;*.png; *.bmp)|*.jpg; *.jpeg; *.gif; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picSignature.Image = new Bitmap(open.FileName);
            }
        }
    }
}
