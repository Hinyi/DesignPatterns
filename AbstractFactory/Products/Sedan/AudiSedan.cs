using DesignPatterns.AbstractFactory.Products.Combi;

namespace DesignPatterns.AbstractFactory.Products.Sedan;

public class AudiSedan : ISedanCar
{
    public void OrderCar()
    {
        Console.WriteLine("Order audi sedan");
    }

    public void OrderCarMixed(ICombiCar car)
    {
        car.OrderCar();
        Console.WriteLine("Audi sedan");
    }
}