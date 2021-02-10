
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Przekazywanie_Argumentow
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		K_Klasa Klasa = new K_Klasa();
		
		class K_Klasa
		{
			public long Dodaj (params int[] Parametry)
			{
			 long Wynik = 0;
			 
				foreach (int Wart in Parametry)
				{
					Wynik+=Wart;
				}
				
				return Wynik;
			}
			
			public long przez_wartosc (int Liczba)
			{
				Liczba++;
				return Liczba;
			}
			
			public long przez_referencje (ref int Liczba)
			{
				Liczba++;
				return Liczba;
			}
			
			public long przez_wyjscie (out int Liczba)
			{		
                Liczba = 0;				
				Liczba++;
				return Liczba;
			}
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
		
		void Button1Click(object sender, EventArgs e)
		{
		 long Wynik;
         
		 Wynik = Klasa.Dodaj (1,2);
		 MessageBox.Show ("Dodaj (1,2) = " + Wynik, "Dodaj",MessageBoxButtons.OK,MessageBoxIcon.Information);
		 Wynik = Klasa.Dodaj (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16);
		 MessageBox.Show ("Dodaj (1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16) = " + Wynik, "Dodaj",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		 long Wynik;
 		 int Zmienna = 5;
         
 		 Wynik = Klasa.przez_wartosc (Zmienna);
 		 MessageBox.Show ("Wynik = " + Wynik + "\nZmienna = " + Zmienna, "Przez wartość",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			long Wynik;
 		 int Zmienna = 5;
         
 		 Wynik = Klasa.przez_referencje (ref Zmienna);
 		 MessageBox.Show ("Wynik = " + Wynik + "\nZmienna = " + Zmienna, "Przez referencję",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
		long Wynik;
 		 int Zmienna = 5;
         
 		 Wynik = Klasa.przez_wyjscie (out Zmienna);
 		 MessageBox.Show ("Wynik = " + Wynik + "\nZmienna = " + Zmienna, "Przez wyjście",MessageBoxButtons.OK,MessageBoxIcon.Information);	
		}
	}
}
