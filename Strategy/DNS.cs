namespace DesignPatterns.Strategy;

public class DNS : IStrategy
{
    public void Execute()
    {
        Console.WriteLine("This is DNS");
    }
}