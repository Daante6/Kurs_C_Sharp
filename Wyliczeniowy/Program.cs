
using System;

namespace Wyliczeniowy
{
	class Program
	{
		enum Miesiące
		{
		  Styczeń = 1, Luty, Marzec, Kwiecień, Maj, Czerwiec, Lipiec, Sierpień, Wrzesień, Pażdzernik, Listopad, Grudzień	
		}
		
		public static void Main(string[] args)
		{
			Miesiące Wybrany;
			
			Wybrany = Miesiące.Luty;
			
			Console.WriteLine ("Wybrany miesiąc to: {0}", Wybrany);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}