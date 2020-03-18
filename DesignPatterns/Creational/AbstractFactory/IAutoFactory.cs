using DesignPatterns.Creational.AbstractFactory.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public interface IAutoFactory
    {
        IAutomobile CreateSportCar();
        IAutomobile CreateSedanCar();
        IAutomobile CreateMuscleCar();
    }
}
