namespace ByticHealth.App_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SecondaryInsurance")]
    public partial class SecondaryInsurance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SecondaryInsurance()
        {
            Billees = new HashSet<Billee>();
        }

        [Column(TypeName = "numeric")]
        public decimal SecondaryInsuranceID { get; set; }

        [StringLength(50)]
        public string InsuranceName { get; set; }

        [StringLength(50)]
        public string SubscriberName { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string GroupNo { get; set; }

        [StringLength(50)]
        public string PolicyNo { get; set; }

        [StringLength(50)]
        public string RelationshipToPatient { get; set; }

        public int? PatNum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Billee> Billees { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
