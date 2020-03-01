using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interfaces;
namespace SmartMirror.WebAPI.Models
{
    public class Widget:Interfaces.Widget
    {
        public int WidgetId { get; set; }
        public string WidgetName { get; set; }
        private User User { get; set; }
        private User ApiToken { get; set; }
    }
}
