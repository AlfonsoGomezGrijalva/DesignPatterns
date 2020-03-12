using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Component.Types
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "LargePizza";
            Cost = 9.0;
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
