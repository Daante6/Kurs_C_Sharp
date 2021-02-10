
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KolekcjaDictionary
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
		
		Dictionary<string,K_Osoba> Kolekcja = new Dictionary<string,K_Osoba>();
		K_Osoba Osoba;
		string Klucz = "*";
		
		public MainForm()
		{
			
			InitializeComponent();			
			
		}
		
		void pokaz()
		{
			richTextBox1.Clear();
			richTextBox1.AppendText("Zawartość kolekcji \n");
			foreach (KeyValuePair<string, K_Osoba> Element in Kolekcja)
			{
				richTextBox1.AppendText("Indeks: " + Element.Key + " " + Element.Value.Dane() + "\n");
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Osoba = new K_Osoba();
			Kolekcja.Add(Klucz,Osoba);
			Klucz += "*";
			pokaz();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (Kolekcja.ContainsKey("***") == true)
			{
				Kolekcja.Remove("***");
			}
			pokaz();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (Kolekcja.ContainsKey("****") == true)
			{
				MessageBox.Show(Kolekcja["****"].Dane(),"Indeks ****");
			}
			pokaz();
		}
		
		
	}
}
