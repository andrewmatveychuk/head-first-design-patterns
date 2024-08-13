using Barista;

System.Console.WriteLine("==== Preparing Tea ====");
Tea myTea = new();
myTea.PrepareRecipe();

System.Console.WriteLine("==== Preparing Coffee ====");
Coffee myCoffee = new(CoffeeSize.Medium);
myCoffee.PrepareRecipe();

System.Console.WriteLine("==== Preparing Coffee ====");
Coffee myCoffee2 = new(CoffeeSize.Small);
myCoffee.PrepareRecipe();

var cupsOfCoffee = new[] { myCoffee, myCoffee2 };


System.Console.WriteLine("Before sorting:");
Output(cupsOfCoffee);

Array.Sort(cupsOfCoffee);

System.Console.WriteLine("After sorting:");
Output(cupsOfCoffee);


static void Output(Coffee[] coffees)
{
    foreach (var coffee in coffees)
    {
        System.Console.WriteLine(coffee);
    }
}