namespace ObjectvilleCafe;

public class Waitress
{
    MenuComponent AllMenus { get; }

    public Waitress(MenuComponent allMenus)
    {
        this.AllMenus = allMenus;
    }

    public void PrintMenu()
    {
        AllMenus.Print();
    }
}
