using System;
abstract class abstractClass
{

    protected int myNumber;

    public abstract int numbers
    {
        get;
        set;
    }
}
class abstactDerived : abstractClass
{
    public override int numbers
    {
        get
        {
            return myNumber;
        }
        set
        {
            myNumber = value;
        }
    }
}

class main
{
    public static void Main()
    {
        abstactDerived d = new abstactDerived();
        d.numbers = 20;
        Console.WriteLine(d.numbers);
    }
}


