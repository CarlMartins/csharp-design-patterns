using StrategyPattern.Behaviors.Fly;
using StrategyPattern.Behaviors.Quack;

namespace StrategyPattern.Ducks;

public class CityDuck : Duck
{
    public CityDuck()
    {
        FlyBehavior = new DefaultFlyBehavior();
        QuackBehavior = new DefaultQuackBehavior();
    }

    public override void Display()
    {
        Console.WriteLine("I'm a City Duck!");
    }
}