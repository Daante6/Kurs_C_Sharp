using System;

namespace Zmienne
{
	class Program
	{
		public static void Main(string[] args)
		{
			int variableInt = -1000000;
            string Zmienna1 = "To jest Zmienna 1"; 			
			uint zmienna2 = 1000000;
			double zmienna3 = 123.123456789;
			bool zmienna4 = true;
			char zmienna5 = 'A';
			string zmienna6 = "Zmienna tekstowa";
			float zmienna7 = 1.123456789f;
			decimal zmienna8 = 123456789.123456789m;
			const int stala1 = 10; //przy zmianie wartości błąd
			//stala1 += 10; //błąd
			
			Console.WriteLine ("Zmienna 1 = " + Zmienna1);
			Console.WriteLine ("variableInt = " + variableInt);
			Console.WriteLine ("zmienna 2 = {0}",zmienna2);
			Console.WriteLine ("zmienna 3 = {0}",zmienna3);
			Console.WriteLine ("zmienna 4 = {0}",zmienna4);
			Console.WriteLine ("zmienna 5 = {0}",zmienna5);
			Console.WriteLine ("zmienna 6 = {0}",zmienna6);
			Console.WriteLine ("zmienna 7 = {0}",zmienna7);
			Console.WriteLine ("zmienna 8 = {0}",zmienna8);
			zmienna4 = false;
			Console.WriteLine ("Nowa wartość zmiennej 4 = {0}",zmienna4);
			zmienna6 = "Nowy tekst";
			Console.WriteLine ("zmienna 6 = {0}",zmienna6);
			Console.WriteLine ();
			Console.WriteLine ("stala 1 = {0}",stala1);
			
			Console.Write("Naciśnij dowolny klawisz . . . ");
			Console.ReadKey(true);
		}
	}
}