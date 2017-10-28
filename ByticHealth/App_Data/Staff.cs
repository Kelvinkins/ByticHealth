namespace ByticHealth.App_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StaffID { get; set; }
        public string Fullname { get; set; }
        public string PhoneNo { get; set; }
        public string HomeAddress { get; set; }
        public string emailAddress { get; set; }
        public string Sex { get; set; }

        public int? StaffCategoryCode { get; set; }
    }

    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DoctorID { get; set; }
        public string Specialty { get; set; }
        public int? StaffID { get; set; }
    }

    public class Nurse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NurseID { get; set; }
        public string Specialty { get; set; }
        public int? StaffID { get; set; }
    }

}
