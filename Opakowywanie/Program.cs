
using System;

namespace Opakowywanie
{
	class Program
	{
		public static void Main(string[] args)
		{
			double Zmienna = 123.45678;
			object Opakowanie = Zmienna;
			double Rozpakowana;			
			
			Zmienna = 987.123;					
			Rozpakowana = (double)Opakowanie;
			Console.WriteLine ("Opakowanie = {0}", Opakowanie);
			Opakowanie = "Tekst w zmiennej typu object";	
			Console.WriteLine ("Opakowanie po zmianie = {0}", Opakowanie);
			
			Console.WriteLine ("Zmienna = {0}", Zmienna);
			Console.WriteLine ("Rozpakowana = {0}", Rozpakowana);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}