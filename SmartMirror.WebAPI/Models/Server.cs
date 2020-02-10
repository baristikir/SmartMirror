using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartMirror.WebAPI.Models
{
    public class Server
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isOnline { get; set; }
    }
}
