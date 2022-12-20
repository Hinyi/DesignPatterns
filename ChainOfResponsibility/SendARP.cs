namespace DesignPatterns.ChainOfResponsibility;

public class SendARP : IChain
{
    private IChain next;
    public void SendRequest(NetworkModel request)
    {
        if (request.Success is false)
        {
            Console.WriteLine("ARP failed");
            if (next != null)
            {
                next.SendRequest(request);
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
        else
        {
            Console.WriteLine("ARP success");
        }
    }

    public void SetNext(IChain nextChain)
    {
        
    }
}