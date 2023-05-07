namespace StrategyPattern.Ducks;

public class RubberDuck : Duck
{
    public override void Display()
    {
        Console.WriteLine("I am a Rubber Duck.");
    }
}