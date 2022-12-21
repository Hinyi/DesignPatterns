using DesignPatterns.AbstractFactory.Products.Combi;
using DesignPatterns.AbstractFactory.Products.Sedan;

namespace DesignPatterns.AbstractFactory.Factories;

public class AudiFactory : ICarFactory
{
    public ICombiCar orderCombiCar()
    {
        ICombiCar obj = null;
        obj = new AudiCar();

        return obj;
    }

    public ISedanCar orderSedanCar()
    {
        ISedanCar obj = new AudiSedan();
        return obj;
    }
}