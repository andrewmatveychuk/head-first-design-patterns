
namespace WeatherStation;

class CurrentConditionDisplay : IObserver, IDisplayElement
{
    private float temperature;
    private float humidity;
    private readonly WeatherData? weatherData;
    public CurrentConditionDisplay() { }
    public CurrentConditionDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    public void Display() => Console.WriteLine($"Current conditions: {temperature}F degrees and {humidity}% humidity");

    public void Update()
    {
        if (weatherData is not null)
        {
            temperature = weatherData.Temperature;
            humidity = weatherData.Humidity;
            Display();
        }
    }

    public void OnWeatherChange(object? sender, EventArgs e)
    {
        if (sender is not null)
        {
            WeatherData? data = sender as WeatherData;
            if (data is not null)
            {
                temperature = data.Temperature;
                humidity = data.Humidity;
                Display();
            }
        }
    }
}