// See https://aka.ms/new-console-template for more information

using DesignPatterns.Facade;
using DesignPatterns.NetworkFactory;
using DesignPatterns.NetworkUtility;
using DesignPatterns.Singleton;

Console.WriteLine("Hello, World!");

//Facade
NetworkFacade networkFacade = new NetworkFacade("1.1.1.1", "tcp/ip", 8080);

networkFacade.SendPackerOverNetwork();

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