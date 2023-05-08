using Helpers;
using StrategyPattern.Behaviors.Fly;
using StrategyPattern.Behaviors.Quack;
using StrategyPattern.Ducks;

var cityDuck = new CityDuck(new DefaultFlyBehavior(), new DefaultQuackBehavior());

cityDuck.Display();
cityDuck.Fly();
cityDuck.Quack();

Divider.Divide();

var wildDuck = new WildDuck(new JetFlyBehavior(), new LouderQuackBehavior());

wildDuck.Display();
wildDuck.Fly();
wildDuck.Quack();
wildDuck.FlyBehavior = new DefaultFlyBehavior();
wildDuck.Fly();

Divider.Divide();

var rubberDuck = new RubberDuck(new NoFlyBehavior(), new SqueakQuackBehavior());

rubberDuck.Display();
rubberDuck.Fly();
rubberDuck.Quack();
