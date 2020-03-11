using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Bridge
{
    public interface IFormatter
    {
        string Format(string key, string value);
    }
}
