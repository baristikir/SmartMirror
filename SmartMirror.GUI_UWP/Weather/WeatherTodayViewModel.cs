using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMirror.GUI_UWP.Weather
{
    public class WeatherTodayViewModel : PropertyChangedBase
    {
        private bool initialized;
        public bool Initialized
        {
            get
            {
                return initialized;
            }
            set
            {
                if(initialized != value)
                {
                    initialized = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string lastUpdated;
        public string LastUpdated
        {
            get
            {
                return lastUpdated;
            }
            set
            {
                if (lastUpdated != value)
                {
                    lastUpdated = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string sunrise;
        public string Sunrise
        {
            get
            {
                return sunrise;
            }
            set
            {
                if (sunrise != value)
                {
                    sunrise = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string sunset;
        public string Sunset
        {
            get
            {
                return sunset;
            }
            set
            {
                if (sunset != value)
                {
                    sunset = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private WeatherModel model;

        internal void Initialize (WeatherModel model)
        {
            this.model = model;
            updateTimestamp();
            updateCurrentAndHourlyForecast();
            model.PropertyChanged += ModelPropertyChanged;
        }

        private void updateTimestamp()
        {

        }

        private void updateCurrentAndHourlyForecast()
        {

        }

        private void ModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(model.HourlyForecast))
            {
                updateTimestamp();
                updateCurrentAndHourlyForecast();
            }
            else if (e.PropertyName == nameof(model.Sunrise) || e.PropertyName == nameof(model.Sunset))
            {
                updateTimestamp();
            }
        }
    }
}
