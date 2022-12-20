namespace DesignPatterns.Adapter.Network;

public interface INetworkClient
{
    void SendRequest(string ipAddress);
}