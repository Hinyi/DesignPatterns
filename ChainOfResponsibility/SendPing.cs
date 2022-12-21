namespace DesignPatterns.ChainOfResponsibility;

public class SendPing : IChain
{
    private IChain next;

    public void SendRequest(NetworkModel request)
    {
        if (request.Success is false)
        {
            Console.WriteLine("Ping failed");
            next.SendRequest(request);
        }
        else
        {
            Console.WriteLine("Ping success");
        }
    }

    public void SetNext(IChain nextChain)
    {
        next = nextChain;
    }
}