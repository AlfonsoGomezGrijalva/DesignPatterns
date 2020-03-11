﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    public interface IParty
    {
        public int Gold { get; set; }
        string Stats();
    }
}