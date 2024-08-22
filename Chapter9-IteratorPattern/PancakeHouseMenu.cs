using System.Collections;

namespace ObjectvilleCafe;

public class PancakeHouseMenu : IMenu
{
    public List<MenuItem> MenuItems { get; }

    public PancakeHouseMenu()
    {
        this.MenuItems = [];
        AddItem("K&B's Pancake Breakfast",
            "Pancakes with scrambled eggs and toast",
            2.99,
            true);

        AddItem("Regular Pancake Breakfast",
            "Pancakes with fried eggs, sausage",
            2.99,
            false);

        AddItem("Blueberry Pancakes",
            "Pancakes made with fresh blueberries",
            3.49,
            true);

        AddItem("Waffles",
            "Waffles with your choice of blueberries or strawberries",
            3.59,
            true );
    }

    public void AddItem(string name, string description, double price, bool isVegetarian)
    {
        MenuItem item = new(name, description, price, isVegetarian);
        this.MenuItems.Add(item);
    }

    public IEnumerator<MenuItem> GetEnumerator()
    {
        return this.MenuItems.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.MenuItems.GetEnumerator();
    }
}
