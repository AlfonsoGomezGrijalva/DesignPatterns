using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Structural.Decorator.Component;
using DesignPatterns.Structural.Decorator.Component.Types;
using DesignPatterns.Structural.Decorator.Decorators.Types;
using DesignPatterns.Structural.Decorator.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecoratorController : ControllerBase
    {
        private readonly ILogger<DecoratorController> _logger;

        public DecoratorController(ILogger<DecoratorController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                PizzaResult result = new PizzaResult();
                Pizza mediumPizza = new MediumPizza();
                mediumPizza = new Cheese(mediumPizza);
                mediumPizza = new Ham(mediumPizza);
                mediumPizza = new Bacon(mediumPizza);

                result.Description = mediumPizza.GetDescription();
                result.Cost = mediumPizza.CalculateCost();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}