using System;
class Program
{
    public static void Main(String[]args)
    {
        string str = "Madhavi";

        SetValue(ref str);

        Console.WriteLine(str);
    }

    static void SetValue(ref string str1)
    {
        if (str1 == "Madhavi")
        {
            Console.WriteLine("Hi Madhavi");
        }

        str1 = "Good Afternoon";
    }
}