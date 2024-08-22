using ObjectvilleCafe;

PancakeHouseMenu pancakeHouseMenu = new();
DinerMenu dinerMenu = new();
CafeMenu cafeMenu = new();

List<IMenu> menus = [pancakeHouseMenu, dinerMenu, cafeMenu];

Waitress waitress = new(menus);
waitress.PrintMenu();