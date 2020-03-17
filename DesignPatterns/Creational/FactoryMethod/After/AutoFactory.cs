using DesignPatterns.Creational.FactoryMethod.After.Autos;
using DesignPatterns.Creational.FactoryMethod.After.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.After
{
    public class AutoFactory
    {
        public IAutoFactory LoadFactory(string carName)
        {
            try
            {
                return (IAutoFactory)Activator.CreateInstance(Type.GetType($"DesignPatterns.Creational.FactoryMethod.After.Factories.{carName}Factory"));
            }
            catch
            {
                return UnknownCarFactory.Instance as IAutoFactory;
            }
        }
    }
}
