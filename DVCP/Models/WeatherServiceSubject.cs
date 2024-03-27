using DVCP.Models;
using System.Collections.Generic;

public class WeatherServiceSubject
{
    private List<IWeatherObserver> observers = new List<IWeatherObserver>();
    private string temperature;
    private string humidity;
    private string weatherDescription;

    public void Attach(IWeatherObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IWeatherObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature, humidity, weatherDescription);
        }
    }

    public void SetWeatherData(string temperature, string humidity, string weatherDescription)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.weatherDescription = weatherDescription;
        Notify(); // Thông báo cho các Observer khi có sự thay đổi
    }
}
