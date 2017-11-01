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
using ByticHealth.Forms;
using System.IO;
//using Syncfusion.Windows.Forms.Barcode;

namespace ByticHealth.UserControls
{
    public partial class uscPatientRegistration : UserControl
    {
        public static System.Windows.Forms.PictureBox picPassport;
        public static int PatNum;

        public uscPatientRegistration()
        {
            
            InitializeComponent();
            PatNum = 0;
            lblTodayDate.Text = DateTime.Now.ToShortDateString();
            cmbMaritalStatus.DataSource = Enum.GetValues(typeof(Enumerations.enumMaritalStatus));
            //cmbRelationshipToPatient.DataSource = Enum.GetValues(typeof(Enumerations.enumRelationType));
            //cmbPatRelationshipToSubscriber.DataSource = Enum.GetValues(typeof(Enumerations.enumRelationType));
            cmbSex.DataSource = Enum.GetValues(typeof(Enumerations.enumSex));
            //txtPatRelationToSecInsuranceSubscriber.DataSource = Enum.GetValues(typeof(Enumerations.enumRelationType));
            picPassport = new System.Windows.Forms.PictureBox();
            //((System.ComponentModel.ISupportInitialize)(picPassport)).BeginInit();
            this.groupBox34.Controls.Add(picPassport);
            picPassport.Dock = System.Windows.Forms.DockStyle.Fill;
            picPassport.Image = global::ByticHealth.Properties.Resources.placeholder;
           picPassport.Location = new System.Drawing.Point(3, 16);
            picPassport.Name = "picPassport";
           picPassport.Size = new System.Drawing.Size(140, 134);
            picPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
           picPassport.TabIndex = 0;
            picPassport.TabStop = false;

        }
        BHModel db = new BHModel();

        public uscPatientRegistration(int PatNum)
        {

            InitializeComponent();
            lblTodayDate.Text = DateTime.Now.ToShortDateString();
            cmbMaritalStatus.DataSource = Enum.GetValues(typeof(Enumerations.enumMaritalStatus));
            //cmbRelationshipToPatient.DataSource = Enum.GetValues(typeof(Enumerations.enumRelationType));
            //cmbPatRelationshipToSubscriber.DataSource = Enum.GetValues(typeof(Enumerations.enumRelationType));
            cmbSex.DataSource = Enum.GetValues(typeof(Enumerations.enumSex));
            //txtPatRelationToSecInsuranceSubscriber.DataSource = Enum.GetValues(typeof(Enumerations.enumRelationType));
            picPassport = new System.Windows.Forms.PictureBox();
            //((System.ComponentModel.ISupportInitialize)(picPassport)).BeginInit();
            this.groupBox34.Controls.Add(picPassport);
            picPassport.Dock = System.Windows.Forms.DockStyle.Fill;
            picPassport.Image = global::ByticHealth.Properties.Resources.placeholder;
            picPassport.Location = new System.Drawing.Point(3, 16);
            picPassport.Name = "picPassport";
            picPassport.Size = new System.Drawing.Size(140, 134);
            picPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picPassport.TabIndex = 0;
            picPassport.TabStop = false;
            //PatNum = 0;
            
            decimal key = Convert.ToDecimal(uscPatientRegistration.PatNum);
            
            var patient = db.Patients.Find(key);
            txtPatNum.Text = patient.PatNum.ToString();
            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtMiddleName.Text = patient.MiddleName;
            txtCellPhone.Text = patient.CellPhone;
            txtFormerName.Text = patient.FormerName;
            txtHomePhone.Text = patient.HomePhoneNo;
            txtLegalName.Text = patient.LegalName;
            txtOccupation.Text = patient.Occupation;
            txtSSN.Text = patient.SSN;
            PatNum = patient.PatNum;
            using (var ms = new MemoryStream(patient.PassportPhoto))
            {
                picPassport.Image = Image.FromStream(ms);

            }

            //using (var ms = new MemoryStream(patient.Barcode))
            //{
            //    picBarcode.Image = Image.FromStream(ms);

            //}


            string barcode = patient.PatNum.ToString();

            Bitmap bitm = new Bitmap(barcode.Length * 45, 160);
            using (Graphics graphic = Graphics.FromImage(bitm))
            {


                Font newfont = new Font("IDAutomationHC39M", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphic.FillRectangle(white, 0, 0, bitm.Width, bitm.Height);
                graphic.DrawString(barcode, newfont, black, point);


            }

            picBarcode.Image = bitm;

            using (var ms = new MemoryStream(patient.Signature))
            {
                picSignature.Image = Image.FromStream(ms);

            }

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
            //Repositories repo = new Repositories();
            CommonCode common = new CommonCode();
            var pat = new Patient
            {
                PatNum = Computation.GetPatientID(1),
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
                Signature = CommonCode.converterTo(picSignature.Image),
                CancerPatient = chkCancerPatient.Checked,
                PatientType = (int)Enumerations.PatientType.OT
                
            };

            if (rdbLegalYes.Checked)
            {
                pat.IsLegalName = true;
            }
            else if (rdbLegalNo.Checked)
            {
                pat.IsLegalName = false;
            }
            db.Patients.Add(pat);
            if (db.SaveChanges()>0)
            {
                PatNum = pat.PatNum;
                string barcode = pat.PatNum.ToString();

                Bitmap bitm = new Bitmap(barcode.Length * 45, 160);
                using (Graphics graphic = Graphics.FromImage(bitm))
                {


                    Font newfont = new Font("IDAutomationHC39M", 20);
                    PointF point = new PointF(2f, 2f);
                    SolidBrush black = new SolidBrush(Color.Black);
                    SolidBrush white = new SolidBrush(Color.White);
                    graphic.FillRectangle(white, 0, 0, bitm.Width, bitm.Height);
                    graphic.DrawString(barcode, newfont, black, point);


                }
               
                picBarcode.Image = bitm;
                MessageBox.Show("Record saved successfully");
            }
            else
            {
                MessageBox.Show("Error saving patient record. Details: ");
            }
        }
            #region Commented out
            //var employer = new Employer
            //{
            //    EmployerID = Computation.GetEmployerID(1),
            //    Fullname = txtEmployer.Text,
            //    PhoneNo = txtEmployerPhoneNo.Text
            //};

            //var insurance = new PrimaryInsurance
            //{
            //    Copayment = txtInsuranceCopayment.Text,
            //    DateOfBirth = dteInsuranceSubscriberDateOfBirth.Value.Date,
            //    GroupNo = txtInsuranceGroupNo.Text,
            //    GroupPolicy = txtInsuranceGroupNo.Text,
            //    InsuranceName = txtPrimaryInsuranceName.Text,
            //    SubscriberName = txtSubscriberName.Text,
            //    SubscriberSSN = txtSubscriberSSN.Text,
            //    PrimaryInsuranceID = Computation.GetPrimaryInsuranceID(1)
            //};

            //var secInsurance = new SecondaryInsurance
            //{
            //    DateOfBirth = dteSecInsuranceDateOfBirth.Value.Date,
            //    GroupNo = txtSecInsuranceGroupNo.Text,
            //    InsuranceName = txtSecInsurance.SelectedText,
            //    SubscriberName = txtSecInsuranceSubscriber.Text,
            //    PolicyNo = txtSecInsurancePolicyNo.Text,
            //    SecondaryInsuranceID = Computation.GetSecondaryInsuranceID(1)
            //};
            //var relative = new Relative
            //{
            //    Fullname = txtNameRelativeNotLeavingClose.Text,
            //    HomePhoneNo = txtRelativeHomePhone.Text,
            //    RelationshipToPatient = cmbRelationshipToPatient.SelectedValue.ToString(),
            //    WorkPhoneNo = txtRelativeWorkPhone.Text,
            //    RelativeID = Computation.GetRelativeID(1)
            //};
            //var billee = new Billee
            //{
            //    Address = txtInsuranceBillPersonAddress.Text,
            //    DateOfBirth = dteInsuranceBillPersonDateOfBirth.Value.Date,
            //    Fullname = txtInsuranceBillPerson.Text,
            //    HomePhone = txtInsuranceBillPersonHomePhoneNo.Text,
            //    BilleeID = Computation.GetBilleeID(1)
            //};
            //if (rdbInsuranceBillPersonCoveredByInsuranceYES.Checked)
            //{
            //    billee.IsCoveredByInsurance = true;
            //}
            //else if (rdbInsuranceBillPersonCoveredByInsuranceNO.Checked)
            //{
            //    billee.IsCoveredByInsurance = false;
            //}
            //if (rdbInsuranceBillPersonPatientHereYES.Checked)
            //{
            //    billee.IsPatient = true;
            //}
            //else if (rdbInsuranceBillPersonPatientHereNO.Checked)
            //{
            //    billee.IsPatient = false;
            //}
            #endregion

           

                

        

        private void txtWorkPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox27_Enter(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            uscPatientRegistration.PatNum = (Convert.ToInt32(txtPatNum.Text));
            decimal key = Convert.ToDecimal(uscPatientRegistration.PatNum);
            var patient = db.Patients.Find(key);
            txtFirstName.Text = patient.FirstName;
            txtLastName.Text = patient.LastName;
            txtMiddleName.Text = patient.MiddleName;
            txtCellPhone.Text = patient.CellPhone;
            txtFormerName.Text = patient.FormerName;
            txtHomePhone.Text = patient.HomePhoneNo;
            txtLegalName.Text = patient.LegalName;
            txtOccupation.Text = patient.Occupation;
            txtSSN.Text = patient.SSN;
            PatNum = patient.PatNum;
            using (var ms = new MemoryStream(patient.PassportPhoto))
            {
                picPassport.Image = Image.FromStream(ms);
               
            }

            //using (var ms = new MemoryStream(patient.Barcode))
            //{
            //    picBarcode.Image = Image.FromStream(ms);

            //}


            string barcode = patient.PatNum.ToString();

            Bitmap bitm = new Bitmap(barcode.Length * 45, 160);
            using (Graphics graphic = Graphics.FromImage(bitm))
            {


                Font newfont = new Font("IDAutomationHC39M", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graphic.FillRectangle(white, 0, 0, bitm.Width, bitm.Height);
                graphic.DrawString(barcode, newfont, black, point);


            }
        
            picBarcode.Image = bitm;

            using (var ms = new MemoryStream(patient.Signature))
            {
                picSignature.Image = Image.FromStream(ms);

            }
        
            //using (MemoryStream Mmst = new MemoryStream())
            //{


            //    bitm.Save("ms", ImageFormat.Jpeg);
            //picBarcode.Width = bitm.Width;
            //picBarcode.Height = bitm.Height;

            //var billee = db.Billees.Where(b => b.PatNum == patient.PatNum).FirstOrDefault();
            //txtInsuranceBillPerson.Text = billee.Fullname;
            //txtInsuranceBillPersonAddress.Text = billee.Address;
            //txtInsuranceBillPersonHomePhoneNo.Text = billee.HomePhone;
            //if (Convert.ToBoolean(billee.IsCoveredByInsurance))
            //{
            //    rdbInsuranceBillPersonCoveredByInsuranceNO.Checked = false;
            //    rdbInsuranceBillPersonCoveredByInsuranceYES.Checked = true;
            //    var prime = db.PrimaryInsurances.Where(p => p.PatNum == patient.PatNum && p.PrimaryInsuranceID == billee.PrimaryInsuranceID).FirstOrDefault();
            //    txtSubscriberName.Text = prime.SubscriberName;
            //    txtSubscriberSSN.Text = prime.SubscriberSSN;
            //}
            //var primaryInsurance = db.PrimaryInsurances.Where(p => p.PatNum == patient.PatNum).FirstOrDefault();
            //txtPrimaryInsuranceName.Text = primaryInsurance.InsuranceName;
            //txtInsuranceSubscriberName.Text = primaryInsurance.SubscriberName;
            //txtInsuranceSubscriberSSN.Text = primaryInsurance.SubscriberSSN;
            //txtInsuranceSubscriberGroupPolicy.Text = primaryInsurance.GroupPolicy;
            //txtInsuranceGroupNo.Text = primaryInsurance.GroupNo;
            //txtInsuranceCopayment.Text = primaryInsurance.Copayment;



        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Main frm = new Main();
            frm.ShowDialog();

        }
    }
}
