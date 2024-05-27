namespace AdapterAndDecoratorExample.Maryniak.Models;

public class ThirdPartyStreamAdapter(IThirdPartyStream thirdPartyStream) : IDataStream
{
    public void Write(string data) => thirdPartyStream.SendData(data.ToUpper());

    public string Read() => thirdPartyStream.ReceiveData().ToLower();
}
