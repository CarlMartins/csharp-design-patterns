using StrategyPattern.Behaviors.Fly;
using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Ducks;

public abstract class Duck
{
    public IFlyBehavior FlyBehavior;
    public IQuackBehavior QuackBehavior;

    public abstract void Display();
    
    public void Fly()
    {
        FlyBehavior.Fly();
    }
    
    public void Quack()
    {
        QuackBehavior.Quack();
    }
}