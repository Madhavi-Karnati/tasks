using System;
public static class Calculator
{
    public static int _resultStorage = 0;


    public static string Type = "Arithmetic";
    public static int num1 = 3;
    public static int num2 = 4;

    static Calculator()
        {

        Console.WriteLine("you are inside the static constructor");
        }
public static int Sum(int num1, int num2)
    {
        Console.WriteLine("static method is being called");
        Console.WriteLine("num1 is " + num1);
        Console.WriteLine("num2 is " + num2);
        return num1 + num2;
    }
    public static void Store(int result)
    {
        _resultStorage = result;
    }
}
    
class Program
{
    static void Main(string[] args)
    {
        var result = Calculator.Sum(10, 25);
       
        Calculator.Store(result);
        Console.WriteLine("result is " + result);
        var calcType = Calculator.Type;
        Calculator.Type = "Scientific";
        Console.WriteLine("result is " + calcType);
    }
}