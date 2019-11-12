using DesignPatternConsole.Interfaces.Factory;

namespace DesignPatternConsole.ConcreteClasses.Factory
{
    /// <summary>
    /// The factory method pattern is a creational pattern that uses factory methods to deal with the problem of
    /// creating objects without having to specify the exact class of the object that will be created.
    /// The Creator class declares the factory method that is supposed to return
    /// an object of a Product class. The Creator's subclasses usually provide
    /// the implementation of this method.
    /// For a fun, complete, well explained, quick and informative video watch Christopher Okhravi's factory method pattern video on:
    /// https://www.youtube.com/watch?v=EcFVTgRHJLM
    /// </summary>
    public abstract class BaseCreator
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract IFactoryProduct FactoryMethod();

        // Also note that, despite its name, the Creator's primary
        // responsibility is not creating products. Usually, it contains some
        // core business logic that relies on Product objects, returned by the
        // factory method. Subclasses can indirectly change that business logic
        // by overriding the factory method and returning a different type of
        // product from it.
        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            // Now, use the product.
            var result = "Base Creator: The same base creator's code has just worked with "
                         + product.Operation();

            return result;
        }
    }
}