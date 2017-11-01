﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByticHealth.App_Data
{
    public class DischargeSummary
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SumID { get; set; }
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int? PatNum { get; set; }
        [ForeignKey("StaffID")]
        public Staff Staff { get; set; }
        public int StaffID { get; set; }
        [ForeignKey("AdmNum")]
        public virtual Admission Admission { get; set; }
        public int AdmNum { get; set; }

        [ForeignKey("DgNum")]
        public virtual Discharge Discharge { get; set; }
        public int? DgNum { get; set; }

    }

    public class Discharge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DgNum { get; set; }
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }

        [ForeignKey("BedNo")]
        public virtual Bed Bed { get; set; }
        public int BedNo { get; set; }
        public TimeSpan DischargeTime { get; set; }

        public string Remark { get; set; }
        public DateTime DischargeDate { get; set; }
        public DateTime DischargeDateTime { get; set; }

    }
}
