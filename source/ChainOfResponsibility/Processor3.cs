using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.ChainOfResponsibility
{
    class Processor3 : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level > 10 && level <= 100)
            {
                DoSomethingCommon("Processor#3", level);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
        }
    }
}
