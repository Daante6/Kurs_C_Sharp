
using System;

namespace Bitowy
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine (" Iloczyn bitowy AND");
			Console.WriteLine (" 1 & 1 = {0}", 1 & 1);
			Console.WriteLine (" 1 & 0 = {0}", 1 & 0);
			Console.WriteLine (" 0 & 0 = {0}", 0 & 0);
			
			Console.WriteLine (" 10 & 8 = {0}", 10 & 8); //00001010 &
														 //00001000 =
														 //00001000 (8 dziesiętnie)
			Console.WriteLine (" 74 & 12 = {0}", 74 & 12); //01001010 &
														   //00001100 =
														 //  00001000 (8 dziesiętnie)
			Console.WriteLine (" Suma bitowa OR");
			Console.WriteLine (" 1 | 1 = {0}", 1 | 1);
			Console.WriteLine (" 1 | 0 = {0}", 1 | 0);
			Console.WriteLine (" 0 | 0 = {0}", 0 | 0);											 
			
			Console.WriteLine (" 10 | 8 = {0}", 10 | 8); //00001010 |
														 //00001000 =
														 //00001010 (10 dziesiętnie)	
			
			Console.WriteLine (" 74 | 12 = {0}", 74 | 12); //01001010 |
														   //00001100 =
														 //  01001110 (78 dziesiętnie)		

			Console.WriteLine (" Różnica symetryczna XOR");
			Console.WriteLine (" 1 ^ 1 = {0}", 1 ^ 1);
			Console.WriteLine (" 1 ^ 0 = {0}", 1 ^ 0);
			Console.WriteLine (" 0 ^ 0 = {0}", 0 ^ 0);
			
			Console.WriteLine (" 10 ^ 8 = {0}", 10 ^ 8); //00001010 ^
														 //00001000 =
														 //00000010 (2 dziesiętnie)	
			
			Console.WriteLine (" 74 ^ 12 = {0}", 74 ^ 12); //01001010 ^
														   //00001100 =
														 //  01000110 (70 dziesiętnie)	
				
			Console.WriteLine (" Przesunięcie w lewo");
			Console.WriteLine (" 4 << 1 = {0} ",4 << 1); // 00000100 << 1
			                                             // 00001000 (8 dziesiętnie)
			Console.WriteLine (" 4 << 2 = {0} ",4 << 2); // 00000100 << 2
			                                             // 00010000 (16 dziesiętnie) 

			Console.WriteLine (" Przesunięcie w prawo");
			Console.WriteLine (" 32 >> 1 = {0} ",32 >> 1); // 00100000 >> 1
			                                               // 00010000 (16 dziesiętnie)
			Console.WriteLine (" 32 >> 2 = {0} ",32 >> 2); // 00100000 >> 2
			                                               // 00001000  (8 dziesiętnie) 
                                             
			Console.WriteLine (" 5 >> 1 = {0} ",5 >> 1); // 00000101 >> 1
			                                             // 00000010  (2 dziesiętnie)
			                                               
			                                               
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}