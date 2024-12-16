using System;

namespace csBackend.Microservice;

public class PrinterService
{
    public Printer[] getPrinters()
    {
        var printers = new List<Printer>();
        return File.ReadAllLines("csv/printer.csv")
            .Skip(1)
            .Select(x => x.Split(';'))
            .Select(x => new Printer
            {
                PrinterId = int.Parse(x[0]),
                MaschinenName = x[1],
                MaschinenFormatL = int.Parse(x[2]),
                MaschinenFormatB = int.Parse(x[3]),
                FarbFormat = x[4],
                UnbedruckbarerRand = int.Parse(x[5]),
            })
            .ToArray();
    }

    public Printer addPrinter(Printer printer)
    {
        File.AppendAllText("csv/printer.csv", printer.ToString());
        return printer;
    }
}
