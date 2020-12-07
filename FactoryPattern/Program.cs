using FactoryPattern.Creators;
using FactoryPattern.Products;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractCreator[] creators = new AbstractCreator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach(AbstractCreator creator in creators)
            {
                AbstractProduct product = creator.CreateProduct();
                Console.WriteLine("Created {0}", product.GetType().Name);
            }

            Console.ReadKey();
        }
    }
}
