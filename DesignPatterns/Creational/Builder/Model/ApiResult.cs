using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder.Model
{
    public class ApiResult
    {
        public string BreadType { get; set; }
        public bool IsToasted { get; set; }
        public string CheeseType { get; set; }
        public string MeatType { get; set; }
        public bool HasMustard { get; set; }
        public bool HasMayo { get; set; }
        public List<string> Vegetables { get; set; }
    }
}
