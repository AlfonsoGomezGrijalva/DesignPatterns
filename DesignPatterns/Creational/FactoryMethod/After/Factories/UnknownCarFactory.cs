using DesignPatterns.Creational.FactoryMethod.After.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.After.Factories
{
    public class UnknownCarFactory : IAutoFactory
    {
        private static UnknownCarFactory _instance;
        private UnknownCarFactory()
        {

        }

        public static UnknownCarFactory Instance 
        {
            get
            {
                if (_instance == null)
                    return new UnknownCarFactory();
                return _instance;
            }

        }
        public IAuto CreateAutomobile()
        {
            return new UnknownCar("Unknown");
        }
    }
}
