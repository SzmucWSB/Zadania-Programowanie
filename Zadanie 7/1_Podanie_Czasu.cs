using System;

public class FormatowanieCzasu
{
    public static void Main()
    {
        Console.WriteLine("Podaj czas w sekundach: ");
        string podajSekundy = Console.ReadLine();
        int czasWSekundach;

        if (int.TryParse(podajSekundy, out czasWSekundach))
        {
            string sformatowanyCzas = FormatujCzas(czasWSekundach);
            Console.WriteLine(sformatowanyCzas);
        }
        else
        {
            Console.WriteLine("Błędny format czasu. Podaj liczbę całkowitą.");
        }

        Console.ReadLine();
    }

    public static string FormatujCzas(int czasWSekundach)
    {
        int godziny = czasWSekundach / 3600;
        int minuty = (czasWSekundach % 3600) / 60;
        int sekundy = czasWSekundach % 60;

        return $"Sformatowana godzina: {godziny:00}:{minuty:00}:{sekundy:00}";
    }
}