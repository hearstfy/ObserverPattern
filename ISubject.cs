namespace ObserverPattern
{
    public interface ISubject
    {
        void subscribe(IObserver o);
        void unsubscribe(IObserver o);
        int getData();
    }
}