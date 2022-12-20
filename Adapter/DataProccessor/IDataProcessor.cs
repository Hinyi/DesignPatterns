namespace DesignPatterns.Adapter.DataProccessor;

public interface IDataProcessor
{
    bool DataProcess();
    void SendNetworkRequest(string ip, string apiKey);
}