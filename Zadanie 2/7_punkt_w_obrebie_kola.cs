using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x;
        Console.WriteLine("Podaj pierwszą współrzedną(x)");
        x = inputValue();
        double y;
        Console.WriteLine("Podaj drugą współrzedną(y)");
        y = inputValue();
        double a;

        a = 0;
        double b;

        b = 0;
        double r;
        Console.WriteLine("Podaj promień koła");

        r = inputValue();
        if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) == Math.Pow(r, 2))
        {
            Console.WriteLine("Punkt P leży w obrębie koła");
        }
        else
        {
            Console.WriteLine("Punkt P nie leży w obrębie koła");
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
