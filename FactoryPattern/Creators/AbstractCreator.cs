using FactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Creators
{
    public abstract class AbstractCreator
    {
        public abstract AbstractProduct CreateProduct();
    }
}
