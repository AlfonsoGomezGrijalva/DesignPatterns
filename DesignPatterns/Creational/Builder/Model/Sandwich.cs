using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Model
{
    public class Sandwich
    {
        public BreadType BreadType { get; set; }
        public bool IsToasted { get; set; }
        public CheeseType CheeseType { get; set; }
        public MeatType MeatType { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public List<string> Vegetables { get; set; }
    }

    public enum MeatType
    {
        Turkey,
        Ham,
        Chicken,
        Salami
    }

    public enum CheeseType
    {
        American,
        Swiss,
        Cheddar,
        Provolone,
        None
    }

    public enum BreadType
    {
        White,
        Wheat
    }
}
