using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.WheterServices
{
    public class GeoLookupService
    {
        public Coordinates GetCoordinatesForZipCode(string zipCode)
        {
            return new Coordinates()
            {
                Latitude = 20.6736,
                Longitude = -103.344
            };
        }

        public class Coordinates
        {
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }

        public string GetCityForZipCode(string zipCode)
        {
            return "Guadalajara";
        }

        public string GetStateForZipCode(string zipCode)
        {
            return "Jalisco";
        }
    }
}
