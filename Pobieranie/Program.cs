
using System;

namespace Pobieranie
{
	class Program
	{
		public static void Main(string[] args)
		{
			string Tekst;
			Console.Write("Wprowadź tekst: ");
			Tekst = Console.ReadLine();
			Console.WriteLine ("Wpisano: {0}",Tekst);
			
			ConsoleKeyInfo Klawisz;
			
			Console.Write("Wciśnij klawisz: ");
			Klawisz = Console.ReadKey (false);
			Console.WriteLine ();
			Console.WriteLine ("Wciśnięto klawisz: {0}",Klawisz.KeyChar);
			
			Console.WriteLine ();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}