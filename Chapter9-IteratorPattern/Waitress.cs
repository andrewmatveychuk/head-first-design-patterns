namespace ObjectvilleCafe;

public class Waitress
{
    public List<IMenu> Menus { get; }

    public Waitress(List<IMenu> menus)
    {
        this.Menus = menus;
    }

    public void PrintMenu()
    {
        System.Console.WriteLine("==== Breakfast Menu ====");
        foreach (var menu in Menus)
        {
            foreach (var item in menu)
            {
                PrintMenuItem(item);
            }
        }
    }

    private void PrintMenuItem(MenuItem item)
    {
        System.Console.WriteLine($"{item.Name}, {item.Price}");
    }
}
