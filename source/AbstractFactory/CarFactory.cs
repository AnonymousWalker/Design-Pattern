using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.AbstractFactory
{
    interface CarFactory
    {
        Car MakeCar();
        Part MakePart();
    }
}
