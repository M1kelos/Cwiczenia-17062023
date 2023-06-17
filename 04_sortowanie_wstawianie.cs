using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 2, 9, 1, 7, 3, 6 };

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWstawianie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    static void SortowaniePrzezWstawianie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 1; i < n; i++)
        {
            int aktualnyElement = tablica[i];
            int j = i - 1;

            while (j >= 0 && tablica[j] > aktualnyElement)
            {
                tablica[j + 1] = tablica[j];
                j--;
            }

            tablica[j + 1] = aktualnyElement;
        }
    }

    static void WypiszTablice(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }
}