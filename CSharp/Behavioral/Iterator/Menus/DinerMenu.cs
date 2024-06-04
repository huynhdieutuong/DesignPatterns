using System.Collections;

namespace Iterator.Menus;
internal class DinerMenu : IMenu
{
    static readonly int MAX_ITEMS = 6;
    int NumberOfItems = 0;
    readonly MenuItem[] MenuItems;

    public DinerMenu()
    {
        MenuItems = new MenuItem[MAX_ITEMS];

        AddItem("Vegetarian BLT", "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99);
        AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
        AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
        AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
    }

    public void AddItem(string name, string description, bool vegetarian, double price)
    {
        MenuItem menuItem = new(name, description, vegetarian, price);
        if (NumberOfItems >= MAX_ITEMS)
        {
            Console.WriteLine("Sorry, menu is full! Can’t add item to menu");
        }
        else
        {
            MenuItems[NumberOfItems] = menuItem;
            NumberOfItems++;
        }
    }

    //public MenuItem[] GetMenuItems() => MenuItems;
    //public IIterator CreateIterator() => new DinerMenuIterator(MenuItems);
    public IEnumerable CreateIterator() => MenuItems;
}
