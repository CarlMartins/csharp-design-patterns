using StrategyPattern.Behaviors.Fly;
using StrategyPattern.Behaviors.Interfaces;
using StrategyPattern.Behaviors.Quack;

namespace StrategyPattern.Ducks;

public class CityDuck : Duck
{
    public CityDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) 
        : base(flyBehavior, quackBehavior)
    { }

    public override void Display()
    {
        Console.WriteLine("I'm a City Duck!");
    }
}