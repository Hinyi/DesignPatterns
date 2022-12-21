namespace DesignPatterns.ChainOfResponsibility;

public class SendSHH : IChain
{
    private IChain next;

    public void SendRequest(NetworkModel request)
    {
        if (request.Success is false)
        {
            Console.WriteLine("SHH failed");
            next.SendRequest(request);
        }
        else
        {
            Console.WriteLine("SSH success");
        }
    }

    public void SetNext(IChain nextChain)
    {
        next = nextChain;
    }
}