using DSMS.Services;
using Microsoft.AspNetCore.Mvc;

namespace DSMS.Controllers
{
    [ApiController]
    [Route("adsweb/api/v1/address")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet("list")]
        public async Task<IActionResult> GetAllAddresses()
        {
            try
            {
                var addresses = await _addressService.GetAllAddressesSortedByCityAsync();
                return Ok(addresses);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpGet("/patient/list")]
        public async Task<IActionResult> GetAllAddressesWithPatient()
        {
            try
            {
                var addresses = await _addressService.GetAllAddressesWithPatientSortedByCityAsync();
                return Ok(addresses);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }
    }

}
