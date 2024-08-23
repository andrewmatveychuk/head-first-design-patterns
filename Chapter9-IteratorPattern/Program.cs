using ObjectvilleCafe;

MenuComponent pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
MenuComponent dinerMenu = new Menu("DINER MENU", "Lunch");
MenuComponent cafeMenu = new Menu("CAFE MENU", "Dinner");
MenuComponent dessertMenu = new Menu("DESSERT MENU", "Dessert of course!");
MenuComponent coffeeMenu = new Menu("COFFEE MENU", "Stuff to go with your afternoon coffee");

MenuComponent allMenus = new Menu("ALL MENUS", "All menus combined");

allMenus.Add(pancakeHouseMenu);
allMenus.Add(dinerMenu);
allMenus.Add(cafeMenu);

pancakeHouseMenu.Add(new MenuItem(
    "K&B's Pancake Breakfast",
    "Pancakes with scrambled eggs and toast",
    2.99,
    true));
pancakeHouseMenu.Add(new MenuItem(
    "Regular Pancake Breakfast",
    "Pancakes with fried eggs, sausage",
    2.99,
    false));
pancakeHouseMenu.Add(new MenuItem(
    "Blueberry Pancakes",
    "Pancakes made with fresh blueberries, and blueberry syrup",
    3.49,
    true));
pancakeHouseMenu.Add(new MenuItem(
    "Waffles",
    "Waffles with your choice of blueberries or strawberries",
    3.59,
    true));

dinerMenu.Add(new MenuItem(
    "Vegetarian BLT",
    "(Fakin') Bacon with lettuce & tomato on whole wheat",
    2.99,
    true));
dinerMenu.Add(new MenuItem(
    "BLT",
    "Bacon with lettuce & tomato on whole wheat",
    2.99,
    false));
dinerMenu.Add(new MenuItem(
    "Soup of the day",
    "A bowl of the soup of the day, with a side of potato salad",
    3.29,
    false));
dinerMenu.Add(new MenuItem(
    "Hot Dog",
    "A hot dog, with saurkraut, relish, onions, topped with cheese",
    3.05,
    false));
dinerMenu.Add(new MenuItem(
    "Steamed Veggies and Brown Rice",
    "Steamed vegetables over brown rice",
    3.99,
    true));

dinerMenu.Add(new MenuItem(
    "Pasta",
    "Spaghetti with marinara sauce, and a slice of sourdough bread",
    3.89,
    true));

dinerMenu.Add(dessertMenu);

dessertMenu.Add(new MenuItem(
    "Apple Pie",
    "Apple pie with a flakey crust, topped with vanilla icecream",
    1.59,
    true));

dessertMenu.Add(new MenuItem(
    "Cheesecake",
    "Creamy New York cheesecake, with a chocolate graham crust",
    1.99,
    true));
dessertMenu.Add(new MenuItem(
    "Sorbet",
    "A scoop of raspberry and a scoop of lime",
    1.89,
    true));

cafeMenu.Add(new MenuItem(
    "Veggie Burger and Air Fries",
    "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
    3.99,
    true));
cafeMenu.Add(new MenuItem(
    "Soup of the day",
    "A cup of the soup of the day, with a side salad",
    3.69,
    false));
cafeMenu.Add(new MenuItem(
    "Burrito",
    "A large burrito, with whole pinto beans, salsa, guacamole",
    4.29,
    true));

cafeMenu.Add(coffeeMenu);

coffeeMenu.Add(new MenuItem(
    "Coffee Cake",
    "Crumbly cake topped with cinnamon and walnuts",
    1.59,
    true));
coffeeMenu.Add(new MenuItem(
    "Bagel",
    "Flavors include sesame, poppyseed, cinnamon raisin, pumpkin",
    0.69,
    false));
coffeeMenu.Add(new MenuItem(
    "Biscotti",
    "Three almond or hazelnut biscotti cookies",
    0.89,
    true));

Waitress waitress = new(allMenus);

waitress.PrintMenu();