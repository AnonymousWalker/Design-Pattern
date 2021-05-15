using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.ChainOfResponsibility
{
    class Processor1 : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level >= 0 && level <= 1)
            {
                // processing logic goes here
                // e.g. DoSomeThingSpecific()

                Process("Processor#1", level);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
        }
    }
}
