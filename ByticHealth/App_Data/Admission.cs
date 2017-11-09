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
        public string SourceOfReferal { get; set; }
        [ForeignKey("ID")]
        public virtual HospitalSite HospitalSite { get; set; }
        public int? ID { get; set; }
        public bool IsDischarged { get; set; }
        public DateTime? DischargeDate { get; set; }



    }


    public class HospitalSite
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }

    public class AdverseEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Description { get; set; }
        [ForeignKey("PatNum")]
        public virtual Patient Patient { get; set; }
        public int PatNum { get; set; }
    }

    public class PatientDiagnosis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IndexNo { get; set; }
        [ForeignKey("AdmNum")]
        public virtual Admission Admission { get; set; }
        public int AdmNum { get; set; }
        [ForeignKey("Code")]
        public virtual Diagnosis Diagnosis { get; set; }
        public string Code { get; set; }
        public string Remark { get; set; }
        public string DType { get; set; }



    }
    public class RelevantInvestigationsAndResult {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Description { get; set; }
        [ForeignKey("AdmNum")]
        public virtual Admission Admission { get; set; }
        public int AdmNum { get; set; }
    }

    public class InfectionControlStatus {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Description { get; set; }
        [ForeignKey("AdmNum")]
        public virtual Admission Admission { get; set; }
        public int AdmNum { get; set; }
    }

    public class Immunisation {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Description { get; set; }
        [ForeignKey("AdmNum")]
        public virtual Admission Admission { get; set; }
        public int AdmNum { get; set; }
    }

    public class FunctionalState {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("AdmNum")]
        public virtual Admission Admission { get; set; }
        public int AdmNum { get; set; }
    }

    public class Diet {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Description { get; set; }
        [ForeignKey("AdmNum")]
        public virtual Admission Admission { get; set; }
        public int AdmNum { get; set; }
    }

    public class RelevantTreatmentsAndChangesMadeInTreatment {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Description { get; set; }
        [ForeignKey("AdmNum")]
        public virtual Admission Admission { get; set; }
        public int AdmNum { get; set; }
    }


    public class Diagnosis
    {
        [Key]
        public string Code { get; set; }
        public string Description { get; set; }

    }

    public class OperationAndProcedure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        [ForeignKey("AdmNum")]
        public virtual Admission Admission { get; set; }
        public int AdmNum { get; set; }

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
        public int? Status { get; set; }
        public string remark { get; set; }



    }

    public class MedicationOnDischarge
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Remark { get; set; }
        [ForeignKey("DrugID")]
        public virtual Drug Drug { get; set; }
        public int DrugID { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }
        public int Total { get; set; }

        [ForeignKey("DgNum")]
        public virtual Discharge Discharge { get; set; }
        public int DgNum { get; set; }

    }

    public class MeicationStoppedWithheald
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }
        public string Remark { get; set; }
        [ForeignKey("DrugID")]
        public virtual Drug Drug { get; set; }
        public int DrugID { get; set; }
        public int Dosage { get; set; }     
    }




}
