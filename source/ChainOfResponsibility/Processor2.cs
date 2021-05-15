using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.ChainOfResponsibility
{
    class Processor2 : Handler
    {
        public override void HandleRequest(int level)
        {
            if (level > 1 && level <= 10)
            {
                Process("Processor#2", level);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(level);
            }
        }
    }
}
