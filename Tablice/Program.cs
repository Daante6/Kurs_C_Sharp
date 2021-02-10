
using System;

namespace Tablice
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [] zmienna = new int[10] {5,10,20,30,40,50,60,70,80,90};
			int indeks = 5;
			
			/*
            zmienna[2] = 20;
			zmienna[1] = 10;
			zmienna[0] = 5;
			*/
			Console.WriteLine ("Element o indeksie {1} = {0}",zmienna[indeks], indeks);
			Console.WriteLine ("Ilość elementów w tablicy {0}",zmienna.Length);
			Console.WriteLine ();
			Console.WriteLine ("Tablice wielowymiarowe");
			
			int [,] tablica = new int[2,4] {{1,2,3,4},{10,20,30,40}};
			int [,] tablica2;
			
			//tablica[0,3] = 30;
			Console.WriteLine ("Element o indeksie [0,3] = {0}",tablica[0,3]);
			Console.WriteLine ("Ilość elementów w tablicy {0}",tablica.Length);
			Console.WriteLine ("Ilość wymiarów tablicy {0}",tablica.Rank);
			Console.WriteLine ("Ilość elementów pierwszego wymiaru tablicy {0}",tablica.GetLength (0));
			Console.WriteLine ("Ilość elementów drugiego wymiaru tablicy {0}",tablica.GetLength (1));
			
			//tablica2 = tablica;
			tablica2 = (int[,])tablica.Clone();
			tablica2[0,3] = 130;
			Console.WriteLine ("Element o indeksie [0,3] tablicy drugiej = {0}",tablica2[0,3]);
			Console.WriteLine ("Element o indeksie [0,3] tablicy pierwszej = {0}",tablica[0,3]);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}