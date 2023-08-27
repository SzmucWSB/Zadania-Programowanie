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
        int minElement = tab[0];
        int maxElement = tab[0];

        for (int j = 1; j < tab.Length; j++)
        {
            if (tab[j] < minElement)
            {
                minElement = tab[j];
            }

            if (tab[j] > maxElement)
            {
                maxElement = tab[j];
            }
        }
        Console.WriteLine("Najmniejszy element: " + minElement);
        Console.WriteLine("Największy element: " + maxElement);
    }
}