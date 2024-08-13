
namespace Barista;

public abstract class CaffeineBeverage
{
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        if (CustomerWantsCondiments())
        {
            AddCondiments();
        }
    }

    private void BoilWater()
    {
        System.Console.WriteLine("Boiling water...");
    }
    protected abstract void Brew();
    private void PourInCup()
    {
        System.Console.WriteLine("Pouring into cup...");
    }
    protected abstract void AddCondiments();
    protected virtual bool CustomerWantsCondiments()
    {
        return true;
    }
}
