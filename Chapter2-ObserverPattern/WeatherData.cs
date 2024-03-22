namespace WeatherStation;

public class WeatherData : ISubject
{
    public float Temperature { get; private set; }
    public float Humidity { get; private set; }
    public float Pressure { get; private set; }
    public void MeasurementsChanged() => NotifyObservers();
    private List<IObserver> observers;

    public WeatherData()
    {
        observers = new List<IObserver>();
    }
    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update();
        }
    }
    public void RegisterObserver(IObserver observer) => observers.Add(observer);
    public void RemoveObserver(IObserver observer) => observers.Remove(observer);
    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
}