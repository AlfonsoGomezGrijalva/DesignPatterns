using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Component.Types
{
    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            Description = "Medium Pizza";
            Cost = 6.00;
        }

        public override double CalculateCost()
        {
            return Cost;
        }

        public override string GetDescription()
        {
            return Description;
        }
    }
}
