using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution
{
    class Program
    {
        static void Main(string[] args)
        {
                List<IEmployee> employeesOnly = new List<IEmployee>();

                employeesOnly.Add(new PermanentEmployee(1, "Madhavi"));
                employeesOnly.Add(new temporaryEmployee(2, "Sam"));
                employeesOnly.Add(new ContractEmployee(3, "Ram"));

                foreach (var employee in employeesOnly)
                {
                Console.WriteLine(string.Format("Employee {0}  MinSalary: {1}",
                employee.ToString(),
                employee.GetMinimumSalary().ToString()));
            }
                Console.ReadLine();
            }
        }
    }