
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KolekcjaList
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
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
		
		List<K_Osoba> Kolekcja = new List<K_Osoba>();
		K_Osoba Osoba;
		
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
		
		void pokaz()
		{
			richTextBox1.Clear();
			richTextBox1.AppendText("Zawartość kolekcji \n");
			for (int i=0; i<Kolekcja.Count;i++)
			{
				richTextBox1.AppendText("Indeks: " + i + " " + Kolekcja[i].Dane() + "\n");
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Osoba = new K_Osoba();
			Kolekcja.Add (Osoba);
			
			pokaz();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (Kolekcja.Count > 0) Kolekcja.RemoveAt (0);
			pokaz();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Kolekcja.Remove(Osoba);
			pokaz();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Kolekcja.Reverse();
			pokaz();
		}
	}
}
