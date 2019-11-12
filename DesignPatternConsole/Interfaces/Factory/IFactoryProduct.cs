using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternConsole.Interfaces.Factory
{
    /// <summary>
    /// The Product interface declares the operations that all concrete products must implement.
    /// </summary>
    public interface IFactoryProduct
    {
        string Operation();
    }
}
