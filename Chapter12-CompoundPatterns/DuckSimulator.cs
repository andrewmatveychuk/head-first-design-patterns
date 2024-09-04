namespace Chapter12_CompoundPatterns;

public class DuckSimulator
{
    public void Simulate(AbstractDuckFactory duckFactory)
    {
        IQuackable mallardDuck = duckFactory.CreateMallardDuck();
        IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
        IQuackable duckCall = duckFactory.CreateDuckCall();
        IQuackable rubberDuck = duckFactory.CreateRubberDuck();
        IQuackable gooseDuck = new GooseAdapter(new Goose());

        Flock flockOfDucks = new();
        flockOfDucks.Add(mallardDuck);
        flockOfDucks.Add(redheadDuck);
        flockOfDucks.Add(duckCall);
        flockOfDucks.Add(rubberDuck);
        flockOfDucks.Add(gooseDuck);

        Flock flockOfMallards = new();
        flockOfMallards.Add(duckFactory.CreateMallardDuck());
        flockOfMallards.Add(duckFactory.CreateMallardDuck());
        flockOfMallards.Add(duckFactory.CreateMallardDuck());
        flockOfMallards.Add(duckFactory.CreateMallardDuck());

        flockOfDucks.Add(flockOfMallards);

        /* System.Console.WriteLine("Duck Simulator: Whole Flock");
        System.Console.WriteLine("===========================");

        this.Simulate(flockOfDucks);

        System.Console.WriteLine("Duck Simulator: Mallard Flock");
        System.Console.WriteLine("===========================");

        this.Simulate(flockOfMallards); */

        Quackologist quackologist= new Quackologist();
        flockOfDucks.RegisterObserver(quackologist);

        System.Console.WriteLine("Duck Simulator: With Observer");
        System.Console.WriteLine("=============================");

        this.Simulate(flockOfDucks);

        System.Console.WriteLine($"The ducks quacked {QuackCounter.NumberOfQuacks} time(s).");
    }

    private void Simulate(IQuackable duck)
    {
        duck.Quack();
    }
}
