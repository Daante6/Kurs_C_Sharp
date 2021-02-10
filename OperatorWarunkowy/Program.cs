
using System;

namespace OperatorWarunkowy
{
	class Program
	{
		public static void Main(string[] args)
		{
			// (warunek) ? wartość dla = true : wartość dla = false;
			string tekst; 
			string tekst2;
			int wiek;
			
			Console.Write ("Ile masz lat? ");
			tekst2 = Console.ReadLine ();
			wiek = Convert.ToInt32 (tekst2);
			
			tekst = (wiek>=18) ? "Gratulacje!!! Jesteś pełnoletnią osobą." : "Jeszcze nie jesteś osobą pełnoletnią !!!";
			
			Console.WriteLine (tekst);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}