using csbackend.Microservice;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace csbackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {

        private readonly ILogger<PrinterController> _logger;
        private CustomerService _customerService;
        public CustomerController(ILogger<PrinterController> logger)
        {
            _logger = logger;
            _customerService = new CustomerService();
        }

        [HttpGet(Name = "Customer")]
        public IEnumerable<Customer> Get()
        {
            return _customerService.getCustomers();
        }

        [HttpPost(Name = "Customer")]
        public Customer Post(Customer customer)
        {
            return _customerService.addCustomer(customer);
        }
    }
}
