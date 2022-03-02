using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhert
{
    internal class Distributers:Customer
    {
        string area;
        public string Area
        {
            get { return area; }
            set { area = value; }
        }

    }
}
