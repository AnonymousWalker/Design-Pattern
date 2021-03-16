using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.Builder
{
    class RegularBuilder : Builder
    {
        private RegularProduct product;
        public RegularBuilder()
        {
            product = new RegularProduct();
        }

        public void BuildBase()
        {
            product.Element = "Regular base";
        }

        public void BuildRoof()
        {
            product.Element = "Regular roof";
        }

        public void BuildWall()
        {
            product.Element = "Regular wall";
        }

        public RegularProduct GetResult()
        {
            return product;
        }
    }
}

class RegularProduct
{
    private string element = "";
    public string Element
    {
        get { return element; }
        set
        {
            element += value + "\n";
        }
    }
}