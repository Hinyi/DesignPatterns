namespace DesignPatterns.Strategy;

public class Ping : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("This is Ping");
    }
}