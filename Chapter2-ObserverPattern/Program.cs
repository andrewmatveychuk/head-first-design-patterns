using WeatherStation;

WeatherData weatherData = new();
CurrentConditionDisplay currentConditionDisplay = new(weatherData);
StatisticsDisplay statisticsDisplay = new(weatherData);
ForecastDisplay forecastDisplay = new(weatherData);
HeatIndexDisplay heatIndexDisplay = new(weatherData);

weatherData.SetMeasurements(80, 65, 30.4F);
weatherData.SetMeasurements(82, 70, 29.2F);
weatherData.SetMeasurements(78, 90, 29.2F);
