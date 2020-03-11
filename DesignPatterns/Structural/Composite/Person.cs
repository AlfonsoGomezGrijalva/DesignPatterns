using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public class Person : IParty
    {
        public string Name { get; set; }
        public int Gold { get; set; }

        public string Stats()
        {
            return $"{Name} has {Gold} gold coins.";
        }
    }
}
