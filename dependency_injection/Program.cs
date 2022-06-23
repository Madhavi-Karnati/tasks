using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DependencyInjectionExample
{
    public class Ihotel
    {
        public int bill { get; set; }
        public string Menue_item { get; set; }
       
    }
    public interface IhotelDAL
    {
       List<Ihotel> SelectAll();
    }
    public class hotelDAL : Ihotel
    {
        public static List<Ihotel> SelectAll()
        {
            List<Ihotel> Listitems = new List<Ihotel>();
            Listitems.Add(new Ihotel() { bill = 40, Menue_item = "Poori",});
            Listitems.Add(new Ihotel() { bill = 60, Menue_item = "paratha" });
            Listitems.Add(new Ihotel() { bill = 30, Menue_item = "chapathi"});
            return Listitems;
        }
    }
    public class hotelBL:hotelDAL
    {
        public IhotelDAL hotelDAL;
        public hotelBL(IhotelDAL hotelDAL)
        {
            this.hotelDAL = hotelDAL;
        }
        public List<Ihotel> GetAll()
        {
            return hotelDAL.SelectAll();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            hotelBL BL = new hotelBL(hotelDAL());
            List<Ihotel> Listitems = hotelBL.GetAll();
            foreach (Ihotel obj in Listitems)
            {
                Console.WriteLine("bill = {0}, menue_items = {1}", obj.bill, obj.Menue_items);
            }
            Console.ReadKey();
        }
    }
}
