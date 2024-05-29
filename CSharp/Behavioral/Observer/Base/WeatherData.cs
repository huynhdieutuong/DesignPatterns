namespace Observer.Base;
internal class WeatherData : ISubject
{
    private readonly List<IObserver> _observers = [];
    private float _temperature;
    private float _humidity;
    private float _pressure;
    private bool _changed = false;

    public void RegisterObserver(IObserver o)
    {
        _observers.Add(o);
    }

    public void RemoveObserver(IObserver o)
    {
        _observers.Remove(o);
    }

    public void NotifyObservers(object? arg)
    {
        if (_changed)
        {
            _observers.ForEach(observer => observer.Update(this, arg));
        }
        _changed = false;
    }

    public void MeasurementsChanged()
    {
        SetChanged();
        NotifyObservers(null);
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        _temperature = temperature;
        _humidity = humidity;
        _pressure = pressure;
        MeasurementsChanged();
    }

    public float GetTemperature() => _temperature;
    public float GetHumidity() => _humidity;
    public float GetPressure() => _pressure;

    private void SetChanged()
    {
        _changed = true;
    }
}
