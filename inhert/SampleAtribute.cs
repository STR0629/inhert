using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhert
{
    [Author("GOJO", Version = 1.1)]
    //[Author("Raj",Version =1.2)]
    internal class SampleAtribute
    {
        public static void CallGetAtribute()
        {
            GetAttribute(typeof(SampleAtribute));
        }
        public static void GetAttribute(Type t)
        {
            // Get instance of the attribute.
            AuthorAttribute MyAttribute =
                (AuthorAttribute)Attribute.GetCustomAttribute(t, typeof(AuthorAttribute));

            if (MyAttribute == null)
            {
                Console.WriteLine("The attribute was not found.");
            }
            else
            {
                // Get the Author value.
                Console.WriteLine("The Author Attribute is: {0}.", MyAttribute.Author);
                // Get the Version value.
                Console.WriteLine("The Version Attribute is: {0}.", MyAttribute.Version);

            }
        }


    }
}
