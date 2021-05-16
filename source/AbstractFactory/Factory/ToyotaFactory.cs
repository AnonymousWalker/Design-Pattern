using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.AbstractFactory
{
    class ToyotaFactory : CarFactory
    {
        public Car MakeCar()
        {
            return new Toyota();
        }

        public Part MakePart()
        {
            return new ToyotaPart();
        }
    }
}
