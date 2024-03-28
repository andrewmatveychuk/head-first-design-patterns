namespace WeatherStation;

public interface IDisplayElement
{
    public void Display();
    public void OnWeatherChange(object? sender, EventArgs e);
}