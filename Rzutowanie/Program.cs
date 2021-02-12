
using System;

namespace Rzutowanie
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
			Console.WriteLine ("Wybrany miesiąc to: {0}", (int)Wybrany); //rzutowanie na int poprzez nawias przed zmienną

			Wybrany = (Miesiące)2; //rzutowanie na typ wyliczeniowy (enum) typu Miesiące
			Console.WriteLine("Wybrany miesiąc to: {0}", Wybrany);

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}