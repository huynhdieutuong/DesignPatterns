namespace Observer.Base;
internal interface ISubject
{
    void RegisterObserver(IObserver o);
    void RemoveObserver(IObserver o);
    void NotifyObservers(object? arg);
}
