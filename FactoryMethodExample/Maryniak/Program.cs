using FactoryMethodExample.Maryniak.Domain;

namespace FactoryMethodExample.Maryniak
{
    internal class Program
    {
        static void Main()
        {
            Application wordApp = new WordApplication();
            wordApp.OpenDocument();

            Application excelApp = new ExcelApplication();
            excelApp.OpenDocument();
        }
    }
}
