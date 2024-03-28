
namespace WeatherStation;

public class HeatIndexDisplay : IObserver, IDisplayElement
{
    private float temperature;
    private float humidity;
    private readonly WeatherData? weatherData;
    public float HeatIndex => CalculateHeatIndex(this.temperature, this.humidity);
    public HeatIndexDisplay() { }
    public HeatIndexDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display() => Console.WriteLine($"Heat index is {HeatIndex}");

    public void Update()
    {
        if (weatherData is not null)
        {
            temperature = weatherData.Temperature;
            humidity = weatherData.Humidity;
            Display();
        }
    }

    // Helper method to calculate the heat index
    private static float CalculateHeatIndex(float t, float rh)
    {
        return (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh) +
            (0.00941695 * (t * t)) + (0.00728898 * (rh * rh)) +
            (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
            (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
            (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
            (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
            0.000000000843296 * (t * t * rh * rh * rh)) -
            (0.0000000000481975 * (t * t * t * rh * rh * rh)));
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