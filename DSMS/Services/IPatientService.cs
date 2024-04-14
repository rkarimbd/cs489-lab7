using DSMS.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DSMS.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetAllPatientsSortedByLastNameAsync();
        Task<Patient> GetPatientByIdAsync(int id);
        Task RegisterPatientAsync(Patient patient);
        Task UpdatePatientAsync(int id, Patient patient);
        Task DeletePatientAsync(int id);
        Task<IEnumerable<Patient>> SearchPatientsAsync(string searchString);
    }
}
