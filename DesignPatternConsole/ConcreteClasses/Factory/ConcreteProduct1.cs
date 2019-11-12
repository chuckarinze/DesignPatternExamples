using DesignPatternConsole.Interfaces.Factory;

namespace DesignPatternConsole.ConcreteClasses.Factory
{
    /// <summary>
    /// Concrete Products provide various implementations of the Factory Product interface
    /// </summary>
    public class ConcreteProduct1 : IFactoryProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }

    /// <summary>
    /// Concrete Products provide various implementations of the Factory Product interface
    /// </summary>
    public class ConcreteProduct2 : IFactoryProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
