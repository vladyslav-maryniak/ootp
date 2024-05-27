using FactoryMethodExample.Maryniak.Models;

namespace FactoryMethodExample.Maryniak.Domain;

public class WordApplication : Application
{
    public override Document CreateDocument() => new WordDocument();
}
