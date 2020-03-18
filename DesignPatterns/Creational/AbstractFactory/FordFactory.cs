using DesignPatterns.Creational.AbstractFactory.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class FordFactory : IAutoFactory
    {
        public IAutomobile CreateMuscleCar()
        {
            return new Mustang();
        }

        public IAutomobile CreateSedanCar()
        {
            return new Fusion();
        }

        public IAutomobile CreateSportCar()
        {
            return new FocusRS();
        }

    }
}
