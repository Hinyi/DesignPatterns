namespace DesignPatterns.AbstractFactory.Products.Combi;

public class AudiCar : ICombiCar
{
    public void OrderCar()
    {
        Console.WriteLine("Combi Audi is ordered");
    }
}