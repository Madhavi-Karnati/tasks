using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo;

namespace single_responsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            businessunit bu = new businessunit();
            jobclassification jc = new jobclassification();
            payscale p = new payscale();
            emp.businessunit();
            emp.jobclassification();
            emp.payscale();
            bu.businessunitmethod();
            jc.jobclassificationmethodd();
            p.payscalemethod();


        }
    }
}
