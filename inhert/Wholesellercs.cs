using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhert
{
    internal class Wholesellercs : Customer
    {
        string nichebuissness;
        public string Nichebuissness
        {
            get { return nichebuissness; }
            set { nichebuissness = value;}
        }

    }
}
