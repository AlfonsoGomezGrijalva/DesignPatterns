using DesignPatterns.Creational.AbstractFactory.Autos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class LoadFactory
    {
        public static IAutoFactory Load(string carName)
        {
           return (IAutoFactory)Activator.CreateInstance(Type.GetType($"DesignPatterns.Creational.AbstractFactory.{carName}Factory"));
        }
    }
}
