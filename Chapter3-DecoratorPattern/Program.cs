using StarbuzzCoffee;

Beverage beverage1 = new Espresso(BeverageSize.GRANDE);
Console.WriteLine(beverage1.Description + " $" + beverage1.Cost);

Beverage beverage2 = new DarkRoast(BeverageSize.TALL);
beverage2 = new Mocha(beverage2);
beverage2 = new Mocha(beverage2);
beverage2 = new Whip(beverage2);
Console.WriteLine(beverage2.Description + " $" + beverage2.Cost);

Beverage beverage3 = new HouseBlend(BeverageSize.VENTI);
beverage3 = new SteamedMilk() {
    Beverage = beverage3,
    Size = beverage3.Size
};
beverage3 = new Mocha(beverage3);
beverage3 = new Whip(beverage3);
Console.WriteLine(beverage3.Description + " $" + beverage3.Cost);