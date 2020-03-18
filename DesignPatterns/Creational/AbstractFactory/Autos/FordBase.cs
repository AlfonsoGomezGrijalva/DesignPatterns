using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Autos
{
    public abstract class FordBase : IAutomobile
    {
        public abstract string GetName();

        public string GetColor()
        {
            return "Blue";
        }

        public int GetYear()
        {
            return 2018;
        }
    }
}
