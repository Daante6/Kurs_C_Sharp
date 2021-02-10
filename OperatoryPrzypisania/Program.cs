
using System;

namespace OperatoryPrzypisania
{
	class Program
	{
		public static void Main(string[] args)
		{
			int zmienna1 = 2; 
			int zmienna2, zmienna3;
			
			zmienna2 = 4;
			zmienna3 = zmienna1 * zmienna2 + 2;
			Console.WriteLine ("zmienna3 = {0}",zmienna3);
			
			zmienna2+= 5; //zmienna2 = zmienna2 + 5;
			Console.WriteLine ("zmienna2 = zmienna2 + 5 = {0}",zmienna2);
			
			zmienna2-=5; // zmienna2 = zmienna2 - 5;
			Console.WriteLine ("zmienna2 = zmienna2 - 5 = {0}",zmienna2);
			
			zmienna2*=3; // zmienna2 = zmienna2 * 3;
			Console.WriteLine ("zmienna2 = zmienna2 * 3 = {0}",zmienna2);
			
			zmienna2/=3; // zmienna2 = zmienna2 / 3;
			Console.WriteLine ("zmienna2 = zmienna2 / 3 = {0}",zmienna2);
			
			zmienna2%=3; // zmienna2 = zmienna2 % 3;
			Console.WriteLine ("zmienna2 = zmienna2 % 3 = {0}",zmienna2);
			
			zmienna2&=0; // zmienna2 = zmienna2 & 0;
			Console.WriteLine ("zmienna2 = zmienna2 & 0 = {0}",zmienna2);
			
			zmienna2|=16; // zmienna2 = zmienna2 | 16;
			Console.WriteLine ("zmienna2 = zmienna2 | 16 = {0}",zmienna2);
			
			zmienna2<<=2; // zmienna2 = zmienna2 << 2;
			Console.WriteLine ("zmienna2 = zmienna2 << 2 = {0}",zmienna2);
			
			zmienna2>>=3; // zmienna2 = zmienna2 >> 3;
			Console.WriteLine ("zmienna2 = zmienna2 >> 3 = {0}",zmienna2);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}