using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.After.Autos
{
    public class Audi : IAuto
    {
        public Audi(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }

        public string GetColor()
        {
            return "Black";
        }

        public int GetYear()
        {
            return 2019;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");

            Name = name;
        }
    }
}
