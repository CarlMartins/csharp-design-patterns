using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Behaviors.Quack;

public class LouderQuackBehavior : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("QUACK!! QUACK!!");
    }
}