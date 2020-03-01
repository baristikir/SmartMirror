using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMirror.GUI_UWP.Weather
{
    public class HourlyForecastViewModel
    {
        public int Time { get; set; }
        public int Temperature { get; set; }
        public string Conditions { get; set; }
        public int Rainfall { get; set; }
        public int Snowfall { get; set; }
    }
}
