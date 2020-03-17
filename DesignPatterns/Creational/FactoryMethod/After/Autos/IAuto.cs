using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.After.Autos
{
    public interface IAuto
    {
        string Name { get; }
        string GetColor();
        int GetYear();
        void SetName(string name);
    }
}
