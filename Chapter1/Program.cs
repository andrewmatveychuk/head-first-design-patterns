using Ducks;

Duck mallard = new MallardDuck();
mallard.Display();
mallard.PerformFly();
mallard.PerformQuack();

Console.WriteLine();

Duck modelDuck = new ModelDuck();
modelDuck.Display();
modelDuck.PerformFly();
modelDuck.FlyBehavior = new FlyRocketPowered();
modelDuck.PerformFly();