using DesignPatterns.Creational.FactoryMethod.After.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.After.Factories
{
    public class ToyotaFactory : IAutoFactory
    {
        public IAuto CreateAutomobile()
        {
            return new Toyota("Corolla LE");
        }
    }
}
