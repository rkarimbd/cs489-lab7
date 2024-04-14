using DSMS.Models;

namespace DSMS.Services
{
    public interface IAddressService
    {
        Task<List<Address>> GetAllAddressesSortedByCityAsync();
        Task<List<AddressPatientViewModel>> GetAllAddressesWithPatientSortedByCityAsync();
    }
}
