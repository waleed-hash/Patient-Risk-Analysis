using PatientRiskAnalytics.Models;

namespace PatientRiskAnalytics.Interfaces
{
    public interface IRiskAssessmentService
    {
        double AssessRisk(Patient patient);
    }
}