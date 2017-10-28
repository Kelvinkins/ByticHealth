namespace ByticHealth.App_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employer")]
    public partial class Employer
    {
        [Column(TypeName = "numeric")]
        public decimal EmployerID { get; set; }

        [StringLength(50)]
        public string Fullname { get; set; }

        [StringLength(50)]
        public string PhoneNo { get; set; }

        public int? PatNum { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
