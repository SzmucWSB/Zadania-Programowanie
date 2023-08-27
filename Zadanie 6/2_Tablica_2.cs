using System;

class Program
{
    static void Main(string[] args)
    {
     
        int[,] tab = new int[10, 10];
        int liczba = 1;
        int poczatekWiersza = 0, koniecWiersza = 9;
        int poczatekKolumny = 0, koniecKolumny = 9;

        while (liczba <= 100)
        {
            for (int i = poczatekKolumny; i <= koniecKolumny; i++)
                tab[poczatekWiersza, i] = liczba++;

            poczatekWiersza++;

            for (int i = poczatekWiersza; i <= koniecWiersza; i++)
                tab[i, koniecKolumny] = liczba++;

            koniecKolumny--;

            for (int i = koniecKolumny; i >= poczatekKolumny; i--)
                tab[koniecWiersza, i] = liczba++;

            koniecWiersza--;

            for (int i = koniecWiersza; i >= poczatekWiersza; i--)
                tab[i, poczatekKolumny] = liczba++;

            poczatekKolumny++;
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
                Console.Write("{0,4}", tab[i, j]);

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}