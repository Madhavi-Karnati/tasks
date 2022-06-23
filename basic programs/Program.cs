using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace extensions
{ 
 public static class Program1
    {
        public static void Main(String[]args)
        {
        int num1 = 2345;
        int result = num1.count_digits();
        Console.WriteLine("number of digits is " +result);
        }
    }
}
