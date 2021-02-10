
using System;

namespace Warunki
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine (" true && true  = {0}", true && true);
			Console.WriteLine (" true && false  = {0}", true && false);
			Console.WriteLine (" false && false  = {0}", false && false);
			Console.WriteLine ();
			Console.WriteLine (" true || true  = {0}", true || true);
			Console.WriteLine (" true || false  = {0}", true || false);
			Console.WriteLine (" false || false  = {0}", false || false);
			Console.WriteLine ();
			Console.WriteLine (" !true = {0}", !true);
			Console.WriteLine (" !false = {0}", !false);
			Console.WriteLine ("");
			
			bool wynik;
			int a = 6;
			
			wynik = (a>5) && (a<10);
			Console.WriteLine ("Czy A jest większe od 5 i jednoczesnie mniejsze od 10? {0}",wynik);
			Console.WriteLine ("Czy A jest większe od 10 lub mniejsze od 5? {0}",(a>10) || (a<5));
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}