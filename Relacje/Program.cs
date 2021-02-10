
using System;

namespace Relacje
{
	class Program
	{
		public static void Main(string[] args)
		{
		  int a = 2;
          int b = 2;
          int c = 4;
          int d = 1;
          
            Console.WriteLine ("A = {0}, B = {1}, C = {2}, D = {3}", a,b,c,d);
			Console.WriteLine ();
          	Console.WriteLine ("Operatory relacji ");          
          	Console.WriteLine ();
			Console.WriteLine ("Równe: ");
            Console.WriteLine ("A == B {0}", a == b);
            Console.WriteLine ("A == C {0}", a == c); 
 	 		Console.WriteLine ();            
            Console.WriteLine ("Nie równe: ");            
            Console.WriteLine ("A != B {0}", a != b);
            Console.WriteLine ("A != C {0}", a != c);
			Console.WriteLine ();            
            Console.WriteLine ("Większe: ");
            Console.WriteLine ("A > B {0}", a > b);
            Console.WriteLine ("A > C {0}", a > c);
            Console.WriteLine ("A > D {0}", a > d);    
            Console.WriteLine ();
            Console.WriteLine ("Mniejsze: ");
            Console.WriteLine ("A < B  {0}", a < b);
            Console.WriteLine ("A < C  {0}", a < c);
            Console.WriteLine ("A < D  {0}", a < d);
            Console.WriteLine ();
            Console.WriteLine ("Większe lub równe: ");
            Console.WriteLine ("A >= B {0}", a >= b);
            Console.WriteLine ("A >= C {0}", a >= c);
            Console.WriteLine ("A >= D {0}", a >= d);
            Console.WriteLine ();
            Console.WriteLine ("Mniejsze lub równe: ");
            Console.WriteLine ("A <= B {0}", a <= b);
            Console.WriteLine ("A <= C {0}", a <= c);
            Console.WriteLine ("A <= D {0}", a <= d);
            		
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}