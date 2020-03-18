using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuilderController : ControllerBase
    {
        private readonly ILogger<BuilderController> _logger;
        private readonly IMapper _mapper;

        public BuilderController(ILogger<BuilderController> logger, IMapper mapper)
        {
            _logger = logger;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                List<ApiResult> results = new List<ApiResult>();
                var sandwichMaker = new SandwichMaker(new ClassicSandwich());
                sandwichMaker.BuildSandwich();
                results.Add(_mapper.Map<ApiResult>(sandwichMaker.GetSandwhich()));
                
                var sandwichMaker2 = new SandwichMaker(new ClubSandwich());
                sandwichMaker2.BuildSandwich();
                results.Add(_mapper.Map<ApiResult>(sandwichMaker2.GetSandwhich()));

                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}