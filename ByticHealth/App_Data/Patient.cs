namespace ByticHealth.App_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            Billees = new HashSet<Billee>();
            Employers = new HashSet<Employer>();
            PrimaryInsurances = new HashSet<PrimaryInsurance>();
            Relatives = new HashSet<Relative>();
            SecondaryInsurances = new HashSet<SecondaryInsurance>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatNum { get; set; }
        public string Sex { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        public int? MaritalStatus { get; set; }

        public bool? IsLegalName { get; set; }

        [StringLength(50)]
        public string LegalName { get; set; }

        [StringLength(50)]
        public string FormerName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string SSN { get; set; }

        [StringLength(50)]
        public string HomePhoneNo { get; set; }

        [StringLength(50)]
        public string CellPhone { get; set; }

        [StringLength(50)]
        public string Occupation { get; set; }

        [StringLength(50)]
        public string Referral { get; set; }

        public bool? ReferredByDoctor { get; set; }

        [StringLength(50)]
        public string OtherPrimaryInsurance { get; set; }

        [Column(TypeName = "image")]
        public byte[] Signature { get; set; }

        [Column(TypeName = "image")]
        public byte[] PassportPhoto { get; set; }

        [Column(TypeName = "image")]
        public byte[] Barcode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StaffID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StaffCategoryID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billee> Billees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employer> Employers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrimaryInsurance> PrimaryInsurances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Relative> Relatives { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SecondaryInsurance> SecondaryInsurances { get; set; }
    }
}
