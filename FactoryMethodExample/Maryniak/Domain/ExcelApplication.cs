using FactoryMethodExample.Maryniak.Models;

namespace FactoryMethodExample.Maryniak.Domain;

public class ExcelApplication : Application
{
    public override Document CreateDocument() => new ExcelDocument();
}
