using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.Builder
{
    /*
     * A creational design pattern that lets you construct
     * complex objects step by step. The pattern allows you to
     * produce different types and representations of an object 
     * using the same construction code.
     * 
     * Note: the client can call the builder to build specific steps 
     * if it can interact with the builder. Having the director is 
     * a better way for reusable code and hiding implementation
     * of the builder.
     */
    class Client
    {
        public void Start()
        {
            // start up with builder 1
            RegularBuilder b1 = new RegularBuilder();
            var director = new ConstructionDirector(b1);
            director.MakeBuild(cash: 100);
            
            // collect product from builder 1
            RegularProduct product1 = b1.GetResult();
            Console.WriteLine(product1.Element);

            // now change the builder
            AdvancedBuilder b2 = new AdvancedBuilder();
            director.ChangeBuilder(b2);
            director.MakeBuild(cash: 2000);
            
            // products created by different builders 
            // don't have to be in the same interface/hierarchy
            AdvancedProduct product2 = b2.GetResult();
            Console.WriteLine(product2.Element);
        }
    }
}
