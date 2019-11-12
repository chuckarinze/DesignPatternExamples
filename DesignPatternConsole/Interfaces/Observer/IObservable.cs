using System;

namespace DesignPatternConsole.Interfaces.Observer
{
    internal interface IObservable
    {
        event EventHandler SomethingHappened;
    }
}