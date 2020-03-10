using DesignPatterns.Structural.Adapter.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    public class CharacterApi
    {
        public async Task<List<Character>> GetCharacters()
        {
            using (var client = new HttpClient())
            {
                string url = "https://someurl.com/api/characters";
                string result = await client.GetStringAsync(url);
                var characters = JsonConvert.DeserializeObject<ApiResult<Character>>(result).Results;

                return characters;
            }
        }
    }
}
