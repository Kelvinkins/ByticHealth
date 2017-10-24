using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByticHealth.App_Data
{
    public class Appointment
    {
         [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AptNum { get; set; }

        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }
        [ForeignKey("StaffID")]
        public virtual Staff Staff { get; set; }
        public int StaffID { get; set; }
        public DateTime AptDateTime { get; set; }
        public int AptStatus { get; set; }
        public DateTime AptEndTime { get; set; }
        public string Remark { get; set; }

    }
}
