using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using var_dynamic;

namespace var_dynamic
{
    class compile
    {
        public static void Main(String[] args)
        {
            var varInt = 1;
            var varChar = 'a';
            var varString = "abcdef";
            Console.WriteLine("{0}\n{1}\n{2}", varInt,varChar, varString);
            Console.WriteLine(varInt.GetType());
            Console.WriteLine(varChar.GetType());
            Console.WriteLine(varString.GetType());
            Console.WriteLine("-----------------------------------");
            //var abc = Console.ReadLine();
            ////dynamic num;
            Console.WriteLine("array----------------------");
            dynamic[] b = { 'a', 1, 1.04, "madhavi" };
            foreach (dynamic d in b)
                Console.WriteLine(d.GetType());

        }
    }
}