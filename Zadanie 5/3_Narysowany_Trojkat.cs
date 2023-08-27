using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int wysokosc = int.Parse(Console.ReadLine());

        int szerokoscMax = 2 * wysokosc - 1; 
        for (int wiersz = 1; wiersz <= wysokosc; wiersz++)
        {
            int liczbaPlusow = 2 * wiersz - 1; 
            int liczbaSpacji = (szerokoscMax - liczbaPlusow) / 2; 


            for (int i = 1; i <= liczbaSpacji; i++)
            {
                Console.Write(" ");
            }

            for (int i = 1; i <= liczbaPlusow; i++)
            {
                Console.Write("+");
            }

            for (int i = 1; i <= liczbaSpacji; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(); 
        }
    }
}