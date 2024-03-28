
namespace WeatherStation;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private float previousPressure;
    private float currentPressure;
    private readonly WeatherData? weatherData;
    public ForecastDisplay() { }
    public ForecastDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    public void Display()
    {
        if (currentPressure > previousPressure)
        {
            Console.WriteLine("Forecast: Improving weather on the way!");
        }
        else if (currentPressure < previousPressure)
        {
            Console.WriteLine("Forecast: Watch out for cooler, rainy weather");
        }
        else
        {
            Console.WriteLine("Forecast: More of the same");
        }
    }

    public void Update()
    {
        if (weatherData is not null)
        {
            previousPressure = currentPressure;
            currentPressure = weatherData.Pressure;
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
                previousPressure = currentPressure;
                currentPressure = data.Pressure;
                Display();
            }
        }
    }
}