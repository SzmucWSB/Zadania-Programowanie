using System;

class Program
{
    static void Main(string[] args)
    {

        int rozmiar = 0;
        while (rozmiar <= 0)
        {
            Console.WriteLine("Podaj rozmiar tablicy kwadratowej");
            int.TryParse(Console.ReadLine(), out rozmiar);

            if (rozmiar <= 0)
            {
                rozmiar = 0;
                continue;
            }
        }

        int[,] tab1 = new int[rozmiar, rozmiar];

        for (int i = 0; i < rozmiar; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    tab1[i, j] = i * rozmiar + j + 1;
                }
            }
            else
            {
                for (int j = rozmiar - 1; j >= 0; j--)
                {
                    tab1[i, j] = (i + 1) * rozmiar - j;
                }
            }
        }

        int[,] tab2 = new int[rozmiar, rozmiar];
        int liczba = 1;
        int poczatekWiersza = 0, koniecWiersza = rozmiar - 1;
        int poczatekKolumny = 0, koniecKolumny = rozmiar - 1;

        while (liczba <= rozmiar * rozmiar)
        {
            for (int k = poczatekKolumny; k <= koniecKolumny; k++)
                tab2[poczatekWiersza, k] = liczba++;

            poczatekWiersza++;

            for (int k = poczatekWiersza; k <= koniecWiersza; k++)
                tab2[k, koniecKolumny] = liczba++;

            koniecKolumny--;

            for (int k = koniecKolumny; k >= poczatekKolumny; k--)
                tab2[koniecWiersza, k] = liczba++;

           koniecWiersza--;

            for (int k = koniecWiersza; k >= poczatekWiersza; k--)
                tab2[k, poczatekKolumny] = liczba++;

            poczatekKolumny++;
        }

        Console.WriteLine("Tablica wypełniona według schematu z zadania 1:");
        for (int i = 0; i < rozmiar; i++)
        {
            for (int j = 0; j < rozmiar; j++)
            {
                Console.Write("{0,4}", tab1[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        Console.WriteLine("Tablica wypełniona według schematu z zadania 2:");
        Console.WriteLine();
        for (int k = 0; k < rozmiar; k++)
        {
            for (int l = 0; l < rozmiar; l++)
                Console.Write("{0,4}", tab2[k, l]);

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}