using Iterator.Menus;
using System.Collections;

namespace Iterator;
internal class Waitress
{
    private readonly List<IMenu> _menus;

    public Waitress(List<IMenu> menus)
    {
        _menus = menus;
    }

    public void PrintMenu()
    {
        foreach (IMenu menu in _menus)
        {
            IEnumerable enumrable = menu.CreateIterator();
            Console.WriteLine("===========");
            PrintMenu(enumrable);
        }
    }

    private void PrintMenu(IEnumerable enumrable)
    {
        IEnumerator iterator = enumrable.GetEnumerator();
        while (iterator.MoveNext())
        {
            MenuItem menuItem = (MenuItem)iterator.Current;
            Console.WriteLine($"{menuItem?.GetName()}, {menuItem?.GetPrice()} -- {menuItem?.GetDescription()}");
        }
    }
}
