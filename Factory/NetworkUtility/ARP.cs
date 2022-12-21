namespace DesignPatterns.NetworkUtility;

public class ARP : INetwork
{
    public void sendMessage(string ip, int count)
    {
        Console.WriteLine("Arp send message to" + ip + "times" + count);
    }
}