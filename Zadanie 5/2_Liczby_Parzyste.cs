using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę parzystych liczb do wylosowania (n)");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Metoda nr  1:");
        Random random = new Random();
        int iloscLosowan1 = 0;
        int iloscLiczb1 = 0;
        while (iloscLiczb1 < n)
        {
            int liczba = random.Next(-8, 9);
            iloscLosowan1++;
            if (liczba % 2 == 0)
            {
                Console.Write(liczba);
                iloscLiczb1++;
                if (iloscLiczb1 < n)
                {
                    Console.Write(", ");
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Ilość losowań (metoda nr  1): " + iloscLosowan1);

        Console.WriteLine();
        Console.WriteLine("Metoda nr  2:");
        int iloscLosowan2 = 0;
        int iloscLiczb2 = 0;
        while (iloscLiczb2 < n)
        {
            int liczba = random.Next(-4, 5) * 2;
            iloscLosowan2++;
            Console.Write(liczba);
            iloscLiczb2++;
            if (iloscLiczb2 < n)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
        Console.WriteLine("Ilość losowań (metoda nr 2): " + iloscLosowan2);

        Console.ReadLine();
    }
}