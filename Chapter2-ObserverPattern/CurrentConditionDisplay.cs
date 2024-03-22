namespace WeatherStation;

class CurrentConditionDisplay : IObserver, IDisplayElement
{
    private float temperature;
    private float humidity;
    private readonly WeatherData weatherData;
    public CurrentConditionDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    public void Display() => Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");

    public void Update()
    {
        this.temperature = weatherData.Temperature;
        this.humidity = weatherData.Humidity;
        Display();
    }
}