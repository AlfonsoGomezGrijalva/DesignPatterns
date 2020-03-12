using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Component.Types
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            Description = "Small Pizza";
            Cost = 3.00;
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
