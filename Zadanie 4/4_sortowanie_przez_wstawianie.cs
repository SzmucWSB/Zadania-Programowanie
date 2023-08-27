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

        for (int i = 1; i < tab.Length; i++)
        {
            int obecnyElement = tab[i];
            int j = i - 1;

            while (j >= 0 && tab[j] > obecnyElement)
            {
                tab[j + 1] = tab[j];
                j--;
            }

            tab[j + 1] = obecnyElement;
        }

        Console.WriteLine("Posortowana tablica:");
        for (int i = 0; i < rOZMIAR; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}