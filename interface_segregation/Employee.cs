using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_segregation
{
    class Employee : IBaseWorker, IFullTimeWorkerSalary, IContractWorkerSalary
    {

        void IBaseWorker.baseworker()
        {
            Console.WriteLine("base worker");
        }


        void IFullTimeWorkerSalary.employeesalary()
        {
            Console.WriteLine("permanent employee");
        }
        void IContractWorkerSalary.timeperiod()
        {
            Console.WriteLine("outsourcing person");
        }
    }
}
