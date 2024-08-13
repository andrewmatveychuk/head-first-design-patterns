namespace Barista;

public class Coffee : CaffeineBeverage, IComparable<Coffee>
{
    public CoffeeSize Size { get; }
    public Coffee(CoffeeSize size)
    {
        this.Size = size;
    }
    protected override void AddCondiments()
    {
        System.Console.WriteLine("Adding Sugar and Milk...");
    }

    protected override void Brew()
    {
        System.Console.WriteLine("Dripping Coffee through filter...");
    }

    protected override bool CustomerWantsCondiments()
    {
        System.Console.WriteLine("Do you want to add Sugar and Milk?");
        return GetUserInput();
    }

    private bool GetUserInput()
    {
        string[] validResponses = new[] { "Yes", "yes", "y", "Y", "No", "no", "N", "n" };

        System.Console.WriteLine("Y(es) or N(o)?");
        string? input;

        while (!validResponses.Contains(input = System.Console.ReadLine()))
        {
            System.Console.WriteLine("Invalid input. Please try again...");
            System.Console.WriteLine("Allowed input values are:");
            System.Console.WriteLine(string.Join(", ", validResponses));
        }

        bool UserResponse = input switch
        {
            "Yes" => true,
            "yes" => true,
            "Y" => true,
            "y" => true,
            "No" => false,
            "no" => false,
            "N" => false,
            "n" => false,
            _ => false,

        };

        return UserResponse;
    }

    public int CompareTo(Coffee? other)
    {

        if (other == null) return 1;

        if (this.Size < other.Size)
        {
            return -1;
        }
        else if (this.Size == other.Size)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public override string? ToString() {
        return $"{this.Size} Coffee";
    }
}

public enum CoffeeSize
{
    Small = 0,
    Medium = 1,
    Large = 2,
}