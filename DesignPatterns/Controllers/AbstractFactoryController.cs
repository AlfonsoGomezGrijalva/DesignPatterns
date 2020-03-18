using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.AbstractFactory.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AbstractFactoryController : ControllerBase
    {
        private readonly ILogger<AbstractFactoryController> _logger;

        public AbstractFactoryController(ILogger<AbstractFactoryController> logger)
        {
            _logger = logger;
        }

        public ActionResult Get()
        {
            try
            {
                ApiResult result = new ApiResult();
                IAutoFactory factory = LoadFactory.Load("Ford");
                
                var muscleCar = factory.CreateMuscleCar();
                result.MuscleCar = new Properties { Name = muscleCar.GetName(), Color = muscleCar.GetColor(), Year = muscleCar.GetYear() };
                
                var sedanCar = factory.CreateSedanCar();
                result.SedanCar = new Properties { Name = sedanCar.GetName(), Color = sedanCar.GetColor(), Year = sedanCar.GetYear() };

                var sportCar = factory.CreateSportCar();
                result.SportCar = new Properties { Name = sportCar.GetName(), Color = sportCar.GetColor(), Year = sportCar.GetYear() };
                
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