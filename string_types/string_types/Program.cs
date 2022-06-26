using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_types
{
    internal class Program
    {
        static void Main(string[] args)
        {

            {
                //string and String
                string s = "Hello ";
                string t = "World";
                Console.WriteLine("printing ");
                Console.WriteLine(s);
                Console.WriteLine(t);
                Console.WriteLine("on concatenating using string class");
                string st = String.Concat(s, t);
                Console.WriteLine(st);


                // stringbuilder and string class
                StringBuilder sb = new StringBuilder();

                sb.Append("Hello ");

                sb.AppendLine("World");

                sb.AppendLine("This is last line");

                Console.WriteLine(sb);

                // difference between tostring and convert.tostring()
                int myAge = 104;
                Console.WriteLine(".ToString() : " + myAge.ToString());
                Console.WriteLine("Convert.ToString() :" + Convert.ToString(myAge));

                Console.WriteLine(  "--------------------------------------------");
                string myName = null; 
                Console.WriteLine(".ToString() : " + myName.ToString());
                Console.WriteLine("Convert.ToString() :" + Convert.ToString(myName));

            }
        }
    }
}
