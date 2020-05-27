using System;
using System.Collections;
using System.Linq;
using System.Threading;

namespace ObserverPattern
{
    public class Subject : ISubject
    {
        private ArrayList observers;
        private int randomNumber;
        private Random randomGenerator;
        private Timer randomTimer;

        public Subject()
        {
            observers = new ArrayList();
            randomGenerator = new Random();
            setTimer();
        }
        private void notify()
        {
            int size = observers.Count;

            foreach (int index in Enumerable.Range(0, size))
            {
                IObserver o = (IObserver)observers[index];
                o.update(this);
            }
        }

        public void subscribe(IObserver o)
        {
            observers.Add(o);
        }

        public void unsubscribe(IObserver o)
        {
            int index = observers.IndexOf(o);

            if (index > 0)
                observers.Remove(o);
        }

        private void generateRandomNumber()
        {
            randomNumber = randomGenerator.Next();
            notify();
        }

        private void setTimer()
        {
            randomTimer = new Timer(_ => generateRandomNumber(), null, 0, 1000);
        }

        public int getData()
        {
            return randomNumber;
        }
    }
}