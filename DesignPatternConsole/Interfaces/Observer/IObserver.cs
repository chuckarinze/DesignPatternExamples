using System;

namespace DesignPatternConsole.Interfaces.Observer
{
    internal interface IObserver : IDisposable
    {
        void Add(IObservable observable);
        void Remove(IObservable observable);
        string GetName();
    }

}
