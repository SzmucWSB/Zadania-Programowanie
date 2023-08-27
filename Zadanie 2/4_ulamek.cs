using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a;

        a = (int)inputValue();
        int b;

        b = (int)inputValue();
        int c;

        c = (int)inputValue();
        int d;

        d = (int)inputValue();
        int x;

        x = a * d + c * b;
        int y;

        y = b * d;
        if (b == 0 || d == 0)
        {
            Console.WriteLine("Brak rozwiązania");
        }
        else
        {
            Console.WriteLine("Ułamek wynosi: {0} / {1}", x, y);
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
