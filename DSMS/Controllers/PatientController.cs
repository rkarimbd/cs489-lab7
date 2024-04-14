using DSMS.Models;
using DSMS.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DSMS.Controllers
{
    [Route("adsweb/api/v1/patient")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _patientService.GetAllPatientsSortedByLastNameAsync();
            return Ok(patients);
        }

        [HttpGet("get/{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var patient = await _patientService.GetPatientByIdAsync(id);
            if (patient == null)
            {
                return NotFound("Patient with ID" + id.ToString()+ "not found");
            }
            return Ok(patient);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterPatient([FromBody] Patient patient)
        {
            await _patientService.RegisterPatientAsync(patient);
            return Ok("Patient registered successfully");
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdatePatient(int id, [FromBody] Patient patient)
        {
            await _patientService.UpdatePatientAsync(id, patient);
            return Ok("Patient updated successfully");
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeletePatient(int id)
        {
            await _patientService.DeletePatientAsync(id);
            return Ok("Patient deleted successfully");
        }

        [HttpGet("search/{searchString}")]
        public async Task<IActionResult> SearchPatients(string searchString)
        {
            var patients = await _patientService.SearchPatientsAsync(searchString);
            return Ok(patients);
        }
    }
}
