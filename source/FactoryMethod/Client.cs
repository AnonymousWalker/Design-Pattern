using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.FactoryMethod
{
    class Client
    {
        /*
         * Factory Method separates product construction code from the code that actually uses the product
         * 
         * The product creator method is defined as abstract. It returns the product with type of an interface
         */
        public void Use()
        {
            TranslationFactory factory1 = new TextFactory();
            var productF1 = factory1.createTranslation();
            Console.WriteLine("Factory 1 (text) producing:");
            Console.WriteLine(productF1.Title());
            Console.WriteLine(productF1.Format());

            TranslationFactory factory2 = new AudioFactory();
            var productF2 = factory2.createTranslation();
            Console.WriteLine("Factory 2 (audio) producing:");
            Console.WriteLine(productF2.Title());
            Console.WriteLine(productF2.Format());
        }
    }
}
