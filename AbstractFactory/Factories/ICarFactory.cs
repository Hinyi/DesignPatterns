using DesignPatterns.AbstractFactory.Products.Combi;
using DesignPatterns.AbstractFactory.Products.Sedan;

namespace DesignPatterns.AbstractFactory.Factories;

public interface ICarFactory
{
    ICombiCar orderCombiCar();
    ISedanCar orderSedanCar();
}