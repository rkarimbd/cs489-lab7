using DSMS.Models;

namespace DSMS.Repositories
{
    public interface IAddressRepository
    {
        Task<List<Address>> GetAllAddressesSortedByCityAsync();

        Task<List<AddressPatientViewModel>> GetAllAddressesWithPatientSortedByCityAsync();
    }
}
