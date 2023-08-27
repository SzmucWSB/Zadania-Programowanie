using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Random rnd = new Random();
        int rOZMIAR, i;
        rOZMIAR = 10;
        int[] tab = new int[rOZMIAR];

        for (i = 0; i <= rOZMIAR - 1; i++)
        {
            tab[i] = rnd.Next(100);
            Console.WriteLine(tab[i]);
        }
        Console.WriteLine();

        bool posortowane = false;
        while (!posortowane)
        {
            posortowane = true;
            for (i = 0; i < tab.Length - 1; i++)
            {
                if (tab[i] > tab[i + 1])
                {
                    int t = tab[i];
                    tab[i] = tab[i + 1];
                    tab[i + 1] = t;
                    posortowane = false;
                }
            }
        }

        Console.WriteLine("Posortowana tablica:");
        for (i = 0; i < rOZMIAR; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}