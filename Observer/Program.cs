using System;
using Patterns.Observer;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            
            var currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            var forecastDisplay = new ForecastDisplay(weatherData);
            
            weatherData.SetMeasurements(80, 65, 30.4f);
        }
    }
}