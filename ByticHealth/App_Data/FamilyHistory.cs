using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByticHealth.App_Data
{
    public class FamilyHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FamilyHistoryID { get; set; }
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }

        public string Fullname { get; set; }
        public string Details { get; set; }
        public string CauseOfDeath { get; set; }
        public bool? Deceased { get; set; }
        public int? Age { get; set; }
        public int? AgeOfDeath { get; set; }

        [ForeignKey("RelationshipTypeListID")]
        public virtual RelationTypeList RelationshipTypeList { get; set; }
        public int RelationshipTypeListID { get; set; }


    }

    public class FamilyPsychiaPromblem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FamilyPsychiaPromblemID { get; set; }
        public string Fullname { get; set; }
        public string Side { get; set; } // Parternal or Maternal
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }

    }

}
