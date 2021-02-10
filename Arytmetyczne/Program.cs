
using System;

namespace Arytmetyczne
{
	class Program
	{
		public static void Main(string[] args)
		{
			uint Wart1 = 10;
			uint Wart2 = 15;
			long Wynik1;
			double Wynik2;
			
			Wynik1 = (long)Wart1 - (long)Wart2;
			Console.WriteLine ("Wart1 - Wart2 = {0}",Wynik1);
			
			Wynik1 = Wart1 + Wart2;
			Console.WriteLine ("Wart1 + Wart2 = {0}",Wynik1);
			
			Wynik1 = (long)Wart1 * (long)Wart2;
			Console.WriteLine ("Wart1 * Wart2 = {0}",Wynik1);
			
			Wynik2 = (double)Wart1 / (double)Wart2;
			Console.WriteLine ("Wart1 / Wart2 = {0}",Wynik2);
			
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