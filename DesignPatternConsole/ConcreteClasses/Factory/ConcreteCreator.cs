using DesignPatternConsole.Interfaces.Factory;

namespace DesignPatternConsole.ConcreteClasses.Factory
{
    // Concrete Creators override the factory method in order to change the
    // resulting product's type.
    internal class ConcreteCreator1 : BaseCreator
    {
        // Note that the signature of the method still uses the abstract product
        // type, even though the concrete product is actually returned from the
        // method. This way the Creator can stay independent of concrete product
        // classes.
        public override IFactoryProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }

    internal class ConcreteCreator2 : BaseCreator
    {
        public override IFactoryProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
