using TemplateMethodExample.Maryniak.Models;

namespace TemplateMethodExample.Maryniak;

internal class Program
{
    static void Main()
    {
        // Create data processors
        DataProcessor csvProcessor = new CsvDataProcessor();
        DataProcessor xmlProcessor = new XmlDataProcessor();

        // Process data
        Console.WriteLine("Processing CSV Data:");
        csvProcessor.ProcessData(); // Template method call for CSV

        Console.WriteLine("\nProcessing XML Data:");
        xmlProcessor.ProcessData(); // Template method call for XML
    }
}
