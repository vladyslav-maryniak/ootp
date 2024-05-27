namespace AdapterAndDecoratorExample.Maryniak.Models;

public class EncryptedStream(IDataStream dataStream) : DataStreamDecorator(dataStream)
{
    public override void Write(string data)
    {
        string encryptedData = Encrypt(data);
        base.Write(encryptedData);
    }

    public override string Read()
    {
        string encryptedData = base.Read();
        return Decrypt(encryptedData);
    }

    private static string Encrypt(string data)
        => $"ENCRYPTED({data})";

    private static string Decrypt(string encryptedData)
        => encryptedData.Replace("ENCRYPTED(", "").Replace(")", "");
}
