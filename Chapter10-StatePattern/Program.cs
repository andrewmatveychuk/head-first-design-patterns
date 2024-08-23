using GumballMachineWithState;

GumballMachine gumballMachine = new GumballMachine(5);

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