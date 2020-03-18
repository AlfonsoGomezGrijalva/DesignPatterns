using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory.Autos
{
    public interface IAutomobile
    {
        string GetName();
        string GetColor();
        int GetYear();
    }
}
