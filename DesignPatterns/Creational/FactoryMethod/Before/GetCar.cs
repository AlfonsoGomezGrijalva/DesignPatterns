using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Before
{
    public class GetCar
    {
        public IAuto GetCarByName(string carName)
        {
            switch (carName)
            {
                case "bmw":
                    return new BMW335Xi();
                case "mini":
                    return new ToyotaCorolla();
                case "audi":
                    return new AudiTTS();
                default:
                    return new NullCar();
            }
        }
    }
}
