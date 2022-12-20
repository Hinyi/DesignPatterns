namespace DesignPatterns.Facade;

public class Packet
{
    public int Id { get; set; }
    public string IP { get; set; }
    public string Data { get; set; }
    public Packet(string ip)
    {
        this.IP = ip;
    }

    public void BuiltPacket()
    {
        Console.WriteLine("Packet is created");
    }
}