using PrototypeExample.Maryniak.Models;

namespace PrototypeExample.Maryniak;

internal class Program
{
    static void Main()
    {
        var originalInvoice = new Invoice("Invoice #1", DateTime.Now, 1000.00m, "Customer A");
        var originalReport = new Report("Q1 Report", DateTime.Now, "Report Content", "Author A");

        var clonedInvoice = (Invoice)originalInvoice.Clone();
        var clonedReport = (Report)originalReport.Clone();

        clonedInvoice.Title = "Invoice #2";
        clonedInvoice.Amount = 1500.00m;
        clonedInvoice.Customer = "Customer B";

        clonedReport.Title = "Q2 Report";
        clonedReport.Content = "Updated Report Content";
        clonedReport.Author = "Author B";

        Console.WriteLine("Original Documents:");
        originalInvoice.Print();
        originalReport.Print();

        Console.WriteLine("\nCloned Documents:");
        clonedInvoice.Print();
        clonedReport.Print();
    }
}
