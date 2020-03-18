using DesignPatterns.Creational.Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Builders
{
    public class ClubSandwich : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = true;
            sandwich.HasMustard = true;
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.MeatType = MeatType.Ham;
            sandwich.CheeseType = CheeseType.Cheddar;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Onion", "Lettuce" };
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
            sandwich.IsToasted = true;
        }
    }
}
