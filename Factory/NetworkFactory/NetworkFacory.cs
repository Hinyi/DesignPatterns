using DesignPatterns.NetworkUtility;

namespace DesignPatterns.NetworkFactory;

public class NetworkFacory
{
    public INetwork GetNetworkInstance(string instance)
    {
        INetwork obj = null;
        if (instance.ToLower().Equals("ping"))
        {
            obj = new Ping();
        }
        else if (instance.ToLower().Equals("dns"))
        {
            obj = new DNS();
        }

        return obj;
    }
}