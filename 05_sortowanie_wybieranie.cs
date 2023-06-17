using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 2, 9, 1, 7, 3, 6 };

        Console.WriteLine("Tablica przed sortowaniem:");
        WypiszTablice(tablica);

        SortowaniePrzezWybieranie(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        WypiszTablice(tablica);
    }

    static void SortowaniePrzezWybieranie(int[] tablica)
    {
        int n = tablica.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int indeksMinimum = i;

            for (int j = i + 1; j < n; j++)
            {
                if (tablica[j] < tablica[indeksMinimum])
                {
                    indeksMinimum = j;
                }
            }

            ZamienElementy(tablica, i, indeksMinimum);
        }
    }

    static void ZamienElementy(int[] tablica, int indeks1, int indeks2)
    {
        int temp = tablica[indeks1];
        tablica[indeks1] = tablica[indeks2];
        tablica[indeks2] = temp;
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