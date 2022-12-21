using DesignPatterns.AbstractFactory.Factories;

namespace DesignPatterns.AbstractFactory;

public class Client_test
{
    public void test()
    {
        ClientMethod(new AudiFactory());
        ClientMethod(new BmwFactory());
    }

    public void ClientMethod(ICarFactory carFactory)
    {
        var combiCar = carFactory.orderCombiCar();
        var sedanCar = carFactory.orderSedanCar();
        combiCar.OrderCar();
        sedanCar.OrderCarMixed(combiCar);
        
    }
}