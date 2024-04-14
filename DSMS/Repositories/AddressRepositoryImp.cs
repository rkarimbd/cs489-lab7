using DSMS.Context;
using DSMS.Models;
using Microsoft.EntityFrameworkCore;

namespace DSMS.Repositories
{
    public class AddressRepositoryImp: IAddressRepository
    {
       
            private readonly ApplicationDbContext _context;

            public AddressRepositoryImp(ApplicationDbContext context)
            {
                _context = context;
            }

            public async Task<List<Address>> GetAllAddressesSortedByCityAsync()
            {

            var addresses = await _context.Addresses
                .OrderBy(a => a.City)    // Sort addresses by city in ascending order
                .ToListAsync();

            return addresses;



        }

        public async Task<List<AddressPatientViewModel>> GetAllAddressesWithPatientSortedByCityAsync()
        {

            // Define the SQL query to call the stored procedure
            string sqlQuery = "EXEC dbo.GetAllAddressesSortedByCity";

            // Execute the raw SQL query and map the results to Address entities
            var addresses = await _context.addressPatientViewModels
                .FromSqlRaw(sqlQuery)
                .ToListAsync();

            return addresses;

        }
    }

    }
