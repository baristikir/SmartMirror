using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMirror.GUI_UWP.Weather
{
    public class WeatherDetailsModel
    {
        public DateTime Time { get; set; }
        public int? Temperature { get; set; }
        public int? TemperatureHigh { get; set; }
        public int? TemperatureLow { get; set; }
        public int? Rainfall { get; set; }
        public int? Snowfall { get; set; }
        public string Conditions { get; set; }

        public override string ToString()
        {
            return $"{Time.ToString("dddd, d h:mm")}: {Conditions}";
        }
    }
}
