
using System;

namespace Arytmetyczne
{
	class Program
	{
		public static void Main(string[] args)
		{
			uint Wart1 = 20;
			uint Wart2 = 15;
			long Wynik1;
			double Wynik2;
			double Wynik3;
			
			Wynik1 = (long)Wart1 - Wart2; //aby wynik był typu long, przynajmniej jedna zmienna musi być rzutowana na long
			Console.WriteLine ("Wart1 - Wart2 = {0}",Wynik1);
			
			Wynik1 = Wart1 + Wart2;
			Console.WriteLine ("Wart1 + Wart2 = {0}",Wynik1);
			
			Wynik1 = (long)Wart1 * (long)Wart2;
			Console.WriteLine ("Wart1 * Wart2 = {0}",Wynik1);
			
			Wynik2 = (double)Wart1 / (double)Wart2; //wystarzy rzutować tylko 1 int, bez rzutowania wynik będzie pozbawiony części ułamkowej
			Wynik3 = (double)(Wart1 / Wart2); //usuwa część ułamkową
			Console.WriteLine ("rzutowanie obu zmiennych na double Wart1 / Wart2 = {0}",Wynik2);
			Console.WriteLine("rzutowanie wyniku Wart1 / Wart2 = {0}", Wynik3);

			Wynik1 = Wart2 % Wart1;
			Console.WriteLine ("Reszta z dzielenia Wart2 przez Wart1 = {0}",Wynik1);
			
			Console.WriteLine ("2 + 2 = {0}",2 + 2);
			Console.WriteLine ("2 + 2 * 2 = {0}",2 + 2 * 2);
			Console.WriteLine ("(2 + 2) * 2 = {0}",(2 + 2) * 2);
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}