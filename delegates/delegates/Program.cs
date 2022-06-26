using System;
namespace delegates

{
    class delegates_def
    {
        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        public void sum(int a, int b)
        {
            Console.WriteLine( a + b);
        }

        public void subtract(int a, int b)
        {
            Console.WriteLine( a - b);
        }
        public static void Main(String[] args)
        {

            delegates_def obj = new delegates_def();

            addnum del_obj1 = new addnum(obj.sum);
            subnum del_obj2 = new subnum(obj.subtract);

            del_obj1(10, 40);
            del_obj2(100, 60);

            //using invoke method
            // del_obj1.Invoke(100, 40);
            // del_obj2.Invoke(100, 60);
        }
    }
}