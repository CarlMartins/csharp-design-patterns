using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.Fly;

public class NoFlyBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I can not fly at all...");
    }
}