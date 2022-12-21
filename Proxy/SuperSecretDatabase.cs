namespace DesignPatterns.Proxy;

public class SuperSecretDatabase : ISuperSecretDatabase
{
    private string _databaseName;

    public SuperSecretDatabase(string databaseName)
    {
        _databaseName = databaseName;
    }

    public void DisplayDatabaseName()
    {
        Console.WriteLine("Display database name: " + _databaseName);
    }
}