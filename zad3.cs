using System;
namespace cwicz_7
{
	public class zad3
	{
		public zad3()
		{
            int[,] tablica = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
            };

            ZnajdzNajbardziejZblizoneWiersze(tablica, out int wiersz1, out int wiersz2);

            Console.WriteLine("Najbardziej zbliżone wiersze: {0}, {1}", wiersz1, wiersz2);

            Console.ReadLine();

        }
        static void ZnajdzNajbardziejZblizoneWiersze(int[,] tablica, out int wiersz1, out int wiersz2)
        {
            int najmniejszaRoznica = int.MaxValue;
            wiersz1 = 0;
            wiersz2 = 0;

            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = i + 1; j < tablica.GetLength(0); j++)
                {
                    int roznica = ObliczMiareZroznicowania(tablica, i, j);

                    if (roznica < najmniejszaRoznica)
                    {
                        najmniejszaRoznica = roznica;
                        wiersz1 = i;
                        wiersz2 = j;
                    }
                }
            }
        }

        static int ObliczMiareZroznicowania(int[,] tablica, int i, int j)
        {
            int roznica = 0;

            for (int k = 0; k < tablica.GetLength(1); k++)
            {
                roznica += (int)Math.Pow(tablica[i, k] - tablica[j, k], 2);
            }

            return roznica;
        }


    }
}

