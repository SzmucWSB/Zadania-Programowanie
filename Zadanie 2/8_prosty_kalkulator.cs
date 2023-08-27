using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int x, y, z;
        Console.WriteLine("Podaj pierwszą liczbę");
        x = (int)inputValue();
        Console.WriteLine("Podaj drugą liczbę");
        y = (int)inputValue();
        Console.WriteLine("Podaj numer działania \n1 Dodawanie \n2 Odejmowanie \n3 Mnożenie \n4 Dzielenie");
        z = (int)inputValue();
        if(z==1)
        {
            Console.WriteLine( x + y);

        }
        else if (z == 2)
        {
            Console.WriteLine(x - y);

        }
        else if (z == 3)
        {
            Console.WriteLine(x * y);

        }
        else if(z == 4)
        {
            if (y == 0)
            {
                Console.WriteLine(x + "/" + y);
            }
            else
            {
                Console.WriteLine(x / y);
            }
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
