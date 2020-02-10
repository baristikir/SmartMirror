using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMirror.WebAPI.Models
{
    public class Widget
    {
        public int WidgetId { get; set; }
        public string WidgetName { get; set; }
        public User User { get; set; }
        public User ApiToken { get; set; }
    }
}
