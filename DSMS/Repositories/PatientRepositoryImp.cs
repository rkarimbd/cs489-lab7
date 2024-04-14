using DSMS.Context;
using DSMS.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DSMS.Repositories
{
    public class PatientRepositoryImp : IPatientRepository
    {
        private readonly ApplicationDbContext _context;

        public PatientRepositoryImp(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Patient>> GetAllPatientsAsync()
        {
            return await _context.Patients.Include(p => p.Address).ToListAsync();
        }

        public async Task<Patient> GetPatientByIdAsync(int id)
        {
            return await _context.Patients.Include(p => p.Address).FirstOrDefaultAsync(p => p.PatientId == id);
        }

        public async Task AddPatientAsync(Patient patient)
        {
            await _context.Patients.AddAsync(patient);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            _context.Patients.Update(patient);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePatientAsync(int id)
        {
            var patientToDelete = await _context.Patients.FindAsync(id);
            if (patientToDelete != null)
            {
                _context.Patients.Remove(patientToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Patient>> SearchPatientsAsync(string searchString)
        {
            return await _context.Patients
                .Include(p => p.Address)
                .Where(p => p.FirstName.Contains(searchString) || p.LastName.Contains(searchString))
                .ToListAsync();
        }
    }
}
