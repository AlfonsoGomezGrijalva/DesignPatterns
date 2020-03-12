using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade.WheterServices
{
    public class EnglishMetricConverter
    {
        public double FarenheitToCelcious(double degrees)
        {
            return ((degrees - 32) / 9.0) * 5.0;
        }
    }
}
