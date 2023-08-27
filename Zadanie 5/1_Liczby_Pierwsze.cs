using System;

class Program
{
    static bool czyJestLiczbaPierwsza(int liczba)
    {
        if (liczba < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        Console.WriteLine("Podaj wartość n:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Pierwsze {n} liczb:");

        int ilosc = 0;
        int liczbaPierwsza = 2;

        while (ilosc < n)
        {
            if (czyJestLiczbaPierwsza(liczbaPierwsza))
            {
                Console.WriteLine(liczbaPierwsza);
                ilosc++;
            }

            liczbaPierwsza++;
        }
    }
}