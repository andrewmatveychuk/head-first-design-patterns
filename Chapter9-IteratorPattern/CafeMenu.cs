using System.Collections;

namespace ObjectvilleCafe;

public class CafeMenu : IMenu
{
    public Dictionary<string, MenuItem> MenuItems { get; }

    public CafeMenu()
    {
        this.MenuItems = [];
        AddItem("Veggie Burger and Air Fries",
            "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
            3.99, true);
        AddItem("Soup of the day",
            "A cup of the soup of the day, with a side salad",
            3.69, false);
        AddItem("Burrito",
            "A large burrito, with whole pinto beans, salsa, guacamole",
            4.29, true);
    }

    public void AddItem(string name, string description, double price, bool isVegetarian)
    {
        MenuItem item = new(name, description, price, isVegetarian);
        this.MenuItems.Add(name, item);
    }

    public IEnumerator<MenuItem> GetEnumerator()
    {
        return this.MenuItems.Values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.MenuItems.GetEnumerator();
    }
}
