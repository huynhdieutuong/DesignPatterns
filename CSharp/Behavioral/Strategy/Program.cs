using Strategy.Behaviors;
using Strategy.Ducks;

Duck mallard = new MallardDuck();
mallard.Display();
mallard.PerformFly();
mallard.PerformQuack();

Console.WriteLine("=============");

Duck model = new ModelDuck();
model.Display();
model.PerformFly();
model.SetFlyBehavior(new FlyRocketPowered());
model.PerformFly();

Console.WriteLine("=============");

Duck rubber = new RubberDuck();
rubber.Display();
rubber.PerformFly();
rubber.PerformQuack();