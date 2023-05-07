// See https://aka.ms/new-console-template for more information

using Helpers;
using StrategyPattern.Behaviors.Fly;
using StrategyPattern.Behaviors.Quack;
using StrategyPattern.Ducks;

var cityDuck = new CityDuck
{
    FlyBehavior = new DefaultFlyBehavior(),
    QuackBehavior = new DefaultQuackBehavior()
};

cityDuck.Display();
cityDuck.Fly();
cityDuck.Quack();

Divider.Divide();

var wildDuck = new WildDuck
{
    FlyBehavior = new JetFlyBehavior(),
    QuackBehavior = new LouderQuackBehavior()
};

wildDuck.Display();
wildDuck.Fly();
wildDuck.Quack();
wildDuck.FlyBehavior = new DefaultFlyBehavior();
wildDuck.Fly();

Divider.Divide();

var rubberDuck = new RubberDuck
{
    FlyBehavior = new NoFlyBehavior(),
    QuackBehavior = new SqueakQuackBehavior()
};

rubberDuck.Display();
rubberDuck.Fly();
rubberDuck.Quack();
