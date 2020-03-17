using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Before
{
    public class NullCar : IAuto
    {
        public string Name
        {
            get { return string.Empty; }
        }

        public string GetColor()
        {
            throw new NotImplementedException();
        }

        public int GetYear()
        {
            throw new NotImplementedException();
        }
    }
}
