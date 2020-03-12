using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Component
{
    public abstract class Pizza
    {
        public string Description { get; set; }
        public double Cost { get; set; }

        public abstract string GetDescription();
        public abstract double CalculateCost();

    }
}
