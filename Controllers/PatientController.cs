using Microsoft.AspNetCore.Mvc;
using PatientRiskAnalytics.Data;
using PatientRiskAnalytics.Interfaces;
using PatientRiskAnalytics.Models;

namespace PatientRiskAnalytics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private readonly PatientContext _context;
        private readonly IRiskAssessmentService _riskService;

        public PatientController(PatientContext context, IRiskAssessmentService riskService)
        {
            _context = context;
            _riskService = riskService;
        }

        [HttpPost]
        public async Task<ActionResult<Patient>> CreatePatient(Patient patient)
        {
            _context.Patients.Add(patient);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPatient), new { id = patient.Id }, patient);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Patient>> GetPatient(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return patient;
        }

        [HttpGet("{id}/risk")]
        public async Task<ActionResult<double>> GetPatientRisk(int id)
        {
            var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return _riskService.AssessRisk(patient);
        }
    }
}
