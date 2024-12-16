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
        public PrinterController(ILogger<PrinterController> logger)
        {
            _logger = logger;
            _printerService = new PrinterService();
        }

        [HttpGet(Name = "Printer")]
        public IEnumerable<Printer> Get()
        {
            return _printerService.getPrinters();
        }

        [HttpPost(Name = "Printer")]
        public Printer Post(Printer printer)
        {
            return _printerService.addPrinter(printer);
        }
    }
}
