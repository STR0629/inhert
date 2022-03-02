using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhert
{
    internal class Shortstorybook:Book
    {
        int no_of_stories;
        public int Noofstories
        {
            get { return no_of_stories; }
            set { no_of_stories = value; }
        }
    }
}
