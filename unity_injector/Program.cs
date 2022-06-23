using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
namespace DIUsingUnity
{
    public interface Ipayment
    {
        void display();
    }
    public class GpayL : Ipayment
    {
        public void display()
        {
            Console.WriteLine("You are using gpay");
        }
    }
    public class Phonepe : Ipayment
    {
        public void display()
        {
            Console.WriteLine("you are using phonepe");
        }
    }
    public class Customer
    {
        private Ipayment obj;
        public Customer(Ipayment dalobj)
        {
            obj = dalobj;
        }
        public void display()
        {
            obj.display();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer unityContainer = new UnityContainer();
            unityContainer.RegisterType<Customer>();
            unityContainer.RegisterType<Ipayment, Phonepe>();
            //unityContainer.RegisterType<Ipayment, OracleDAL>();
            Customer customer = unityContainer.Resolve<Customer>();
            customer.display();
            Console.ReadLine();
        }
    }
}
