using System.Collections;

namespace ObjectvilleCafe;

public class DinerMenu : IMenu
{
    static readonly int MAX_ITEMS = 6;
    int numberOfItems = 0;
    public MenuItem[] MenuItems { get; }

    public DinerMenu()
    {
        MenuItems = new MenuItem[MAX_ITEMS];

        AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", 2.99, true);
        AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", 2.99, false);
        AddItem("Soup of the day", "Soup of the day, with a side of potato salad", 3.29, false);
        AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", 3.05, false);
        AddItem("Steamed Veggies and Brown Rice", "Steamed vegetables over brown rice", 3.99, true);
        AddItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", 3.89, true);
    }

    public void AddItem(string name, string description, double price, bool isVegetarian)
    {
        MenuItem menuItem = new(name, description, price, isVegetarian);
        if (numberOfItems >= MAX_ITEMS)
        {
            System.Console.WriteLine("Sorry, menu is full!  Can't add item to menu");
        }
        else
        {
            MenuItems[numberOfItems] = menuItem;
            numberOfItems++;
        }
    }

    public IEnumerator<MenuItem> GetEnumerator()
    {
        return this.MenuItems.AsEnumerable().GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.MenuItems.GetEnumerator();
    }
}
