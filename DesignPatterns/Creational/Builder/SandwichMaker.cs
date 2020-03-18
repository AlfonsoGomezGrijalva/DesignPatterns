using DesignPatterns.Creational.Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public class SandwichMaker
    {
        private readonly SandwichBuilder builder;

        public SandwichMaker(SandwichBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildSandwich()
        {
            builder.CreateNewSandwich();
            builder.PrepareBread();
            builder.ApplyMeatAndCheese();
            builder.ApplyVegetables();
            builder.AddCondiments();
        }

        public Sandwich GetSandwhich()
        {
            return builder.GetSandwich();
        }
    }
}
