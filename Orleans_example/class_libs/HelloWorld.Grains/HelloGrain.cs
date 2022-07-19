using Orleans;
using Orleans.Runtime;

using HelloWorld.Interfaces;

namespace HelloWorld.Grains;
public class HelloGrain : Grain, IHelloGrain
{
    public Task<string> SayHello(string greeting) => Task.FromResult($"Hello, {greeting}!");
}