using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.AbstractFactory
{
    class BMWFactory : CarFactory
    {
        public Car MakeCar()
        {
            return new BMW();
        }

        public Part MakePart()
        {
            return new BMWPart();
        }
    }
}
