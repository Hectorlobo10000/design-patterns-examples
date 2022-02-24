using System.Collections.Generic;

namespace Patterns.Observer
{
    public class WeatherData : ISubject
    {
        private List<IObserver> _observers;
        private double _temperature;
        private double _humidity;
        private double _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            var index = _observers.IndexOf(o);
            if (index >= 0)
            {
                _observers.RemoveAt(index);
            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }


        public void SetMeasurements(double temp, double huminity, double pressure)
        {
            _temperature = temp;
            _humidity = huminity;
            _pressure = pressure;
            MeasurementsChanged();
        }
    }
}