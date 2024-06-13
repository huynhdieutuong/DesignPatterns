using Composite.Base;

namespace Composite;
internal class Waitress
{
    MenuComponent AllMenus;

    public Waitress(MenuComponent allMenus)
    {
        AllMenus = allMenus;
    }

    public void PrintMenu()
    {
        AllMenus.Print();
    }
}
