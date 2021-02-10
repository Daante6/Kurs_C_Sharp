
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Interfejs
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
		
 class K_Klasa
	{
 	 public void JakasTamMetodaDziedziczona ()
 	  {
 		
 	  }
	}
	
	interface I_Obiekt
	{
		void PobierzDane (string A, string B, int C);
		void PokazDane ();
	}
	
	class K_Czlowiek : K_Klasa, I_Obiekt
	{
		string Imie;
		string Nazwisko;
		int Wiek;
		
		public void PobierzDane (string Im, string Na, int Wi)
		{
		 Imie = Im;
		 Nazwisko = Na;		 
		 Wiek = Wi;
		}
		
		public void PokazDane ()
		{
			MessageBox.Show ("Imię: "+Imie+"\nNazwisko: "+Nazwisko+"\nWiek: "+Wiek,"Dane Osoby",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		public void ZmienWiek (int w) //Ta metoda nie będzie dostępna w tablicy obiektów
		{
			Wiek = w;
		}
	}
	
	class K_Zwierzak : I_Obiekt
	{
		string Imie;
		string Gatunek;
		int Wiek;
		
		public void PobierzDane (string Im, string Ga, int Wi)
		{
		 Imie = Im;
		 Gatunek = Ga;		 
		 Wiek = Wi;
		}
		
		public void PokazDane ()
		{
			MessageBox.Show ("Imię zwierzaka: "+Imie+"\nGatunek: "+Gatunek+"\nWiek: "+Wiek,"Dane Zwierzaka",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
	}
	
	public partial class MainForm : Form
	{
		//K_Czlowiek Czlowiek = new K_Czlowiek();
		//K_Zwierzak Zwierzak = new K_Zwierzak();
		
		I_Obiekt[] Tablica = new I_Obiekt[5];		
		
				
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//Czlowiek.PobierzDane ("Adam","Kowalski",45);
			//Zwierzak.PobierzDane ("Reksio","Pies",2);
			
			Tablica[0] = new K_Czlowiek ();
			Tablica[0].PobierzDane ("Adam","Kowalski",45);
			Tablica[1] = new K_Zwierzak ();
			Tablica[1].PobierzDane ("Reksio","Pies",2);
			Tablica[2] = new K_Zwierzak ();
			Tablica[2].PobierzDane ("Perła","Kot",4);
			Tablica[3] = new K_Czlowiek();
			Tablica[3].PobierzDane ("Anna","Nowak",30);
			Tablica[4] = new K_Zwierzak();
			Tablica[4].PobierzDane ("Dżeki","Pies",8);
			
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			//Czlowiek.PokazDane();
			//Zwierzak.PokazDane();
			
			foreach (I_Obiekt Obiekt in Tablica)
			{
				Obiekt.PokazDane();
			}
		}
	}
}
