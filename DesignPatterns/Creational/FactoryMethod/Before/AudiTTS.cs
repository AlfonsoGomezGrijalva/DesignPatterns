using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.FactoryMethod.Before
{
    public class AudiTTS : IAuto
    {
        public string Name
        {
            get { return "Audi TTS"; }
        }

        public string GetColor()
        {
            return "gray";
        }

        public int GetYear()
        {
            return 2014;
        }        
    }
}
