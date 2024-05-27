namespace AdapterAndDecoratorExample.Maryniak.Models;

public class ThirdPartyStream : IThirdPartyStream
{
    private string data = string.Empty;

    public void SendData(string data)
    {
        this.data = data;
        Console.WriteLine($"Sending data to third-party service: {data}");
    }

    public string ReceiveData()
    {
        Console.WriteLine($"Receiving data from third-party service: {data}");
        return data;
    }
}
