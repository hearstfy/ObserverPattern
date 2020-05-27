using System;
using System.Threading;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Subject();
            IObserver o1 = new Observer("Observer 1", false);
            IObserver o2 = new Observer("Observer 2", true);

            subject.subscribe(o1);
            subject.subscribe(o2);

            Thread.Sleep(TimeSpan.FromSeconds(30));

            subject.unsubscribe(o2);


            Thread.Sleep(TimeSpan.FromMinutes(10));
        }
    }
}
