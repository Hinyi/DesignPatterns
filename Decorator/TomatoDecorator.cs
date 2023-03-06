namespace DesignPatterns.Decorator;

public class TomatoDecorator : PizzaDecorator
{
    public TomatoDecorator(IPizza pizza) : base(pizza)
    {
    }
    
    public override string GetPizzaType()
    {
        string type = base.GetPizzaType();
        type += "\r\n with extra tomatoes";
        return type;
    }
}