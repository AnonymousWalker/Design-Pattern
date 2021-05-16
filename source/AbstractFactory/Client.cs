using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.source.AbstractFactory
{
    class Client
    {
        public void Use()
        {
            CarFactory toyotaFactory = new ToyotaFactory();
            Car camry = toyotaFactory.MakeCar();
            Part oem = toyotaFactory.MakePart();

            CarFactory audiFactory = new AudiFactory();
            Car a8 = audiFactory.MakeCar();
        }
    }
}
