using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.Fly;

public class DefaultFlyBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I am just flying.");
    }
}