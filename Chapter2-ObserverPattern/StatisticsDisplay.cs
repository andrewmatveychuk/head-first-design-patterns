
namespace WeatherStation;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private float minimumTemperature;
    private float maximumTemperature;
    private float sumOfReportedTemperatures;
    private int numberOfMeasures;
    private WeatherData? weatherData;
    public StatisticsDisplay() { }
    public StatisticsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
        this.minimumTemperature = this.maximumTemperature = weatherData.Temperature;
    }
    public void Display() => Console.WriteLine($"Avg/Max/Min temperature = {sumOfReportedTemperatures / numberOfMeasures}/{maximumTemperature}/{minimumTemperature}");

    public void OnWeatherChange(object? sender, EventArgs e)
    {
        if (sender is not null)
        {
            WeatherData? data = sender as WeatherData;
            if (data is not null)
            {
                sumOfReportedTemperatures += data.Temperature;
                numberOfMeasures++;
                maximumTemperature = maximumTemperature < data.Temperature ? data.Temperature : maximumTemperature;
                minimumTemperature = minimumTemperature > data.Temperature ? data.Temperature : minimumTemperature;
                Display();
            }
        }
    }

    public void Update()
    {
        if (weatherData is not null)
        {
            sumOfReportedTemperatures += weatherData.Temperature;
            numberOfMeasures++;
            maximumTemperature = maximumTemperature < weatherData.Temperature ? weatherData.Temperature : maximumTemperature;
            minimumTemperature = minimumTemperature > weatherData.Temperature ? weatherData.Temperature : minimumTemperature;
            Display();
        }
    }
}