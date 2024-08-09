namespace ChocolateFactory;

public class ChocolateBoiler
{
    public bool IsEmpty;
    public bool IsBoiled;

    private static ChocolateBoiler _boiler = new();

    private ChocolateBoiler()
    {
        IsEmpty = true;
        IsBoiled = false;
    }

    public static ChocolateBoiler GetInstance()
    {
        if (_boiler == null)
        {
            _boiler = new ChocolateBoiler();
        }
        return new ChocolateBoiler();
    }

    public void Fill()
    {
        if (IsEmpty)
        {
            System.Console.WriteLine("Filling the boiler...");
            IsEmpty = false;
            IsBoiled = false;
        }
    }

    public void Drain()
    {
        if (!IsEmpty && IsBoiled)
        {
            System.Console.WriteLine("Draining the boiler...");
            IsEmpty = true;
        }
    }

    public void Boil()
    {
        if (!IsEmpty && !IsBoiled)
        {
            System.Console.WriteLine("Heating the boiler...");
            IsBoiled = true;
        }

    }
}
