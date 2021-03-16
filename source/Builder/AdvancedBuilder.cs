using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.Builder
{
    class AdvancedBuilder : Builder
    {
        private AdvancedProduct product;
        public AdvancedBuilder()
        {
            product = new AdvancedProduct();
        }

        public void BuildBase()
        {
            product.Element = "Advanced base";
        }

        public void BuildRoof()
        {
            product.Element = "Advanced roof";
        }

        public void BuildWall()
        {
            product.Element = "Advanced wall";
        }

        public AdvancedProduct GetResult()
        {
            return product;
        }
    }

    class AdvancedProduct
    {
        private string element = "";
        public string Element
        {
            get { return element;  }
            set
            {
                element += value + "\n";
            }
        }
    }
}
