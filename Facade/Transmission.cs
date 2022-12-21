namespace DesignPatterns.Facade;

public class Transmission
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Transmission(string protocolName)
    {
        Name = protocolName;
    }

    public void SendTransmission()
    {
        Console.WriteLine("Transimissiob sent successfully!");
    }
}