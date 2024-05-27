namespace TemplateMethodExample.Maryniak.Models;

public class CsvDataProcessor : DataProcessor
{
    protected override void ReadData()
        => Console.WriteLine("Reading data from CSV file...");

    protected override void ProcessDataDetails()
        => Console.WriteLine("Processing data from CSV file...");

    protected override void WriteData()
        => Console.WriteLine("Writing processed data to CSV file...");
}
