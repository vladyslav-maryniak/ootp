using AdapterAndDecoratorExample.Maryniak.Models;
using FileStream = AdapterAndDecoratorExample.Maryniak.Models.FileStream;

namespace AdapterAndDecoratorExample.Maryniak;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Decorator Pattern:");
        
        IDataStream fileStream = new FileStream();
        IDataStream encryptedStream = new EncryptedStream(fileStream);
        IDataStream compressedStream = new CompressedStream(encryptedStream);

        compressedStream.Write("Decorator Pattern");
        Console.WriteLine($"Decrypted and decompressed data: {compressedStream.Read()}");

        Console.WriteLine("\nAdapter Pattern:");

        IThirdPartyStream thirdPartyService = new ThirdPartyStream();
        IDataStream thirdPartyAdapter = new ThirdPartyStreamAdapter(thirdPartyService);
        
        thirdPartyAdapter.Write("Adapter Pattern");
        Console.WriteLine($"Data from third-party service: {thirdPartyAdapter.Read()}");
    }
}
