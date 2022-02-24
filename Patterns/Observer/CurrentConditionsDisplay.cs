using System;

namespace Patterns.Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double _temperature;
        private double _humidity;
        private ISubject _weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(double temp, double humidity, double pressure)
        {
            _temperature = temp;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current condidtions: {_temperature} F degrees and {_humidity}% humidity");
        }
    }
}