using FactoryMethodExample.Maryniak.Models;

namespace FactoryMethodExample.Maryniak.Domain;

public abstract class Application
{
    public abstract Document CreateDocument();

    public void OpenDocument()
    {
        Document doc = CreateDocument();
        doc.Open();
    }
}
