using ByticHealth.App_Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByticHealth.Common
{
    class Repositories
    {
        BHDBEntities db = new BHDBEntities();
        public int AddPatient(Patient patient, PrimaryInsurance insurance, SecondaryInsurance secInsurance,Employer employer, Relative relative, Billee billee)
        {
            int statusCode = 0;

            var bill = new Billee
            {
                Fullname = billee.Fullname,
                DateOfBirth = billee.DateOfBirth,
                Address = billee.Address,
                BilleeID = billee.BilleeID,
                HomePhone = billee.HomePhone,
                IsCoveredByInsurance = billee.IsCoveredByInsurance,
                IsPatient = billee.IsPatient



            };

            var emp = new Employer
            {
                EmployerID = employer.EmployerID,
                Fullname = employer.Fullname,
                PhoneNo = employer.PhoneNo
            };
            db.Employers.Add(emp);

            var rel = new Relative
            {
                Fullname = relative.Fullname,
                HomePhoneNo = relative.HomePhoneNo,
                RelationshipToPatient = relative.RelationshipToPatient,
                RelativeID = relative.RelativeID,
                WorkPhoneNo = relative.WorkPhoneNo
            };
            db.Relatives.Add(rel);


            var secondInsurance = new SecondaryInsurance
            {
                InsuranceName = secInsurance.InsuranceName,
                DateOfBirth = secInsurance.DateOfBirth,
                GroupNo = insurance.GroupNo,
                SecondaryInsuranceID = secInsurance.SecondaryInsuranceID,
                SubscriberName = secInsurance.SubscriberName,
                PolicyNo = secInsurance.PolicyNo
            };
            db.SecondaryInsurances.Add(secondInsurance);

            var primaryInsurance = new PrimaryInsurance
            {
                InsuranceName = insurance.InsuranceName,
                Copayment = insurance.Copayment,
                DateOfBirth = insurance.DateOfBirth,
                GroupNo = insurance.GroupNo,
                GroupPolicy = insurance.GroupPolicy,
                PrimaryInsuranceID = insurance.PrimaryInsuranceID,
                SubscriberName = insurance.SubscriberName,
                SubscriberSSN = insurance.SubscriberSSN

            };
            db.PrimaryInsurances.Add(primaryInsurance);

            if (db.SaveChanges() > 4)
            {

                bill.PrimaryInsuranceID = primaryInsurance.PrimaryInsuranceID;
                bill.SecondaryInsuranceID = secInsurance.SecondaryInsuranceID;
            
              
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
                        StaffID=patient.StaffID,
                        EmployerID = emp.EmployerID,
                        RelativeID=relative.RelativeID,
                        PrimaryInsuranceID=primaryInsurance.PrimaryInsuranceID,
                        SecondaryInsuranceID=secondInsurance.SecondaryInsuranceID,
                        PassportPhoto=patient.PassportPhoto,
                        Signature=patient.Signature
                    };

                db.Patients.Add(pat);
                statusCode=db.SaveChanges();
                
            }




            return statusCode;
        }
    }


    class CommonCode
    {

        public static byte[] converterTo(Image x)
        {
            ImageConverter _imageConverter = new ImageConverter();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }
    }



}
