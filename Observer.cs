using System;

namespace ObserverPattern
{
    public class Observer : IObserver
    {
        private string name;
        private bool evenOnly;

        public Observer(string name, bool evenOnly)
        {
            this.name = name;
            this.evenOnly = evenOnly;
        }

        public void update(ISubject subject)
        {
            int data = subject.getData();

            if (evenOnly && data % 2 != 0)
            {
                Console.WriteLine(name + " only accepts even numbers");
            }
            else
            {
                Console.WriteLine(name + " says new data is " + data);
            }

        }
    }
}