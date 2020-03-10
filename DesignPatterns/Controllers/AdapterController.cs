using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Adapter.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [ApiController]
    public class AdapterController : ControllerBase
    {
        private readonly ILogger<AdapterController> _logger;
        private readonly IConfiguration _configuration;

        public AdapterController(ILogger<AdapterController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet("{source}")]
        [MapToApiVersion("1.0")]
        public async Task<ActionResult> Get(CharacterSource source)
        {
            try
            {                
                List<Character> people;
                if (source == CharacterSource.File)
                {
                    string filePath = @"../DesignPatterns/Structural/Adapter/Data/People.json";
                    people = JsonConvert.DeserializeObject<List<Character>>(await System.IO.File.ReadAllTextAsync(filePath));
                }
                else if (source == CharacterSource.Api)
                {
                    using (var client = new HttpClient())
                    {
                        string url = "https://someurl.com/api/characters";
                        string result = await client.GetStringAsync(url);
                        people = JsonConvert.DeserializeObject<ApiResult<Character>>(result).Results;
                    }
                }
                else
                {
                    throw new Exception("Invalid character source");
                }
                var sb = new StringBuilder();
                int nameWidth = 30;
                sb.AppendLine($"{"NAME".PadRight(nameWidth)}   {"BirthYear"}");
                foreach (Character character in people)
                {
                    sb.AppendLine($"{character.Name.PadRight(nameWidth)}   {character.BirthYear}");
                }

                return Ok(sb.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet]
        [MapToApiVersion("2.0")]
        public async Task<ActionResult> Get()
        {
            try
            {
                ICharacterSourceAdapter characterSourceAdapter = new CharacterFileSourceAdapter(_configuration["CharacterFilePath"], new CharacterFileSource());
                var people = await characterSourceAdapter.GetCharacters();
                var sb = new StringBuilder();
                int nameWidth = 30;
                sb.AppendLine($"{"NAME".PadRight(nameWidth)}   {"BirthYear"}");
                foreach (Character character in people)
                {
                    sb.AppendLine($"{character.Name.PadRight(nameWidth)}   {character.BirthYear}");
                }

                return Ok(sb.ToString());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}