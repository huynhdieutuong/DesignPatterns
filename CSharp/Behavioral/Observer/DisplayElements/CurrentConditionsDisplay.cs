using Observer.Base;

namespace Observer.DisplayElements;
internal class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private readonly ISubject _subject;

    public CurrentConditionsDisplay(ISubject subject)
    {
        _subject = subject;
        _subject.RegisterObserver(this);
    }

    public void Update(ISubject subject, object arg)
    {
        if (subject is WeatherData weatherData)
        {
            _temperature = weatherData.GetTemperature();
            _humidity = weatherData.GetHumidity();
            Display();
        }
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
    }
}
