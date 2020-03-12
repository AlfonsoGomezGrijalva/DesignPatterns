using DesignPatterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Decorators.Types
{
    public class Cheese : PizzaDecorator
    {
        public Cheese(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
            Cost = 1.25;
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
