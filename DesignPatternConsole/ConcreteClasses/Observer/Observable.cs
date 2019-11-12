using System;
using DesignPatternConsole.Interfaces.Observer;

namespace DesignPatternConsole.ConcreteClasses.Observer
{
    internal sealed class Observable : IObservable
    {
        public event EventHandler SomethingHappened;

        public void DoSomething()
        {
            var handler = SomethingHappened;

            Console.WriteLine("About to do something hard core in the Observable.");
            handler?.Invoke(this, EventArgs.Empty);
        }
    }

    internal sealed class AnotherObservable : IObservable
    {
        public event EventHandler SomethingHappened;

        public void DoSomething()
        {
            var handler = SomethingHappened;

            Console.WriteLine("About to do something different (not hard core) in Another Observable.");
            handler?.Invoke(this, EventArgs.Empty);
        }
    }

}
