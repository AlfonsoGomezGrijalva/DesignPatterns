using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Facade.Model;
using DesignPatterns.Structural.Facade.WheterServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DesignPatterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacadeController : ControllerBase
    {
        private readonly ILogger<FacadeController> _logger;
        const string zipCode = "45050";

        public FacadeController(ILogger<FacadeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                GeoLookupService geoLookupService = new GeoLookupService();
                string result = string.Empty;

                var city = geoLookupService.GetCityForZipCode(zipCode);
                var state = geoLookupService.GetStateForZipCode(zipCode);
                var coords = geoLookupService.GetCoordinatesForZipCode(zipCode);

                WeatherService weatherService = new WeatherService();
                var farenheit = weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);

                EnglishMetricConverter englishMetricConverter = new EnglishMetricConverter();
                var celcius = englishMetricConverter.FarenheitToCelcious(farenheit);

                result = $"The current temperature is {farenheit.ToString("F1")}F/{celcius.ToString("F1")}C in {city}, {state}";
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{zipCode}")]
        public ActionResult Get(string zipCode)
        {                        
            try
            {
                string result = string.Empty;
                var temperatureFacade = new TemperatureLookupFacade();
                LocalTemperature localTemperature = temperatureFacade.GetTemperature(zipCode);

                result = $"The current temperature is {localTemperature.Farenheit.ToString("F1")}F/{localTemperature.Celcius.ToString("F1")}C in {localTemperature.City}, {localTemperature.State}";

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