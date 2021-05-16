using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.AbstractFactory
{
    class BMW : Car
    {
        public void Drive()
        {
            Console.WriteLine("BMW driving");
        }

        public string Model()
        {
            return "200";
        }
    }
}
