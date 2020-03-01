using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMirror.GUI_UWP
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
                //Handling here, if needed
            }
        }
    }
}
