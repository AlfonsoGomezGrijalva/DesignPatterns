using DesignPatterns.Structural.Adapter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class CharacterApiSourceAdapter : ICharacterSourceAdapter
    {
        private CharacterApi _characterFromApi;
        public CharacterApiSourceAdapter(CharacterApi characterFromApi)
        {
            _characterFromApi = characterFromApi;
        }

        public async Task<IEnumerable<Character>> GetCharacters()
        {
            return await _characterFromApi.GetCharacters();
        }
    }
}
