using Iterator.Menus;

namespace Iterator.Base;
internal class DinerMenuIterator : IIterator
{
    readonly MenuItem[] MenuItems;
    int Position = 0;

    public DinerMenuIterator(MenuItem[] menuItems)
    {
        MenuItems = menuItems;
    }

    public bool HasNext()
    {
        if (Position >= MenuItems.Length || MenuItems[Position] == null) return false;

        return true;
    }

    public object Next()
    {
        MenuItem menuItem = MenuItems[Position];
        Position++;
        return menuItem;
    }
}
