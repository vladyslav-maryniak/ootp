namespace TemplateMethodExample.Maryniak.Models;

public class XmlDataProcessor : DataProcessor
{
    protected override void ReadData()
        => Console.WriteLine("Reading data from XML file...");

    protected override void ProcessDataDetails()
        => Console.WriteLine("Processing data from XML file...");

    protected override void WriteData()
        => Console.WriteLine("Writing processed data to XML file...");
}
