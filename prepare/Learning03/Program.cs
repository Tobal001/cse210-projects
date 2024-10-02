using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction ex = new Fraction();
        ex.SetTop(1);
        Console.WriteLine(ex.GetFractionString());
        Console.WriteLine(ex.GetDecimalValue());

        ex.SetTop(5);
        Console.WriteLine(ex.GetFractionString());
        Console.WriteLine(ex.GetDecimalValue());

        ex.SetTop(3);
        ex.SetBottom(4);
        Console.WriteLine(ex.GetFractionString());
        Console.WriteLine(ex.GetDecimalValue());

        ex.SetTop(1);
        ex.SetBottom(3);
        Console.WriteLine(ex.GetFractionString());
        Console.WriteLine(ex.GetDecimalValue());

        

    }
}