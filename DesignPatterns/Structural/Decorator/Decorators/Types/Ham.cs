using DesignPatterns.Structural.Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator.Decorators.Types
{
    public class Ham : PizzaDecorator
    {
        public Ham(Pizza pizza) : base(pizza)
        {
            Description = "Ham";
            Cost = 1.00;
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
