using DSMS.Models;
using DSMS.Repositories;

namespace DSMS.Services
{
       public class AddressServiceImp : IAddressService
        {
            private readonly IAddressRepository _addressRepository;

            public AddressServiceImp(IAddressRepository addressRepository)
            {
                _addressRepository = addressRepository;
            }

            public async Task<List<Address>> GetAllAddressesSortedByCityAsync()
            {
                return await _addressRepository.GetAllAddressesSortedByCityAsync();
            }

        public async Task<List<AddressPatientViewModel>> GetAllAddressesWithPatientSortedByCityAsync()
        {
            return await _addressRepository.GetAllAddressesWithPatientSortedByCityAsync();
        }
    }
    }
