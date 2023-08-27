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
        int[] odwroconaTablica = new int[tab.Length];
        for (i = 0; i < tab.Length; i++)
        {
            odwroconaTablica[i] = tab[tab.Length - i - 1];
        }

        for (i = 0; i < odwroconaTablica.Length; i++)
        {
            Console.WriteLine(odwroconaTablica[i]);
        }
    }
}