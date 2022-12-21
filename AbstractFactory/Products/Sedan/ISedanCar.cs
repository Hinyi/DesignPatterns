using DesignPatterns.AbstractFactory.Products.Combi;

namespace DesignPatterns.AbstractFactory.Products.Sedan;

public interface ISedanCar
{
    void OrderCar();
    void OrderCarMixed(ICombiCar car);
}