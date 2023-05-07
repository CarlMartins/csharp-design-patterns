using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.Fly;

public class SlowerFlyBehavior : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("I am flying really slow...");
    }
}