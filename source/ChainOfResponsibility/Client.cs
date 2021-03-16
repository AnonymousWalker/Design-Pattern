using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.ChainOfResponsibility
{
    /*
     * A behavioral design pattern that 
     * lets you pass requests along a chain of handlers. 
     * Upon receiving a request, each handler decides 
     * either to process the request or 
     * to pass it to the next handler in the chain.
     */
    class Client
    {
        public void Start()
        {
            Handler h1 = new Processor1();
            Handler h2 = new Processor2();
            Handler h3 = new Processor3();

            /* Client sets up the links (chains) among handlers */
            h1.SetNext(h2);
            h2.SetNext(h3);

            var requestLevels = new List<int> { -1, 0, 4, 27, 999 };

            foreach (var level in requestLevels)
            {
                h1.HandleRequest(level); // it can use any handler, not necessarily h1
            }
        }
    }
}
