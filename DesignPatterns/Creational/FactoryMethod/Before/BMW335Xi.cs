using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Before
{
    public class BMW335Xi : IAuto
    {
        public string Name
        {
            get { return "BMW 335Xi"; }
        }

        public string GetColor()
        {
            return "Red";
        }

        public int GetYear()
        {
            return 2010;
        }
    }
}
