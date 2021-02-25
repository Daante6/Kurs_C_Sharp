
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OperacjeTekstowe
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		  	string Tekst1 = "";
			string Tekst2 = "";
			string Tekst3 = "";
			int Dlugosc1, Dlugosc2;
			
			Tekst1 = textBox1.Text;
			Tekst2 = textBox2.Text;
			
			Dlugosc1 = Tekst1.Length;
			Dlugosc2 = Tekst2.Length;
			
			if ((Dlugosc1 >0) && (Dlugosc2 > 0))
			 	{
				   Tekst3 = "Długość tekstu A = " + Dlugosc1 + "\nDługość tekstu B = " + Dlugosc2;
				   Tekst3 = Tekst3 + "\nPierwsza litera tekstu A = " + Tekst1[0] + " Ostatnia litera tekstu A = " + Tekst1[Dlugosc1-1];
				   Tekst3 = Tekst3 + "\nPierwsza litera tekstu B = " + Tekst2[0] + " Ostatnia litera tekstu B = " + Tekst2[Dlugosc2-1];
					MessageBox.Show (Tekst3,"Długości",MessageBoxButtons.OK,MessageBoxIcon.Information);
				} else
					{
						MessageBox.Show ("Wprowadź dwa teksty","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		  string Tekst1 = "";
			string Tekst2 = "";
			string Tekst3 = "";
			int Dlugosc1, Dlugosc2;
			int Wynik;
			
			Tekst1 = textBox1.Text;
			Tekst2 = textBox2.Text;
			
			Dlugosc1 = Tekst1.Length;
			Dlugosc2 = Tekst2.Length;
			
			if ((Dlugosc1 >0) && (Dlugosc2 > 0))
			 	{
				Wynik = Tekst1.CompareTo (Tekst2); 
				
				if (Wynik == 0)
					{
					 Tekst3 = "Teksty są takie same.";
				} else if (Wynik > 0)
					{
					 Tekst3 = "Tekst A jest za testem B.";
					} else if (Wynik < 0)
						{
					      Tekst3 = "Tekst A jest przed tekstem B.";
						}
				   
					MessageBox.Show (Tekst3,"Porównanie",MessageBoxButtons.OK,MessageBoxIcon.Information);
				} else
					{
						MessageBox.Show ("Wprowadź dwa teksty","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}	
		}
		
		void Button3Click(object sender, EventArgs e)
		{
		  string Tekst1 = "";
			string Tekst2 = "";
			string Tekst3 = "";
			int Dlugosc1, Dlugosc2;
			bool Wynik;
			
			Tekst1 = textBox1.Text;
			Tekst2 = textBox2.Text;
			
			Dlugosc1 = Tekst1.Length;
			Dlugosc2 = Tekst2.Length;
			
			if ((Dlugosc1 >0) && (Dlugosc2 > 0))
			 	{
				   Wynik = Tekst1.Contains (Tekst2); //!!
				   if (Wynik == true)
				   {
				    Tekst3 = "Tekst A zawiera w sobie tekst B";	
				   } else
				 	  {
				 	  	Tekst3 = "Tekst A nie zawiera w sobie tekstu B";	
					  }
					MessageBox.Show (Tekst3,"Zawiera",MessageBoxButtons.OK,MessageBoxIcon.Information);
				} else
					{
						MessageBox.Show ("Wprowadź dwa teksty","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}	
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string Tekst1 = "";
			string Tekst2 = "";
			string Tekst3 = "";
			int Dlugosc1, Dlugosc2;
			
			int Pozycja1, Pozycja2;
						
			Tekst1 = textBox1.Text;
			Tekst2 = textBox2.Text;
			
			Dlugosc1 = Tekst1.Length;
			Dlugosc2 = Tekst2.Length;
			
			if ((Dlugosc1 >0) && (Dlugosc2 > 0))
			 	{
					Pozycja1 = Tekst1.IndexOf (Tekst2); //!!
				    Pozycja2 = Tekst1.LastIndexOf (Tekst2); //!!
				    
				    if (Pozycja1 >=0)
				    {
				     Tekst3 = "Pozycja pierwszego znalezionego ciągu B w ciągu tekstowym A = " + Pozycja1;
				     Tekst3 = Tekst3 + "\nPozycja ostatniego wystąpienia ciągu B w ciągu A = " + Pozycja2;
				    } else
				    	{
				    	 Tekst3 = "Nie znaleziono ciągu B w ciągu tekstowym A.";
				    	}
					MessageBox.Show (Tekst3,"Pozycja",MessageBoxButtons.OK,MessageBoxIcon.Information);
				} else
					{
						MessageBox.Show ("Wprowadź dwa teksty","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}
		}
		
		void Button5Click(object sender, EventArgs e)
		{
		 string Tekst1 = "";
			string Tekst2 = "";
			string Tekst3 = "";
			int Dlugosc1;
			
			Tekst1 = textBox1.Text;
			Tekst2 = textBox2.Text;
			
			Dlugosc1 = Tekst1.Length;			
			
			if (Dlugosc1 > 6) 
			 	{
				   Tekst2 = Tekst1.Substring (5);
				   Tekst3 = "Fragment tekstu A od 6 litery do końca =" + Tekst2;
				   Tekst2 = Tekst1.Substring (1,3);
				   Tekst3 = Tekst3 + "\nTrzy litery rozpoczynając od drugiej = " + Tekst2;
				   
					MessageBox.Show (Tekst3,"Fragment",MessageBoxButtons.OK,MessageBoxIcon.Information);
				} else
					{
						MessageBox.Show ("Tekst A musi mieć więcej niż 6 liter.","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}	
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			string Tekst1 = "";
			string Tekst2 = "";
			string Tekst3 = "";
			int Dlugosc1, Dlugosc2;
			
			Tekst1 = textBox1.Text;
			Tekst2 = textBox2.Text;
			
			Dlugosc1 = Tekst1.Length;
			Dlugosc2 = Tekst2.Length;
			
			if ((Dlugosc1 >0) && (Dlugosc2 > 0))
			 	{
				   Tekst3 = "Duże litery\n";
				   Tekst3 = Tekst3 + "Tekst A = " + Tekst1.ToUpper() + "\n"; //!!
				   Tekst3 = Tekst3 + "Tekst B = " + Tekst2.ToUpper() + "\n";
				   Tekst3 = Tekst3 + "Małe litery\n";
				   Tekst3 = Tekst3 + "Tekst A = " + Tekst1.ToLower() + "\n"; //!!
				   Tekst3 = Tekst3 + "Tekst B = " + Tekst2.ToLower() + "\n";
				   
					MessageBox.Show (Tekst3,"Duże/małe litery",MessageBoxButtons.OK,MessageBoxIcon.Information);
				} else
					{
						MessageBox.Show ("Wprowadź dwa teksty","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}
		}
		
		void Button7Click(object sender, EventArgs e)
		{
		 string Tekst1 = "";
			string Tekst2 = "";
			string Tekst3 = "";
			int Dlugosc1, Dlugosc2;
			
			string Wynik;
			
			Tekst1 = textBox1.Text;
			Tekst2 = textBox2.Text;
			
			Dlugosc1 = Tekst1.Length;
			Dlugosc2 = Tekst2.Length;
			
			if ((Dlugosc1 >0) && (Dlugosc2 > 0))
			 	{
				    Wynik = Tekst1.Replace (Tekst2,"..."); //!!
				    Tekst3 = "Tekst A po podmianie ciągu znaków z tekstu B tekstem \"...\"\n";
				    Tekst3 = Tekst3 + Wynik;
				    
					MessageBox.Show (Tekst3,"Podmiana",MessageBoxButtons.OK,MessageBoxIcon.Information);
				} else
					{
						MessageBox.Show ("Wprowadź dwa teksty","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			string Tekst1 = "";
			string Tekst2 = "";
			string Tekst3 = "";
			int Dlugosc1, Dlugosc2;
			
			int Pozycja;
			string Wynik;
			
			Tekst1 = textBox1.Text;
			Tekst2 = textBox2.Text;
			
			Dlugosc1 = Tekst1.Length;
			Dlugosc2 = Tekst2.Length;
			
			if ((Dlugosc1 >0) && (Dlugosc2 > 0))
			 	{
				   Pozycja = Dlugosc1/2;
				   
				   Wynik = Tekst1.Insert (Pozycja,Tekst2); //!!
				   
				   Tekst3 = "Tekst A po wstawieniu w środek tekstu B:\n" + Wynik;
					MessageBox.Show (Tekst3,"Wstawianie",MessageBoxButtons.OK,MessageBoxIcon.Information);
				} else
					{
						MessageBox.Show ("Wprowadź dwa teksty","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					}
		}
	}
}
