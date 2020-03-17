using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Before
{
    public class ToyotaCorolla : IAuto
    {
        public string Name
        {
            get { return "Mini Cooper"; }
        }

        public string GetColor()
        {
            return "White";
        }

        public int GetYear()
        {
            return 2005;
        }
    }
}
