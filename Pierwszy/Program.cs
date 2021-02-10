
using System;

namespace Pierwszy
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello world");
			Console.WriteLine("Liczba {0} w formacie dziesietnym {0} i szesnastkowym {0:x5} " , 155 );
			Console.WriteLine("Liczba {0} w formacie walutowym {0:c}" , 155.5 );
			Console.WriteLine("Liczba {0} w formacie zmienoprzecinkowym {0:f4} " , 155.43666 );
			Console.ReadLine();
		}
	}
}