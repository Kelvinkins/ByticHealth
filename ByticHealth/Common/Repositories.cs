using ByticHealth.App_Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ByticHealth.Common
{
    class Repositories
    {
        BHModel db = new BHModel();
        public Patient AddPatient(Patient patient)
        {
            #region Commented out
            //var bill = new Billee
            //{
            //    Fullname = billee.Fullname,
            //    DateOfBirth = billee.DateOfBirth,
            //    Address = billee.Address,
            //    BilleeID = billee.BilleeID,
            //    HomePhone = billee.HomePhone,
            //    IsCoveredByInsurance = billee.IsCoveredByInsurance,
            //    IsPatient = billee.IsPatient



            //};
            //db.Billees.Add(bill);
            //var emp = new Employer
            //{
            //    EmployerID = employer.EmployerID,
            //    Fullname = employer.Fullname,
            //    PhoneNo = employer.PhoneNo
            //};
            //db.Employers.Add(emp);

            //var rel = new Relative
            //{
            //    Fullname = relative.Fullname,
            //    HomePhoneNo = relative.HomePhoneNo,
            //    RelationshipToPatient = relative.RelationshipToPatient,
            //    RelativeID = relative.RelativeID,
            //    WorkPhoneNo = relative.WorkPhoneNo
            //};
            //db.Relatives.Add(rel);


            //var secondInsurance = new SecondaryInsurance
            //{
            //    InsuranceName = secInsurance.InsuranceName,
            //    DateOfBirth = secInsurance.DateOfBirth,
            //    GroupNo = insurance.GroupNo,
            //    SecondaryInsuranceID = secInsurance.SecondaryInsuranceID,
            //    SubscriberName = secInsurance.SubscriberName,
            //    PolicyNo = secInsurance.PolicyNo
            //};
            //db.SecondaryInsurances.Add(secondInsurance);

            //var primaryInsurance = new PrimaryInsurance
            //{
            //    InsuranceName = insurance.InsuranceName,
            //    Copayment = insurance.Copayment,
            //    DateOfBirth = insurance.DateOfBirth,
            //    GroupNo = insurance.GroupNo,
            //    GroupPolicy = insurance.GroupPolicy,
            //    PrimaryInsuranceID = insurance.PrimaryInsuranceID,
            //    SubscriberName = insurance.SubscriberName,
            //    SubscriberSSN = insurance.SubscriberSSN

            //};
            //db.PrimaryInsurances.Add(primaryInsurance);
            ////try
            ////{
            //    if (db.SaveChanges() > 4)
            //    {

            //        bill.PrimaryInsuranceID = primaryInsurance.PrimaryInsuranceID;
            //        bill.SecondaryInsuranceID = secInsurance.SecondaryInsuranceID;

            #endregion 
            var pat = new Patient
                    {
                        PatNum = patient.PatNum,
                        FirstName = patient.FirstName,
                        Barcode = patient.Barcode,
                        CellPhone = patient.CellPhone,
                        DateOfBirth = patient.DateOfBirth,
                        FormerName = patient.FormerName,
                        HomePhoneNo = patient.HomePhoneNo,
                        IsLegalName = patient.IsLegalName,
                        LastName = patient.LastName,
                        LegalName = patient.LegalName,
                        MaritalStatus = patient.MaritalStatus,
                        MiddleName = patient.MiddleName,
                        Occupation = patient.Occupation,
                        OtherPrimaryInsurance = patient.OtherPrimaryInsurance,
                        Referral = patient.Referral,
                        ReferredByDoctor = patient.ReferredByDoctor,
                        SSN = patient.SSN,
                        StaffCategoryID = patient.StaffCategoryID,
                        StaffID = patient.StaffID,
                        //EmployerID = emp.EmployerID,
                        //RelativeID = relative.RelativeID,
                        //PrimaryInsuranceID = primaryInsurance.PrimaryInsuranceID,
                        //SecondaryInsuranceID = secondInsurance.SecondaryInsuranceID,
                        PassportPhoto = patient.PassportPhoto,
                        Signature = patient.Signature
                    };

                    db.Patients.Add(pat);
                     db.SaveChanges();

                       return pat;
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error saving patient record. Details: " + ex.Message);
            //    return statusCode;

            //}
        }
    }


    class CommonCode
    {
    BHModel db = new BHModel();

        public static byte[] converterTo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
    }


    class Computation
    {
       static BHModel db = new BHModel();

       
        //public static int ComputeID<T>(T obj, int id)
        //{
        //    foreach (var prop in typeof(T).GetProperties())
        //    {
        //        var temp = temp.Replace("{" + prop.Name + "}", prop.GetValue(obj));
        //    }
        //    return temp;


        //    return 0;
        //}

        public static int GetPatientID(int id)
        {
            int Id = db.Patients.Count();

            return Id+id;
        }
        public static int GetEmployerID(int id)
        {
            int Id = db.Employers.Count();
            return Id+id;
        }

        public static int GetRelativeID(int id)
        {
            int Id = db.Relatives.Count();
            return Id + id;
        }
        public static int GetPrimaryInsuranceID(int id)
        {
        int Id = db.PrimaryInsurances.Count();
            return Id + id;
        }
        public static int GetSecondaryInsuranceID(int id)
        {
            int Id = db.SecondaryInsurances.Count();
            return Id + id;
        }
        public static int GetBilleeID(int id)
        {
            int Id = db.Billees.Count();
            return Id + id;
        }
        public static int GetStaffD(int id)
        {
            int Id = db.Staffs.Count();
            return Id + id;
        }
    public static int GetPastHistoryID(int id)
    {
        int Id = db.PastMedicalHistories.Count();
        return Id + id;
    }
    public static int GetCurMedID(int id)
    {
        int Id = db.CurrentMedications.Count();
        return Id + id;
    }
    public static int GetDrugAllerg(int id)
    {
        int Id = db.DrugAllergies.Count();
        return Id + id;
    }

    public static int GetFamilyHistoryID(int id)
    {
        int Id = db.FamilyHistories.Count();
        return Id + id;
    }


    public static int GetFamilyPsychiaPromblemID(int id)
    {
        int Id = db.FamilyPsychiaPromblems.Count();
        return Id + id;
    }

    public static int GetPatientSystemReviewID(int id)
    {
        int Id = db.PatientSystemReviews.Count();
        return Id + id;
    }
    public static int GetSystemReviewListID(int id)
    {
        int Id = db.SystemReviewLists.Count();
        return Id + id;
    }
    public static int GetGetDrugCategoryID(int id)
    {
        int Id = db.DrugCategories.Count();
        return Id + id;
    }

    public static int GetBillID(int id)
    {
        int Id = db.Bills.Count();
        return Id + id;
    }

    public static int GetBillDetailID(int id)
    {
        int Id = db.BillDetails.Count();
        return Id + id;
    }

    public static int GetPatientVitalID(int id)
    {
        int Id = db.PatientVitals.Count();
        return Id + id;
    }

    public static int GetAppointmentID(int id)
    {
        int Id = db.Appointments.Count();
        return Id + id;
    }
}


