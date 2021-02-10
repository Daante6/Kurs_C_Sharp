/*
* Numer NIP: 753-203-92-36
* 
*  NIP:   7  5  3  2  0  3  9  2  3      6
*           mnożenie: cyfra * waga       ^
*  Wagi:  6  5  7  2  3  4  5  6  7  Suma kontrolna
* 
*  Wynik: 7*6 + 5*5 + 3*7 + 2*2 + 0*3 + 3*4 + 9*5 + 2*6 + 3*7 =
*       =  42 +  25 +  21 + 4   + 0   + 12  + 45  + 12  + 21 = 182
*
* 182 modulo 11 = 6 (reszta z dzielenia równa ostatniej cyfrze numeru)
*
*/
 
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SprawdzanieNumerow
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int[] WagaNIP = new int[9] {6,5,7,2,3,4,5,6,7};
		int[] WagaREGON7 = new int[6] {2,3,4,5,6,7};
		int[] WagaREGON9 = new int[8] {8,9,2,3,4,5,6,7};
		int[] WagaPESEL = new int[10] {1,3,7,9,1,3,7,9,1,3};
		int[] WagaEAN13 = new int[12] {1,3,1,3,1,3,1,3,1,3,1,3};
		int[] WagaEAN8 = new int[7] {3,1,3,1,3,1,3};
		
		private string Filtruj(string Tekst)
		{
			string Wynik = "";
			char Znak;
			
			for (int i = 0;i<Tekst.Length;i++)
			{
				Znak = Tekst[i];
				if (char.IsDigit(Znak) == true)
				{
					Wynik += Znak;					
				}
			}
			
			return Wynik;
		}
		
		private int Sumuj (int[] Wagi, string Tekst)
		{
			int Wynik = 0;
			int Waga, Cyfra;
			
			for (int i= 0; i<Wagi.Length; i++)
			{
				Waga = Wagi[i];
				Cyfra = Convert.ToInt32(Convert.ToString(Tekst[i]));
				Wynik += (Cyfra * Waga);				
			}
			
			return Wynik;
		}
		
		public bool Sprawdz (int[] Wagi, string Tekst, bool pesel)
		{
			bool Wynik = false;
			int Dzielenie, Kontrolna, Suma;
			string Cyfry;
			
			Cyfry = Filtruj (Tekst);
			if (Cyfry.Length > 0)
			{
				if (Wagi.Length == (Cyfry.Length-1))
				{
					Suma = Sumuj (Wagi,Cyfry);
					Kontrolna = Convert.ToInt32("0" + Cyfry[Cyfry.Length-1]);
					if (pesel == true)
					{
						Dzielenie = 10 - (Suma % 10);
					} else
					  {
						Dzielenie = Suma % 11;
					  }
				   if (Dzielenie == 10) Dzielenie = 0;
				   if (Dzielenie == Kontrolna) Wynik = true;
				}
			}
			
			return Wynik;
		}
		
		
		
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
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
		 bool Wynik;
		 Wynik = Sprawdz (WagaNIP,textBox1.Text,false);
		 if (Wynik == true)
		 {
		 	KomunikatNIP.Text = "Dobry";
		 	KomunikatNIP.ForeColor = Color.Black;
		 } else
		   {
		 	KomunikatNIP.Text = "Zły";
		 	KomunikatNIP.ForeColor = Color.Red;
		   }		 
 		 
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			bool Wynik,Wynik1, Wynik2;
			
		 Wynik1 = Sprawdz (WagaREGON7,textBox2.Text,false);
		 Wynik2 = Sprawdz (WagaREGON9,textBox2.Text,false);
		 
		 Wynik = Wynik1 || Wynik2;
		 
		 if (Wynik == true)
		 {
		 	KomunikatREGON.Text = "Dobry";
		 	KomunikatREGON.ForeColor = Color.Black;
		 } else
		   {
		 	KomunikatREGON.Text = "Zły";
		 	KomunikatREGON.ForeColor = Color.Red;
		   }		 
		}
		
		void TextBox3TextChanged(object sender, EventArgs e)
		{
			bool Wynik;
		 Wynik = Sprawdz (WagaPESEL,textBox3.Text,true);
		 if (Wynik == true)
		 {
		 	KomunikatPESEL.Text = "Dobry";
		 	KomunikatPESEL.ForeColor = Color.Black;
		 } else
		   {
		 	KomunikatPESEL.Text = "Zły";
		 	KomunikatPESEL.ForeColor = Color.Red;
		   }		 
		}
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			bool Wynik,Wynik1, Wynik2;
			
		 Wynik1 = Sprawdz (WagaEAN8,textBox4.Text,true);
		 Wynik2 = Sprawdz (WagaEAN13,textBox4.Text,true);
		 
		 Wynik = Wynik1 || Wynik2;
		 
		 if (Wynik == true)
		 {
		 	KomunikatEAN.Text = "Dobry";
		 	KomunikatEAN.ForeColor = Color.Black;
		 } else
		   {
		 	KomunikatEAN.Text = "Zły";
		 	KomunikatEAN.ForeColor = Color.Red;
		   }		 
		}
	}
}
