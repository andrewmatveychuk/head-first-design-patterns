namespace ObjectvilleCafe;

public abstract class MenuComponent
{
    public virtual string Name
    {
        get => throw new NotSupportedException();
        set => throw new NotSupportedException();
    }
    public virtual string Description
    {
        get => throw new NotSupportedException();
        set => throw new NotSupportedException();
    }
    public virtual double Price
    {
        get => throw new NotSupportedException();
        set => throw new NotSupportedException();
    }
    public virtual bool IsVegetarian
    {
        get => throw new NotSupportedException();
        set => throw new NotSupportedException();
    }

    public virtual void Add(MenuComponent component) => throw new NotSupportedException();
    public virtual void Remove(MenuComponent component) => throw new NotSupportedException();
    public virtual MenuComponent GetChild(int index) => throw new NotSupportedException();

    public abstract void Print();

}
