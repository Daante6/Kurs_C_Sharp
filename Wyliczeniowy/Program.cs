
using System;

namespace Wyliczeniowy
{
	class Program
	{
		enum Miesiące
		{
		  Styczeń = 1, Luty, Marzec, Kwiecień, Maj, Czerwiec, Lipiec, Sierpień, Wrzesień, Pażdzernik, Listopad, Grudzień	
		}
		//styczeń = 1 powoduje, że jego indeks to 1, wtedy miesiące pokrywają się (grudzień to 12)
		public static void Main(string[] args)
		{
			Miesiące Wybrany;
			
			Wybrany = Miesiące.Maj;
			
			Console.WriteLine ("Wybrany miesiąc to: {0}", Wybrany);
			Console.WriteLine("Wybrany miesiąc w systemie 16-tkowym to: {0:x}", Wybrany);


			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}