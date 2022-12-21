using DesignPatterns.AbstractFactory.Products.Combi;
using DesignPatterns.AbstractFactory.Products.Sedan;

namespace DesignPatterns.AbstractFactory.Factories;

public class BmwFactory : ICarFactory
{
    public ICombiCar orderCombiCar()
    {
        ICombiCar obj = new BmwCar();
        return obj;
    }

    public ISedanCar orderSedanCar()
    {
        ISedanCar obj = new BmwSedan();
        return obj;
    }
}