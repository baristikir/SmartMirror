using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Widget
    {
        /// <summary>
        /// Name der Api, zu welcher dieses Widget zuegordnet ist
        /// </summary>
        public string API_Name { get; private set; }
        /// <summary>
        /// Optionen die der Benutzer eingeben kann, zb. departure
        /// </summary>
        public Dictionary<string, Option> Options { get; private set; }
        /// <summary>
        /// Werte die das Widget besitzt, zb. Termin
        /// </summary>
        public Dictionary<string, Option> Values { get; private set; }
    }
}
