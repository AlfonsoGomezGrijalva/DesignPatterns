using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Model
{
    public class ApiResult
    {
        public Properties SedanCar { get; set; }
        public Properties SportCar { get; set; }
        public Properties MuscleCar { get; set; }
    }
}
