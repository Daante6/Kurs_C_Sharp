
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KolekcjaStack
{
	public partial class MainForm : Form
	{
		
		class K_Osoba
		{
			string Imie,Nazwisko;
			int Wiek;
			public static int Licznik = 1;
			
			public K_Osoba() : this("Imię nr " + Licznik, "Nazwisko nr " + Licznik, 18+Licznik)
			{
				 
			}
			
			public K_Osoba (string Im, string Na, int Wi)
			{
				Licznik++;
				Imie = Im;
				Nazwisko = Na;
				Wiek = Wi;
			}
			
			public string Dane()
			{
				string Tekst;
				Tekst = Imie+ " " + Nazwisko + " Wiek: " + Wiek;
				return Tekst;
			}
		}
		
		Stack<K_Osoba> Kolekcja = new Stack<K_Osoba>();
		K_Osoba Osoba;
		
		
		public MainForm()
		{
			
			InitializeComponent();			
			
		}
		
		void pokaz()
		{
			richTextBox1.Clear();
			richTextBox1.AppendText("Zawartość kolekcji \n");
			foreach (K_Osoba Element in Kolekcja)
			{
				richTextBox1.AppendText(Element.Dane() + "\n");
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Osoba = new K_Osoba();
			Kolekcja.Push(Osoba);
			
			pokaz();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (Kolekcja.Count > 0)
			{
			 Osoba = Kolekcja.Pop();
			 MessageBox.Show (Osoba.Dane(),"Zdjęty element:");
			}
			pokaz();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (Kolekcja.Count > 0)
			{
			 Osoba = Kolekcja.Peek();
			 MessageBox.Show (Osoba.Dane(),"Odczytany element:");
			}
			pokaz();
		}
		
		
	}
}
