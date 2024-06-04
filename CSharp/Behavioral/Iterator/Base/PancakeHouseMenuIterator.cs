using Iterator.Menus;

namespace Iterator.Base;
internal class PancakeHouseMenuIterator : IIterator
{
    readonly List<MenuItem> MenuItems;
    int Position = 0;

    public PancakeHouseMenuIterator(List<MenuItem> menuItems)
    {
        MenuItems = menuItems;
    }

    public bool HasNext()
    {
        if (Position >= MenuItems.Count || MenuItems[Position] == null) return false;

        return true;
    }

    public object Next()
    {
        MenuItem menuItem = MenuItems[Position];
        Position++;
        return menuItem;
    }
}
