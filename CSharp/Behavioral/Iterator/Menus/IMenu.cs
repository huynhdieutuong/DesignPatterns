using System.Collections;

namespace Iterator.Menus;
internal interface IMenu
{
    //IIterator CreateIterator();
    IEnumerable CreateIterator();
}
