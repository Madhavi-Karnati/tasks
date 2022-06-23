using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_substitution
{
   
        public class temporaryEmployee : Employee
        {
            public temporaryEmployee()
            {

            }
            public temporaryEmployee(int id, string name) : base(id, name)
            { }
            public override decimal CalculateBonus(decimal salary)
            {
                return (salary * .05M);
            }
             public override decimal GetMinimumSalary()
            {
            return 5000;
             }
       }
 }
