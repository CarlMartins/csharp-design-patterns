using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.Quack;

public class DefaultQuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Quack!");
    }
}