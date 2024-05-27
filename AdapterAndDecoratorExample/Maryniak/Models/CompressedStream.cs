namespace AdapterAndDecoratorExample.Maryniak.Models;

public class CompressedStream(IDataStream dataStream) : DataStreamDecorator(dataStream)
{
    public override void Write(string data)
    {
        string compressedData = Compress(data);
        base.Write(compressedData);
    }

    public override string Read()
    {
        string compressedData = base.Read();
        return Decompress(compressedData);
    }

    private static string Compress(string data)
        => $"COMPRESSED({data})";

    private static string Decompress(string compressedData)
        => compressedData.Replace("COMPRESSED(", "").Replace(")", "");
}
