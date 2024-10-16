using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppSample3DI.Interfaces;

namespace WebAppSample3DI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("notify-customer")]
        public IActionResult NotifyCustomer()
        {
            return Ok(_customerService.NotifyCustomer());
        }
    }
}
