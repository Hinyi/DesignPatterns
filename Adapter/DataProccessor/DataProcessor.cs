namespace DesignPatterns.Adapter.DataProccessor;

public class DataProcessor : IDataProcessor
{
    public bool DataProcess()
    {
        Console.WriteLine("Process data");
        return true;
    }

    public void SendNetworkRequest(string ip, string apiKey)
    {
        Console.WriteLine("Send network request with IP address that requires API KEY: " + ip + "///" + apiKey);
    }
}