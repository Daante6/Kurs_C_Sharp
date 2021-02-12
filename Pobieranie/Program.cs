
using System;

namespace Pobieranie
{
	class Program
	{
		public static void Main(string[] args)
		{
			int x = 0;
			int y = 0;
			string Tekst;
			Console.Write("Wprowadź tekst: "); //nie writeline, żeby nie przechodziło do kolejnej linii
			Tekst = Console.ReadLine(); //tutaj ReadLine
			Console.WriteLine("Wpisano: {0}", Tekst);

			ConsoleKeyInfo Klawisz;
			while(true)
            {
				Console.Write("Wciśnij klawisz: ");
				Klawisz = Console.ReadKey(false); //true nie pokazuje w konsoli klikniętego przycisku
				Console.WriteLine();
				if (Klawisz.KeyChar.ToString() == "w")
				{
					y++;
				} else if (Klawisz.KeyChar.ToString() == "s")
				{
					y--;
				} else if (Klawisz.KeyChar.ToString() == "a")
				{
					x--;
				} else if (Klawisz.KeyChar.ToString() == "d")
				{
					x++;
				}
				Console.WriteLine();
				Console.WriteLine("Polozenie gracza: {0},{1}", x, y);
				Console.WriteLine("Jeszcze raz? jesli nie, kliknij N: ");
				Klawisz = Console.ReadKey(true);
				if (Klawisz.KeyChar.ToString() == "n")
				{
					break;
				}
			}
			Console.WriteLine ("Polozenie gracza: {0},{1}",x,y);
			
			Console.WriteLine ();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true); //tutaj ReadKey
		}
	}
}