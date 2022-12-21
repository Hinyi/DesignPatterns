namespace DesignPatterns.AbstractFactory.Products.Combi;

public class BmwCar : ICombiCar
{
    public void OrderCar()
    {
        Console.WriteLine("Combi bmw is ordered");
    }
}