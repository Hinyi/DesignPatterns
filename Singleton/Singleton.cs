namespace DesignPatterns.Singleton;

public class Singleton
{
    protected Singleton()
    {
    }

    private static Singleton _instance;

    public string color { get; set; } = "blue";

    public static Singleton GetInstance()
    {
        if (_instance is null) _instance = new Singleton();

        return _instance;
    }
}