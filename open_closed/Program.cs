using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new PermanentEmployee(1, "madhavi");
            Employee emp2 = new TemporaryEmployee(2, "sam");

            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
                emp1.ToString(),
                emp2.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus: {1}",
              emp1.ToString(),
              emp2.CalculateBonus(150000).ToString()));
            Console.ReadLine();
        }
    }
}