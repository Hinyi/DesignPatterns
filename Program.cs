// See https://aka.ms/new-console-template for more information

using DesignPatterns.NetworkFactory;
using DesignPatterns.NetworkUtility;

Console.WriteLine("Hello, World!");

NetworkFacory factory = new NetworkFacory();

var ping = factory.GetNetworkInstance("ping");
var dns = factory.GetNetworkInstance("dns");

ping.sendMessage("123.123.123",4);
dns.sendMessage("123.123.123",4);