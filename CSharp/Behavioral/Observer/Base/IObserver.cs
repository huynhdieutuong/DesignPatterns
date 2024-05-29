namespace Observer.Base;
internal interface IObserver
{
    void Update(ISubject subject, object arg);
}
