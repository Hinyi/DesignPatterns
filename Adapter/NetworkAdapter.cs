using DesignPatterns.Adapter.DataProccessor;
using DesignPatterns.Adapter.Network;

namespace DesignPatterns.Adapter;

public class NetworkAdapter : INetworkClient
{
    private readonly IDataProcessor _dataProcessor;

    public NetworkAdapter(IDataProcessor dataProcessor)
    {
        _dataProcessor = dataProcessor;
    }

    public void SendRequest(string ipAddress)
    {
        var apiKey = "sadasdasdassa";
        _dataProcessor.SendNetworkRequest(ipAddress, apiKey);
    }
}