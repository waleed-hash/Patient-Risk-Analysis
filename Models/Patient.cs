namespace PatientRiskAnalytics.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public double BMI { get; set; }
        public bool HasDiabetes { get; set; }
        public bool HasHypertension { get; set; }
        public bool IsSmoker { get; set; }
        // New properties
        public double CholesterolLevel { get; set; }
        public int SystolicBloodPressure { get; set; }
        public int DiastolicBloodPressure { get; set; }
        public bool HasFamilyHistoryOfHeartDisease { get; set; }
    }
}
