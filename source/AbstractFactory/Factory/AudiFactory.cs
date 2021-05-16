using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.AbstractFactory
{
    class AudiFactory : CarFactory
    {
        public Car MakeCar()
        {
            return new Audi();
        }

        public Part MakePart()
        {
            return new AudiPart();
        }
    }
}
