namespace AdapterAndDecoratorExample.Maryniak.Models;

public interface IThirdPartyStream
{
    void SendData(string data);
    string ReceiveData();
}
