using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMirror.GUI.Clock
{
    public class ClockViewModel : PropertyChangedBase
    {
        private ClockModel model;

        // Property for the time which will be displayed later
        private string currentTime { get; set; }
        public string CurrentTime
        {
            get
            {
                return currentTime;
            }
            set
            {
                if (currentTime != value)
                {
                    currentTime = value;
                    NotifyPropertyChanged();
                }
            }
        } 


        // Property for the date which will be displayed later
        private string currentDate { get; set; }
        public string CurrentDate
        {
            get
            {
                return currentDate;
            }
            set
            {
                if (currentDate != value)
                {
                    currentDate = value;
                    NotifyPropertyChanged();
                }
            }
        }


        // Initialize Method for the created instance from the app.xaml. Therefore no constructor code is needed
        internal void Initialize(ClockModel model)
        {
            this.model = model;
            updateTime();
            model.PropertyChanged += ModelPropertyChanged;
        }

        private void ModelPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(model.CurrentTime))
            {
                updateTime();
            }
        }

        private void updateTime()
        {
            CurrentTime = model.CurrentTime.ToString("h:mm");
            //CurrentDate = model.CurrentDate.ToString("MMMM d");
        }
    }
}
