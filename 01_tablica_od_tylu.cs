using System;

class Program
{
    static void Main()
    {
        // Utwórz tablicę i wypełnij ją losowymi wartościami
        int[] tablica = GenerujLosoweWartosci(10, 1, 100);

        Console.WriteLine("Tablica oryginalna:");
        WypiszTablice(tablica);

        Console.WriteLine("Tablica od tyłu:");
        WypiszTabliceOdTylu(tablica);
    }

    // Metoda generująca losowe wartości i wypełniająca nimi tablicę
    static int[] GenerujLosoweWartosci(int rozmiar, int min, int max)
    {
        int[] tablica = new int[rozmiar];
        Random rand = new Random();

        for (int i = 0; i < rozmiar; i++)
        {
            tablica[i] = rand.Next(min, max);
        }

        return tablica;
    }

    // Metoda wypisująca zawartość tablicy
    static void WypiszTablice(int[] tablica)
    {
        foreach (int element in tablica)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }

    // Metoda wypisująca zawartość tablicy od tyłu
    static void WypiszTabliceOdTylu(int[] tablica)
    {
        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.Write(tablica[i] + " ");
        }

        Console.WriteLine();
    }
}