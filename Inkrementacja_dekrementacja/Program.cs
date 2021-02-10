
using System;

namespace Inkrementacja_dekrementacja
{
	class Program
	{
		public static void Main(string[] args)
		{
			int zmienna1 = 1;
			
			Console.WriteLine ("zmienna1 = {0}",zmienna1);
			//zmienna1++; //zmienna1 = zmienna1 + 1;
			Console.WriteLine ("zmienna1++ = {0}",zmienna1++);
			Console.WriteLine ("zmienna1 = {0}",zmienna1);
			Console.WriteLine ("zmienna1-- = {0}",zmienna1--);
			Console.WriteLine ("zmienna1 = {0}",zmienna1);
			
			Console.WriteLine ("++zmienna1 = {0}",++zmienna1);
			Console.WriteLine ("zmienna1 = {0}",zmienna1);
			Console.WriteLine ("--zmienna1 = {0}",--zmienna1);
			Console.WriteLine ("zmienna1 = {0}",zmienna1);
			
			zmienna1 = 5;
			zmienna1 = zmienna1++ + zmienna1; // to samo co: zmienna1 = zmienna1 + ++zmienna1;
			                                  // czyli zmienna1 = zmienna1 + zmienna1 + 1;
			                                  // lub zmienna1 = (zmienna1 * 2) + 1;
			Console.WriteLine ("zmienna1 = {0}",zmienna1);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}