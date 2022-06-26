using System;
namespace enum1
{
    class a
    {
        enum Enames
        {
            Harish,    // 0
            Suresh,   // 1
            Saji,      // 2
            harshi,      // 3
            
        }

        public static void Main(string[] args)
        {
            int myNum = (int)Enames.Saji;
            Console.WriteLine(myNum);
        }
    }
 }
