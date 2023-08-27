using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int rOZMIAR = 10;
        int[] tab = new int[rOZMIAR];

        for (int i = 0; i < rOZMIAR; i++)
        {
            tab[i] = rnd.Next(100);
            Console.WriteLine(tab[i]);
        }
        Console.WriteLine();

        for (int i = 0; i < tab.Length - 1; i++)
        {
            int minElement = i;

            for (int j = i + 1; j < tab.Length; j++)
            {
                if (tab[j] < tab[minElement])
                {
                    minElement = j;
                }
            }

            if (minElement != i)
            {
                int tymczasowa = tab[i];
                tab[i] = tab[minElement];
                tab[minElement] = tymczasowa;
            }
        }

        Console.WriteLine("Posortowana tablica:");
        for (int i = 0; i < rOZMIAR; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}