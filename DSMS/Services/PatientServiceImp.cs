using DSMS.Models;
using DSMS.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSMS.Services
{
    public class PatientServiceImp : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientServiceImp(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsSortedByLastNameAsync()
        {
            var patients = await _patientRepository.GetAllPatientsAsync();
            return patients.OrderBy(p => p.LastName);
        }

        public async Task<Patient> GetPatientByIdAsync(int id)
        {
            return await _patientRepository.GetPatientByIdAsync(id);
        }

        public async Task RegisterPatientAsync(Patient patient)
        {
            await _patientRepository.AddPatientAsync(patient);
        }

        public async Task UpdatePatientAsync(int id, Patient patient)
        {
            var existingPatient = await _patientRepository.GetPatientByIdAsync(id);
            if (existingPatient != null)
            {
                patient.PatientId = id;
                await _patientRepository.UpdatePatientAsync(patient);
            }
        }

        public async Task DeletePatientAsync(int id)
        {
            await _patientRepository.DeletePatientAsync(id);
        }

        public async Task<IEnumerable<Patient>> SearchPatientsAsync(string searchString)
        {
            return await _patientRepository.SearchPatientsAsync(searchString);
        }
    }
}
