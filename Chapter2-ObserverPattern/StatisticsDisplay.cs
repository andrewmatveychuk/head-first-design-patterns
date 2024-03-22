namespace WeatherStation;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private float minimumTemperature;
    private float maximumTemperature;
    private float sumOfReportedTemperatures;
    private int numberOfMeasures;
    private WeatherData weatherData;

    public StatisticsDisplay(WeatherData weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
        this.minimumTemperature = this.maximumTemperature = weatherData.Temperature;
    }
    public void Display() => Console.WriteLine($"Avg/Max/Min temperature = {sumOfReportedTemperatures/numberOfMeasures}/{maximumTemperature}/{minimumTemperature}");

    public void Update()
    {
        sumOfReportedTemperatures += weatherData.Temperature;
        numberOfMeasures++;
        maximumTemperature = maximumTemperature < weatherData.Temperature ? weatherData.Temperature : maximumTemperature;
        minimumTemperature = minimumTemperature > weatherData.Temperature ? weatherData.Temperature : minimumTemperature;
        Display();
    }
}