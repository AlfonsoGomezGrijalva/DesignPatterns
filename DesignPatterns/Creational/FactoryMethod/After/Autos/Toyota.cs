using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.After.Autos
{
    public class Toyota : IAuto
    {
        public Toyota(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }

        public string GetColor()
        {
            return "Red";
        }

        public int GetYear()
        {
            return 2015;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            Name = name;

        }
    }
}
