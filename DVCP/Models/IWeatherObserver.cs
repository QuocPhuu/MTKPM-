using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DVCP.Models
{
    public interface IWeatherObserver
    {
        void Update(string temperature, string humidity, string weatherDescription);

    }
}