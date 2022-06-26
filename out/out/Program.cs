using System;

class Program
{

    static public void Main()
    {

        int G;

        Sum(out G);


        Console.WriteLine("The sum of" +
                " the value is: {0}", G);
    }

    public static void Sum(out int G)
    {

        G = 100;
        G += 100;
    }
}