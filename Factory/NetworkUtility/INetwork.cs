namespace DesignPatterns.NetworkUtility;

public interface INetwork
{
    void sendMessage(string ip, int count);
}