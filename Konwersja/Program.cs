
using System;

namespace Konwersja
{
	class Program
	{
		public static void Main(string[] args)
		{
			double Zmiennoprzecinkowa = 256.6789;
			int Całkowita;
			string Tekstowa;
			string Tekst = "205";
			int Wynik;
			//byte Bajt;
			long Długa;
			
			Całkowita = System.Convert.ToInt32 (Zmiennoprzecinkowa); //tutaj przybliża
			//lub
			Całkowita = (int)Zmiennoprzecinkowa; //tutaj ZAWSZE ucina

			Tekstowa = System.Convert.ToString (Zmiennoprzecinkowa);
			//lub
			Tekstowa = Zmiennoprzecinkowa.ToString();

			Wynik = System.Convert.ToInt32 (Tekst) - 10;
			//Bajt = System.Convert.ToByte (Zmiennoprzecinkowa);
			Długa = Całkowita;
			
			Console.WriteLine ("Zmiennoprzecinkowa = {0}",Zmiennoprzecinkowa);
			Console.WriteLine ("Całkowita = {0}",Całkowita);
			Console.WriteLine ("Tekstowa = {0}",Tekstowa + "...To jest liczba zamieniona na ciąg liter");
			Console.WriteLine ("Tekst = {0}",Tekst);
			Console.WriteLine ("Wynik = {0}",Wynik);
			//Console.WriteLine ("Bajt = {0}",Bajt);
			Console.WriteLine ("Długa = {0}",Długa);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}