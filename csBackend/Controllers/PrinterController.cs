using csBackend.Microservice;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace csBackend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrinterController : ControllerBase
    {

        private readonly ILogger<PrinterController> _logger;
        private PrinterService _printerService;
        private CustomerService _customerService;
        public PrinterController(ILogger<PrinterController> logger)
        {
            _logger = logger;
            _printerService = new PrinterService();
            _customerService = new CustomerService();
        }

        [HttpGet(Name = "Printer")]
        public IEnumerable<Printer> GetPrinter()
        {
            return _printerService.getPrinters();
        }

        [HttpPost(Name = "Printer")]
        public Printer PostPrinter(Printer printer)
        {
            return _printerService.addPrinter(printer);
        }

        [HttpGet(Name = "Customer")]
        public IEnumerable<Customer> GetCustomer()
        {
            return _customerService.getCustomers();
        }

        [HttpPost(Name = "Customer")]
        public Customer PostCustomer(Customer customer)
        {
            return _customerService.addCustomer(customer);
        }
    }
}
