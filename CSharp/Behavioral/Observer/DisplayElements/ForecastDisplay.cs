using Observer.Base;

namespace Observer.DisplayElements;
internal class ForecastDisplay : IObserver, IDisplayElement
{
    private float _temp;
    private readonly ISubject _subject;

    public ForecastDisplay(ISubject subject)
    {
        _subject = subject;
        _subject.RegisterObserver(this);
    }

    public void Update(ISubject subject, object arg)
    {
        if (subject is WeatherData weatherData)
        {
            _temp = weatherData.GetTemperature();
            Display();
        }
    }

    public void Display()
    {
        Console.WriteLine($"Forecast: {GetForecastWeather(_temp)}");
    }

    private static string GetForecastWeather(float temperature)
    {
        const float StandardTemp = 80;

        if (temperature == StandardTemp) return "Improving weather on the way!";

        if (temperature > StandardTemp) return "Watch out for cooler, rainy weather";

        return "More of the same";
    }
}
