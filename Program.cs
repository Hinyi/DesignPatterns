// See https://aka.ms/new-console-template for more information

using DesignPatterns.NetworkFactory;
using DesignPatterns.NetworkUtility;
using DesignPatterns.Singleton;

Console.WriteLine("Hello, World!");

//Singleton

Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Oks");
}


//Factory
NetworkFacory factory = new NetworkFacory();

var ping = factory.GetNetworkInstance("ping");
var dns = factory.GetNetworkInstance("dns");

ping.sendMessage("123.123.123",4);
dns.sendMessage("123.123.123",4);