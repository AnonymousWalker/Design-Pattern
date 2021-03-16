using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.ChainOfResponsibility
{
    abstract class Handler
    {
        protected Handler nextHandler = null;
        public abstract void HandleRequest(int level);

        public void DoSomethingCommon(string name, int level)
        {
            Console.WriteLine("{0} handled the request: {1}.", name, level);
        }

        public void SetNext(Handler successor)
        {
            nextHandler = successor;
        }
    }
}
