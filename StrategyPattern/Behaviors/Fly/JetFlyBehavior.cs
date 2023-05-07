using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.Fly;

public class JetFlyBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I'm flying like a jet!");
    }
}