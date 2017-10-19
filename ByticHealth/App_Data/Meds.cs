using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByticHealth.App_Data
{
    public class DrugAllergy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrugsAllergyID { get; set; }
        [ForeignKey("DrugID")]
        public virtual Drug Drug { get; set; }
        public int DrugID { get; set; }

        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }

        public int PatNum { get; set; }



    }


    public class Drug
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrugID { get; set; }
        public string DrugName { get; set; }
        public string Description { get; set; }
        public string OtherInfo { get; set; }
        [ForeignKey("DrugCategoryID")]
        public virtual DrugCategory DrugCategory { get; set; }
        public int DrugCategoryID { get; set; }
    }


    public class DrugCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DrugCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
 
    }

    public class MedHistoryItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MedHistoryItemID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
    public class RelationTypeList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RelationTypeListID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }

    public class PatientSystemReview
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PatientSystemReviewID { get; set; }
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }
        [ForeignKey("SystemReviewListID")]
        public virtual SystemReviewList SystemReviewList { get; set; }
        public int? SystemReviewListID { get; set; }
        public string Details { get; set; }



    }


    public class SystemReviewList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SystemReviewListID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


    }


    public class WomenProductiveHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WomenProductiveHistoryID { get; set; }
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }
        public int AgeOfFirstPeriod { get; set; }
        public int Pregnancies { get; set; }
        public int Miscarriages { get; set; }
        public int Abortions { get; set; }
        public bool Menopause { get; set; }
        public int AGeOfMenopause { get; set; }
        public bool RegularPeriod { get; set; }


    }

    public class SubstanceUse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubstanceUseID { get; set; }
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }
        public int Age { get; set; }
        public int Years { get; set; }
        public string HowOften { get; set; }
        [ForeignKey("DrugCategoryID")]
        public virtual DrugCategory DrugCategory { get; set; }
        public int? DrugCategoryID { get; set; }
        public bool? CurrentlyUsed { get; set; }


    }

}