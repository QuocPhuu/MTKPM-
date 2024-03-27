using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DVCP.Models
{
    public class WeatherDisplayObserver : IWeatherObserver
    {
        public void Update(string temperature, string humidity, string weatherDescription)
        {
            // Cập nhật thông tin dự báo thời tiết trên giao diện người dùng
            Console.WriteLine($"Temperature: {temperature}, Humidity: {humidity}, Weather Description: {weatherDescription}");
        }
    }
}