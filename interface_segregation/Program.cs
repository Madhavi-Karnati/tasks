using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace interface_segregation
{
    public interface IBaseWorker
    {
        void baseworker();

    }
    public interface IFullTimeWorkerSalary
    {
        void employeesalary();

    }
    public interface IContractWorkerSalary
    {
        void timeperiod();
    }
}
 internal class Program
{ 
        public static void Main(string[]args)
        {
        interface_segregation.Employee employee = new Employee();
            employee.baseworker();
            employee.employeesalary();
            employee.timeperiod();
        }

   }