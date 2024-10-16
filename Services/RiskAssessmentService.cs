using PatientRiskAnalytics.Interfaces;
using PatientRiskAnalytics.Models;

namespace PatientRiskAnalytics.Services
{
    public class RiskAssessmentService : IRiskAssessmentService
    {
        public double AssessRisk(Patient patient)
        {
            double baseRisk = 0.05; // 5% base risk

            // Age risk
            if (patient.Age > 60) baseRisk += 0.05;
            else if (patient.Age > 40) baseRisk += 0.03;

            // BMI risk
            if (patient.BMI > 30) baseRisk += 0.03;
            else if (patient.BMI > 25) baseRisk += 0.01;

            // Existing conditions
            if (patient.HasDiabetes) baseRisk += 0.05;
            if (patient.HasHypertension) baseRisk += 0.05;
            if (patient.IsSmoker) baseRisk += 0.05;

            // New risk factors
            if (patient.CholesterolLevel > 240) baseRisk += 0.04;
            else if (patient.CholesterolLevel > 200) baseRisk += 0.02;

            if (patient.SystolicBloodPressure > 140 || patient.DiastolicBloodPressure > 90) baseRisk += 0.03;

            if (patient.HasFamilyHistoryOfHeartDisease) baseRisk += 0.02;

            // Round to two decimal places and cap at 100% risk
            return Math.Round(Math.Min(baseRisk, 1.0), 2);
        }
    }
}
