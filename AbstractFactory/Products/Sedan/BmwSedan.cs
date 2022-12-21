using DesignPatterns.AbstractFactory.Products.Combi;

namespace DesignPatterns.AbstractFactory.Products.Sedan;

public class BmwSedan : ISedanCar
{
    public void OrderCar()
    {
        Console.WriteLine("Order bmw sedan");
    }

    public void OrderCarMixed(ICombiCar car)
    {
        car.OrderCar();
        Console.WriteLine("Bmw sedan");
    }
}