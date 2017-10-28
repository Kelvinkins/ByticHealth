namespace ByticHealth.App_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Billee")]
    public partial class Billee
    {
        [Column(TypeName = "numeric")]
        public decimal BilleeID { get; set; }

        [StringLength(50)]
        public string Fullname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(50)]
        public string HomePhone { get; set; }

        public bool? IsPatient { get; set; }

        public bool? IsCoveredByInsurance { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrimaryInsuranceID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SecondaryInsuranceID { get; set; }

        public int? PatNum { get; set; }

        public virtual PrimaryInsurance PrimaryInsurance { get; set; }

        public virtual SecondaryInsurance SecondaryInsurance { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
