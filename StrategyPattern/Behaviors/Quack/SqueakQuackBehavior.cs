using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.Quack;

public class SqueakQuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeak!");
    }
}