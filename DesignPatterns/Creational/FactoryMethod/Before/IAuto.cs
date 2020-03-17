using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Before
{
    public interface IAuto
    {
        string Name { get; }
        string GetColor();
        int GetYear();
    }
}
