using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Option
    {
        /// <summary>
        /// Name der Option
        /// </summary>
        public string Name;
        /// <summary>
        /// Wert der Options
        /// </summary>
        public object value;
        /// <summary>
        /// gibt an,ob die Funktion benötigt wird
        /// </summary>
        public bool isRequired { get; private set; }
    }
}
