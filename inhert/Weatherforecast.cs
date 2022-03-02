using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhert
{
    internal class Weatherforecast
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureCelcius { get; set; }
        public string Summary { get; set; }
    }
}
