using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.AbstractFactory
{
    class Toyota : Car
    {
        public void Drive()
        {
            Console.WriteLine("Toyota driving");
        }

        public string Model()
        {
            return "Camry";
        }
    }
}
