namespace DesignPatterns.Proxy;

public class SuperSecretDatabaseProxy : ISuperSecretDatabase
{
    private readonly string _databaseName;
    private readonly string _password;
    private SuperSecretDatabase _superSecretDatabase;

    public SuperSecretDatabaseProxy(string databaseName, string password)
    {
        _databaseName = databaseName;
        _password = password;
    }

    public void DisplayDatabaseName()
    {
        if (_password.Equals("Password"))
        {
            if (_superSecretDatabase == null) _superSecretDatabase = new SuperSecretDatabase(_databaseName);
            _superSecretDatabase.DisplayDatabaseName();
        }
    }
}