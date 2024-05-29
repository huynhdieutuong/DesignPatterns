using Observer.Base;

namespace Observer.DisplayElements;
internal class StatisticsDisplay : IObserver, IDisplayElement
{
    private readonly List<float> _temps = [];
    private readonly ISubject _subject;

    public StatisticsDisplay(ISubject subject)
    {
        _subject = subject;
        _subject.RegisterObserver(this);
    }

    public void Update(ISubject subject, object arg)
    {
        if (subject is WeatherData weatherData)
        {
            _temps.Add(weatherData.GetTemperature());
            Display();
        }
    }

    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature = {GetAvg()}/{GetMax()}/{GetMin()}");
    }

    private float GetAvg()
    {
        return _temps.DefaultIfEmpty(0).Average(x => x);
    }

    private float GetMax()
    {
        return _temps.DefaultIfEmpty(0).Max(x => x);
    }

    private float GetMin()
    {
        return _temps.DefaultIfEmpty(0).Min(x => x);
    }
}
