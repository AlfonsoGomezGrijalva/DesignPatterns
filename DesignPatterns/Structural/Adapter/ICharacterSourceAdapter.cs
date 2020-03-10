using DesignPatterns.Structural.Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public interface ICharacterSourceAdapter
    {
        Task<IEnumerable<Character>> GetCharacters();
    }
}
