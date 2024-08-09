namespace Singleton;

public sealed class Singleton
{
    private static Singleton _uniqueInstance = new();
    static Singleton() { }
    private Singleton() { }

    public static Singleton Instance => _uniqueInstance;
}
