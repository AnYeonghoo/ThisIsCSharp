using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Chapter13
{
    delegate void Notify(string message);

    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappend : {message}");
        }
    }
    internal class DelegateChains
    {
        static void MainDelegateChains()
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Li1");
            EventListener listener2 = new EventListener("Li2");
            EventListener listener3 = new EventListener("Li3");

            notifier.EventOccured += listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You`ve got mail.");

            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappend;
            notifier.EventOccured("Download Complete");

            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappend) + new Notify(listener3.SomethingHappend);
            notifier.EventOccured("Nuclear launch dedtected");


        }
    }
}
