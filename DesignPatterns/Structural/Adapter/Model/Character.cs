using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Structural.Adapter.Model
{

    public class Character
    {
        public virtual string Name { get; set; }
        public virtual string Gender { get; set; }
        public int BirthYear { get; set; }
        public string Height { get; set; }
    }

}
