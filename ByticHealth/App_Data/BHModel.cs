namespace ByticHealth.App_Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BHModel : DbContext
    {
        public BHModel()
            : base("name=BHModel")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Billee> Billees { get; set; }
        public virtual DbSet<Employer> Employers { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PrimaryInsurance> PrimaryInsurances { get; set; }
        public virtual DbSet<Relative> Relatives { get; set; }
        public virtual DbSet<SecondaryInsurance> SecondaryInsurances { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<PastMedicalHistory> PastMedicalHistories { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugAllergy> DrugAllergies { get; set; }
        public virtual DbSet<DrugCategory> DrugCategories { get; set; }
        public virtual DbSet<MedHistoryItem> MedHistoryItems { get; set; }
        public virtual DbSet<RelationTypeList> RelationTypeLists { get; set; }
        public virtual DbSet<CurrentMedication> CurrentMedications { get; set; }
        public virtual DbSet<FamilyHistory> FamilyHistories{ get; set; }
        public virtual DbSet<FamilyPsychiaPromblem> FamilyPsychiaPromblems { get; set; }
        public virtual DbSet<SystemReviewList> SystemReviewLists { get; set; }
        public virtual DbSet<PatientSystemReview> PatientSystemReviews { get; set; }
        public virtual DbSet<WomenProductiveHistory> WomenProductiveHistories { get; set; }
        public virtual DbSet<SubstanceUse> SubstanceUses { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<PatientVital> PatientVitals { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Doctor>Doctors { get; set; }
        public virtual DbSet<Nurse> Nurses { get; set; }
        public virtual DbSet<Admission> Admissions { get; set; }
        public virtual DbSet<Ward> Wards { get; set; }
        public virtual DbSet<Bed> Beds { get; set; }
        public virtual DbSet<Discharge> Discharges { get; set; }
        public virtual DbSet<DischargeSummary> DischargeSummaries { get; set; }
        public virtual DbSet<Diagnosis>Diagnoses { get; set; }
        public virtual DbSet<PatientDiagnosis> PatientDiagnoses { get; set; }
        public virtual DbSet<AdverseEvent> AdverseEvents { get; set; }
        public virtual DbSet<Diet>Diets { get; set; }
        public virtual DbSet<RelevantInvestigationsAndResult> RelevantInvestigationsAndResults { get; set; }
        public virtual DbSet<InfectionControlStatus> InfectionControlStatuses { get; set; }
        public virtual DbSet<FunctionalState>FunctionalStates { get; set; }
        public virtual DbSet<Immunisation> Immunisations { get; set; }
        public virtual DbSet<RelevantTreatmentsAndChangesMadeInTreatment> RelevantTreatmentsAndChangesMadeInTreatments { get; set; }
        public virtual DbSet<OperationAndProcedure> OperationAndProcedures { get; set; }
        public virtual DbSet<MedicationOnDischarge> MedicationOnDischarges { get; set; }
        public virtual DbSet<MeicationStoppedWithheald> MeicationStoppedWithhealds { get; set; }
        //public virtual DbSet<GpAction> GpActions { get; set; }
        //public virtual DbSet<AdviceRecommendationAndFuturePlan> AdviceRecommendationAndFuturePlans { get; set; }
        //public virtual DbSet<HospitalAction> HospitalActions { get; set; }
        //public virtual DbSet<InformationGivenToPatientAndCarer> InformationGivenToPatientAndCarers { get; set; }
        //public virtual DbSet<SocialCareAction> SocialCareActions { get; set; }
        public virtual DbSet<HospitalSite> HospitalSites { get; set; }
        public virtual DbSet<Action> Actions { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Billee>()
                .Property(e => e.BilleeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Billee>()
                .Property(e => e.PrimaryInsuranceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Billee>()
                .Property(e => e.SecondaryInsuranceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Employer>()
                .Property(e => e.EmployerID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Patient>()
                .Property(e => e.StaffID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Patient>()
                .Property(e => e.StaffCategoryID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PrimaryInsurance>()
                .Property(e => e.PrimaryInsuranceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Relative>()
                .Property(e => e.RelativeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SecondaryInsurance>()
                .Property(e => e.SecondaryInsuranceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Staff>()
                .Property(e => e.StaffID);
        }
    }
}
