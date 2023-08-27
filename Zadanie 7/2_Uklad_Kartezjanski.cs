using System;

public class Program
{
    public static void Main()
    { 

        double x1 = 2.5;
        double y1 = 3.8;
        double x2 = 6.1;
        double y2 = 8.2;

        double dlugoscOdcinka = LiczDlugosc(x1, y1, x2, y2);

        Console.WriteLine("Długość odcinka wynosi: " + dlugoscOdcinka);

        Console.ReadLine();
    }

    public static double LiczDlugosc(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        double dlugosc = Math.Sqrt(dx * dx + dy * dy);

        return dlugosc;
    }
}