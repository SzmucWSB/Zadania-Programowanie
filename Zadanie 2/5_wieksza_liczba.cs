using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Podaj pierwszą liczbę");
        a = (int)inputValue();
        int b;
        Console.WriteLine("Podaj drugą liczbę");
        b = (int)inputValue();
        if (a > b)
        {
            Console.WriteLine("Większa liczba to: " + a);
        }
        else if(a < b)
        {
            Console.WriteLine("Większa liczba to: " + b);
        }else
        {
            Console.WriteLine("Liczby są takie same");
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
