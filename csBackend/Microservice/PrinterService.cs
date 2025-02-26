using System;

namespace csbackend.Microservice;

public class PrinterService
{
    public Printer[] getPrinters()
    {
        var printers = new List<Printer>();
        return File.ReadAllLines("csv/printer.csv")
            .Select(x => x.Split(';'))
            .Select(x => new Printer
            {
                PrinterId = int.Parse(x[0]),
                MaschinenName = x[1],
                MaschinenFormatL = int.Parse(x[2]),
                MaschinenFormatB = int.Parse(x[3]),
                FarbFormat = x[4],
                UnbedruckbarerRand = int.Parse(x[5]),
                inaktiv = int.Parse(x[6])
            })
            .ToArray();
    }

    public Printer addPrinter(Printer printer)
    {
        File.AppendAllText("csv/printer.csv", printer.ToString());
        return printer;
    }

    internal void deletePrinter(int id)
    {
        var lines = File.ReadAllLines("csv/printer.csv").ToList();
        lines.RemoveAt(id - 1);
        File.WriteAllLines("csv/printer.csv", lines);
    }

    internal void updatePrinter(int id, Printer printer)
    {
        var lines = File.ReadAllLines("csv/printer.csv").ToList();
        lines[id - 1] = printer.ToString();
        File.WriteAllLines("csv/printer.csv", lines);
    }
}
