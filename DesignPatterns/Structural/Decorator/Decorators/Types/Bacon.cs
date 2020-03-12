using DesignPatterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Decorators.Types
{
    public class Bacon : PizzaDecorator
    {
        public Bacon(Pizza pizza) : base(pizza)
        {
            Description = "Bacon";
            Cost = 2.25;
        }

        public override double CalculateCost()
        {
            return _pizza.CalculateCost() * Cost;
        }


        public override string GetDescription()
        {
            return $"{_pizza.GetDescription()}, {Description}";
        }
    }
}
