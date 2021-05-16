using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.AbstractFactory
{
    class Audi : Car
    {
        public void Drive()
        {
            Console.WriteLine("Audi driving");
        }

        public string Model()
        {
            return "A8";
        }
    }
}
