namespace ObjectvilleCafe;

public class Menu : MenuComponent
{
    private List<MenuComponent> menuComponents = [];

    private string name;
    private string description;


    public override string Name { get => name; set => name = value; }
    public override string Description { get => description; set => description = value; }

    public Menu(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public override void Add(MenuComponent component)
    {
        menuComponents.Add(component);
    }
    public override void Remove(MenuComponent component)
    {
        menuComponents.Remove(component);
    }
    public override MenuComponent GetChild(int index)
    {
        return menuComponents[index];
    }
    public override void Print()
    {
        System.Console.WriteLine($"{Name}");
        System.Console.WriteLine($"{Description}");
        System.Console.WriteLine("======================");

        foreach (var component in menuComponents)
        {
            component.Print();
        }
    }
}
