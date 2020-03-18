using DesignPatterns.Creational.Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Builders
{
    public class ClassicSandwich : SandwichBuilder
    {
        public override void AddCondiments()
        {
            sandwich.HasMayo = true;
            sandwich.HasMustard = true;
        }

        public override void ApplyVegetables()
        {
            sandwich.Vegetables = new List<string> { "Tomato", "Lettuce" };
        }

        public override void ApplyMeatAndCheese()
        {
            sandwich.CheeseType = CheeseType.American;
            sandwich.MeatType = MeatType.Ham;
        }

        public override void PrepareBread()
        {
            sandwich.BreadType = BreadType.White;
            sandwich.IsToasted = false;
        }
    }
}
