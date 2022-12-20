namespace DesignPatterns.Facade;

public class NetworkFacade
{
    private Packet _packet;
    private Socket _socket;
    private Transmission _transmission;

    public NetworkFacade(string ip, string protocol, int port)
    {
        this._packet = new Packet(ip);
        this._socket = new Socket(port);
        this._transmission = new Transmission(protocol);
    }

    public void BuiltNetworklayer()
    {
        _packet.BuiltPacket();
        _socket.SocketBuilt();
    }

    public void SendPackerOverNetwork()
    {
        BuiltNetworklayer();
        _transmission.SendTransmission();
    }
}