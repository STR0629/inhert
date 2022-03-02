using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhert
{
    [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct,
                       AllowMultiple = true)]  // multiuse attribute  
    internal class AuthorAttribute:Attribute
    {

        private string _author;
        public string Author { get { return _author; } }
        public double Version { get; set; }
        public AuthorAttribute(string author)
        {
            _author = author;
            Version = 1.0;
        }
    }
}
