using GumballMachineWithState;

GumballMachine gumballMachine = new(5, "Brooklyn");

System.Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

System.Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.EjectQuarter();
gumballMachine.TurnCrank();

System.Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.EjectQuarter();

System.Console.WriteLine(gumballMachine);

gumballMachine.InsertQuarter();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();
gumballMachine.InsertQuarter();
gumballMachine.TurnCrank();

System.Console.WriteLine(gumballMachine);