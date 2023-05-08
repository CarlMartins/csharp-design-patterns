using StrategyPattern.Behaviors.Interfaces;

namespace StrategyPattern.Ducks;

public class WildDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("I am a Wild Duck!!");
    }

    public WildDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior) 
        : base(flyBehavior, quackBehavior)
    { }
}