using System.Collections;

namespace Iterator.Menus;
internal class PancakeHouseMenu : IMenu
{
    readonly List<MenuItem> MenuItems;

    public PancakeHouseMenu()
    {
        MenuItems = [];

        AddItem("K&B’s Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);
        AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);
        AddItem("Blueberry Pancakes", "“Pancakes made with fresh blueberries", true, 3.49);
        AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
    }

    public void AddItem(string name, string description, bool vegetarian, double price)
    {
        MenuItem menuItem = new(name, description, vegetarian, price);
        MenuItems.Add(menuItem);
    }

    //public List<MenuItem> GetMenuItems() => MenuItems;
    //public IIterator CreateIterator() => new PancakeHouseMenuIterator(MenuItems);
    public IEnumerable CreateIterator() => MenuItems;
}
