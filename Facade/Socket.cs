namespace DesignPatterns.Facade;

public class Socket
{
    public int Id { get; set; }
    public int Port { get; set; }
    public string IP { get; set; }

    public Socket(int port)
    {
        Port = port;
    }

    public void SocketBuilt()
    {
        Console.WriteLine("Socket created successfully");
    }
}