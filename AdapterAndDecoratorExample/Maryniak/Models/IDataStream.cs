namespace AdapterAndDecoratorExample.Maryniak.Models;

public interface IDataStream
{
    void Write(string data);
    string Read();
}
