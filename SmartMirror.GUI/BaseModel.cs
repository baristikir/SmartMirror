using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartMirror.GUI
{
    abstract class BaseModel : PropertyChangedBase
    {
        public abstract TimeSpan Interval { get; }

        public abstract Task Update();

        internal async void TimerTick(object sender, object e)
        {
            try
            {
                await Update();
            }
            catch
            {
                //If we had any mean to handle it, we would do it here
            }
        }
    }
}
