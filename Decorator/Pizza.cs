namespace DesignPatterns.Decorator;

public class Pizza : IPizza
{
    public string GetPizzaType()
    {
        return "This is normal pizza";
    }
}