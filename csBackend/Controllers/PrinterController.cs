using csbackend.Microservice;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace csbackend.Controllers
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

        [HttpGet("/Printer")]
        public IEnumerable<Printer> Get()
        {
            return _printerService.getPrinters();
        }

        [HttpPost("/Printer")]
        public Printer Post(Printer printer)
        {
            return _printerService.addPrinter(printer);
        }

        [HttpDelete("/Printer/{id}")]
        public void Delete(int id)
        {
            _printerService.deletePrinter(id);
        }

        [HttpPut("/Printer/{id}")]
        public void Put(int id, [FromBody] Printer printer)
        {
            _printerService.updatePrinter(id, printer);
        }
    }
}
