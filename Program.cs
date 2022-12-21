// See https://aka.ms/new-console-template for more information

using DesignPatterns.AbstractFactory;
using DesignPatterns.Adapter;
using DesignPatterns.Adapter.DataProccessor;
using DesignPatterns.Adapter.Network;
using DesignPatterns.Builder;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Facade;
using DesignPatterns.NetworkFactory;
using DesignPatterns.NetworkUtility;
using DesignPatterns.Proxy;
using DesignPatterns.Singleton;
using DesignPatterns.Strategy;
using DesignPatterns.AbstractFactory;
using ARP = DesignPatterns.Strategy.ARP;
using DNS = DesignPatterns.Strategy.DNS;
using Ping = DesignPatterns.Strategy.Ping;

Console.WriteLine("Hello, World!");
//Abstract class
new Client_test().test();

//Builder
var builder = new WoodenBuilder();
var builder2 = new ConcreteBuilder();
var director = new Director(builder);
var director2 = new Director(builder2);

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());

Console.WriteLine("Standard full featured product:");
director2.BuildFullFeaturedProduct();
Console.WriteLine(builder2.GetProduct().ListParts());

// Remember, the Builder pattern can be used without a Director
// class.
Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.Write(builder.GetProduct().ListParts());

//Strategy
var context = new Context(new Ping());
var context2 = new Context(new ARP());
var context3 = new Context(new DNS());

context.ExecuteStrategy();
context2.ExecuteStrategy();
context3.ExecuteStrategy();

//Proxy
ISuperSecretDatabase result = new SuperSecretDatabaseProxy("testdb", "Password");
result.DisplayDatabaseName();

//Chain of responsibility
IChain obj1 = new SendSHH();
IChain obj2 = new SendPing();
IChain obj3 = new SendARP();

obj1.SetNext(obj2);
obj2.SetNext(obj3);

var request = new NetworkModel("1.1.1.1", false);
obj1.SendRequest(request);


//Adapter
INetworkClient network = new NetworkClient();
network.SendRequest("1.1.1.1");

IDataProcessor dataProcessor = new DataProcessor();
dataProcessor.SendNetworkRequest("1.2.3.4", "123adfs123");

var adapter = new NetworkAdapter(dataProcessor);
adapter.SendRequest("2.2.2.2");

//Facade
var networkFacade = new NetworkFacade("1.1.1.1", "tcp/ip", 8080);

networkFacade.SendPackerOverNetwork();

//Singleton
var s1 = Singleton.GetInstance();
var s2 = Singleton.GetInstance();

if (s1 == s2) Console.WriteLine("Oks");

//Factory
var factory = new NetworkFacory();

var ping = factory.GetNetworkInstance("ping");
var dns = factory.GetNetworkInstance("dns");

ping.sendMessage("123.123.123", 4);
dns.sendMessage("123.123.123", 4);