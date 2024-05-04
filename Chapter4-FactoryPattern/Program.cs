using PizzaShop;

PizzaStore nyStore = new NYStylePizzaStore();
Pizza pizza1 = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza1.Name}");

Console.WriteLine();

PizzaStore chicagoStore = new ChicagoStylePizzaStore();
Pizza pizza2 = chicagoStore.OrderPizza("clam");
Console.WriteLine($"Joel ordered a {pizza2.Name}");
