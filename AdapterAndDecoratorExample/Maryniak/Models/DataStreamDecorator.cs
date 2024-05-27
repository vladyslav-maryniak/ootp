namespace AdapterAndDecoratorExample.Maryniak.Models;

public abstract class DataStreamDecorator(IDataStream dataStream) : IDataStream
{
    public virtual void Write(string data) => dataStream.Write(data);

    public virtual string Read() => dataStream.Read();
}
