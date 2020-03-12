using DesignPatterns.Structural.Facade.Model;
using DesignPatterns.Structural.Facade.WheterServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    public class TemperatureLookupFacade
    {
        private readonly WeatherService _weatherService;
        private readonly GeoLookupService _geoLookupService;
        private readonly EnglishMetricConverter _englishMetricConverter;

        public TemperatureLookupFacade()
            : this(new WeatherService(), new GeoLookupService(), new EnglishMetricConverter())
        {

        }

        public TemperatureLookupFacade(WeatherService weatherService, GeoLookupService geoLookupService, EnglishMetricConverter englishMetricConverter)
        {
            _weatherService = weatherService;
            _geoLookupService = geoLookupService;
            _englishMetricConverter = englishMetricConverter;
        }

        public LocalTemperature GetTemperature(string zipCode)
        {
            var coords = _geoLookupService.GetCoordinatesForZipCode(zipCode);
            var city = _geoLookupService.GetCityForZipCode(zipCode);
            var state = _geoLookupService.GetStateForZipCode(zipCode);

            var farenheit = _weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);
            var celcius = _englishMetricConverter.FarenheitToCelcious(farenheit);

            return new LocalTemperature() { Farenheit = farenheit, Celcius = celcius, City = city, State = state };
        }
    }
}
