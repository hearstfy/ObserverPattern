namespace ObserverPattern
{
    public interface IObserver
    {
        void update(ISubject subject);
    }
}