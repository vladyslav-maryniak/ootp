namespace AdapterAndDecoratorExample.Maryniak.Models;

public class FileStream : IDataStream
{
    private string data = string.Empty;

    public void Write(string data)
    {
        this.data = data;
        Console.WriteLine($"Writing data to file: {data}");
    }

    public string Read()
    {
        Console.WriteLine($"Reading data from file: {data}");
        return data;
    }
}
