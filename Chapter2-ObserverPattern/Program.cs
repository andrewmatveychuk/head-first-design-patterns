using WeatherStation;

WeatherData weatherData = new();
CurrentConditionDisplay currentConditionDisplay = new(weatherData);
StatisticsDisplay statisticsDisplay = new(weatherData);
ForecastDisplay forecastDisplay = new(weatherData);
HeatIndexDisplay heatIndexDisplay = new(weatherData);

weatherData.SetMeasurements(80, 65, 30.4F);
weatherData.SetMeasurements(82, 70, 29.2F);
weatherData.SetMeasurements(78, 90, 29.2F);

Console.WriteLine();
Console.WriteLine("Updating displays using events...");
Console.WriteLine();

WeatherData weatherData2 = new();
CurrentConditionDisplay currentConditionDisplay2 = new();
weatherData2.WeatherChange += currentConditionDisplay2.OnWeatherChange;
StatisticsDisplay statisticsDisplay2 = new();
weatherData2.WeatherChange += statisticsDisplay2.OnWeatherChange;
ForecastDisplay forecastDisplay2 = new();
weatherData2.WeatherChange += forecastDisplay2.OnWeatherChange;
HeatIndexDisplay heatIndexDisplay2 = new();
weatherData2.WeatherChange += heatIndexDisplay2.OnWeatherChange;

weatherData2.SetMeasurements(90, 50, 25.2F);
weatherData2.SetMeasurements(85, 72, 26.7F);
weatherData2.SetMeasurements(72, 91, 31.2F);