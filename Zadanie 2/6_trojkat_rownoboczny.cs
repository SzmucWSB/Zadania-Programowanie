using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a;
        Console.WriteLine("Podaj pierwszy bok: ");
        a = (int)inputValue();
        int b;
        Console.WriteLine("Podaj drugi bok: ");
        b = (int)inputValue();
        int c;
        Console.WriteLine("Podaj trzeci bok: ");
        c = (int)inputValue();
        if (a == b && b == c)
        {
            Console.WriteLine("Można utworzyć trójkąt równoboczny.");
        }
        else
        {
            Console.WriteLine("Nie można utworzyć trójkąta równobocznego.");
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
