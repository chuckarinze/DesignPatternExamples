using System;
using System.Collections.Generic;
using System.Globalization;
using DesignPatternConsole.Interfaces.Observer;

namespace DesignPatternConsole.ConcreteClasses.Observer
{
    /// <summary>
    /// The observer pattern is where an object, called the Observer (Subject), maintains a list of its dependents,
    /// called Observerables (Subscribers), and notifies them automatically of any state changes, usually by calling one of their methods.
    /// It is mainly used to implement distributed event handling systems, such as in "event driven" software.
    /// Typically they have an Add method (like Register or Subscribe), Remove Method (Unregister, unsubscribe) and a Notify method.
    /// The Add and remove adds and removes observerables to the Observers collection.
    /// The add is generally called from the Observer's constructor with the observerable passed in as a constructor argument.
    /// For a fun, complete, well explained, quick and informative video watch Christopher Okhravi's video on:
    /// https://www.youtube.com/watch?v=_BpmfnqjgzQ
    /// </summary>
    internal sealed class Observer : IObserver
    {
        /// <summary>
        /// Collection of observerables that 
        /// </summary>
        private readonly Lazy<IList<IObservable>> _observables =
            new Lazy<IList<IObservable>>(() => new List<IObservable>());

        private readonly string _observerName;

        public Observer(IObservable observable, string observerName = "") //: this()
        {
            if (!string.IsNullOrWhiteSpace(observerName))
                _observerName = observerName;
            else
                _observerName = "Observer: " + DateTime.Now.ToString(CultureInfo.InvariantCulture);
            Add(observable);
        }

        public string GetName()
        {
            return _observerName;
        }

        public void Add(IObservable observable)
        {
            if (observable == null) return;

            lock (_observables)
            {
                _observables.Value.Add(observable);
                observable.SomethingHappened += HandleEvent;
                observable.SomethingHappened += AddObserverableEvent;
                RunningTotal = _observables.Value.Count;
            }
        }

        public void Remove(IObservable observable)
        {
            if (observable == null) return;

            lock (_observables)
            {
                observable.SomethingHappened -= HandleEvent;
                observable.SomethingHappened -= AddObserverableEvent;
                _observables.Value.Remove(observable);
                Console.WriteLine("removing  observable  " + observable);
                RunningTotal = _observables.Value.Count;
            }
        }

        public void Dispose()
        {
            for (var i = _observables.Value.Count - 1; i >= 0; i--) Remove(_observables.Value[i]);
        }

        private static int RunningTotal { get; set; }

        private static void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine(" Event Fired: Something happened to " + sender);
        }

        private static void AddObserverableEvent(object sender, EventArgs args)
        {
            var runningTotal = RunningTotal;
            Console.WriteLine(" Adding observerable fired event on " + sender +
                              " Note: Running total of observerables: " + runningTotal);
        }
    }
}