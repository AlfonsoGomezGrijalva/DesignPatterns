using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Creational.FactoryMethod.After;
using DesignPatterns.Creational.FactoryMethod.After.Factories;
using DesignPatterns.Creational.FactoryMethod.Before;
using DesignPatterns.Creational.FactoryMethod.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactoryMethodController : ControllerBase
    {
        private readonly ILogger<FactoryMethodController> _logger;

        public FactoryMethodController(ILogger<FactoryMethodController> logger)
        {
            _logger = logger;
        }

        [HttpPost("{carName}")]
        public ActionResult Post(string carName)
        {
            try
            {
                GetCar getCar = new GetCar();
                ApiResult result = new ApiResult();
                IAuto car = getCar.GetCarByName(carName);
                if (car is NullCar)
                    return NotFound();

                result.CarName = car.Name;
                result.Color = car.GetColor();
                result.Year = car.GetYear();

                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{carName}")]
        public ActionResult Get(string carName)
        {
            try
            {
                AutoFactory autoFactory = new AutoFactory();
                ApiResult result = new ApiResult();
                IAutoFactory factory = autoFactory.LoadFactory(carName);
                if (factory is UnknownCarFactory) return NotFound();
                Creational.FactoryMethod.After.Autos.IAuto car = factory.CreateAutomobile();                             
                result.CarName = car.Name;
                result.Color = car.GetColor();
                result.Year = car.GetYear();
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