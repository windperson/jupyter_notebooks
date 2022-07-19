using Orleans;

namespace HelloWorld.Interfaces;
public interface IHelloGrain : IGrainWithStringKey
{
    Task<string> SayHello(string greeting);
}