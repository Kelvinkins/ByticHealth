using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByticHealth.App_Data
{
    public class CurrentMedication
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CurrentMedicationID { get; set; }
       [ForeignKey("DrugID")]
        public virtual Drug Drug { get; set; }
        public int DrugID { get; set; }
        public string HowLong { get; set; }
        public int? NumberOfPill { get; set; }
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }



    }
}
