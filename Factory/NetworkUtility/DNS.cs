namespace DesignPatterns.NetworkUtility;

public class DNS : INetwork
{
    public void sendMessage(string ip, int count)
    {
        Console.WriteLine("DNS send message to" + ip + "times" + count);
    }
}