using System;
namespace AccessSpecifiers
{
    class Program
    {
        int total = 0;
          
        public void Show(params int[] val)  
        {
            for (int i = 0; i < val.Length; i++)
            {
                total=total + val[i];
                Console.WriteLine(total);
            }
        }
         
        static void Main(string[] args)
        {
            Program program = new Program(); 
            program.Show(100,375,869,3647);  
        }
    }
}
