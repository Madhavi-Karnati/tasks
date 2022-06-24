using System;
using System.Linq;
namespace ParallelLINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = Enumerable.Range(1, 20);

            var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Even Numbers Between 1 and 20");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}