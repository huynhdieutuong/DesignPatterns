using Observer.Base;
using Observer.DisplayElements;

WeatherData weatherData = new();
_ = new CurrentConditionsDisplay(weatherData);
_ = new StatisticsDisplay(weatherData);
ForecastDisplay forecastDisplay = new(weatherData);

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);

Console.WriteLine("============");
weatherData.RemoveObserver(forecastDisplay);
weatherData.SetMeasurements(90, 90, 29.2f);