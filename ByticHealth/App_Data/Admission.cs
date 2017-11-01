using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByticHealth.App_Data
{
   public class Admission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AdmNum { get; set; }
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }

        [ForeignKey("BedNo")]
        public virtual Bed Bed { get; set; }
        public int BedNo { get; set; }
        public TimeSpan AdmissionTime { get; set; }

        public string Remark { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime AdmissionDateTime { get; set; }
        public int AdmissionMethod { get; set; }


    }


    public class Ward
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WardNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WardType { get; set; }


    }

    public class Bed
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BedNo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [ForeignKey("WardNo")]
        public virtual Ward Ward { get; set; }
        public int WardNo { get; set; }
        public string Status { get; set; }
        public string remark { get; set; }



    }

}
