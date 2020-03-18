using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Autos
{
    public class Mustang : FordBase
    {
        public override string GetName()
        {
            return "Mustang GT";
        }
    }
}
