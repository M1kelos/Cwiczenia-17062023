using System;

class Program
{
    static void Main()
    {
        int[] tablica = { 5, 2, 9, 1, 7, 3, 6 };

        int najmniejszy = ZnajdzNajmniejszyElement(tablica);
        int najwiekszy = ZnajdzNajwiekszyElement(tablica);

        Console.WriteLine("Najmniejszy element: " + najmniejszy);
        Console.WriteLine("Największy element: " + najwiekszy);
    }

    static int ZnajdzNajmniejszyElement(int[] tablica)
    {
        int najmniejszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszy)
            {
                najmniejszy = tablica[i];
            }
        }

        return najmniejszy;
    }

    static int ZnajdzNajwiekszyElement(int[] tablica)
    {
        int najwiekszy = tablica[0];

        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] > najwiekszy)
            {
                najwiekszy = tablica[i];
            }
        }

        return najwiekszy;
    }
}