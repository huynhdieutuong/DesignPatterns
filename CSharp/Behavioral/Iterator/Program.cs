using Iterator;
using Iterator.Menus;

IMenu pancakeHouseMenu = new PancakeHouseMenu();
IMenu dinerMenu = new DinerMenu();
IMenu cafeMenu = new CafeMenu();

Waitress waitress = new([pancakeHouseMenu, dinerMenu, cafeMenu]);
waitress.PrintMenu();