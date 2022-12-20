namespace DesignPatterns.NetworkUtility;

public class Ping : INetwork
{
    public void sendMessage(string ip, int count)
    {
         Console.WriteLine("Ping send message to"+ ip + "times" + count);
    }
}