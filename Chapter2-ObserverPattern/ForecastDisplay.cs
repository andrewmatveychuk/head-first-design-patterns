namespace WeatherStation;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private float previousPressure;
    private float currentPressure;
    private readonly WeatherData weatherData;

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
        previousPressure = currentPressure;
        currentPressure = weatherData.Pressure;
        Display();
    }
}