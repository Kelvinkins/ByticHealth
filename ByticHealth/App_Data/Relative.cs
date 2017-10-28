namespace ByticHealth.App_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Relative")]
    public partial class Relative
    {
        [Column(TypeName = "numeric")]
        public decimal RelativeID { get; set; }

        [StringLength(50)]
        public string Fullname { get; set; }

        //[StringLength(50)]
        //public string RelationshipToPatient { get; set; }

        [StringLength(50)]
        public string HomePhoneNo { get; set; }

        [StringLength(50)]
        public string WorkPhoneNo { get; set; }

        public int? PatNum { get; set; }

        public virtual Patient Patient { get; set; }

        [ForeignKey("RelationshipTypeListID")]
        public virtual RelationTypeList RelationshipTypeList { get; set; }
        public int RelationshipTypeListID { get; set; }

        public bool CallForEmergency { get; set; }


    }
}
