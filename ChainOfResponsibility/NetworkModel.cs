namespace DesignPatterns.ChainOfResponsibility;

public class NetworkModel
{
    public string ip { get; set; }
    public bool Success { get; set; }

    public NetworkModel(string ip, bool success)
    {
        this.ip = ip;
        this.Success = success;
    }
}