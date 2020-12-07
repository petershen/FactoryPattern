using FactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Creators
{
    public class ConcreteCreatorB : AbstractCreator
    {
        public override AbstractProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
