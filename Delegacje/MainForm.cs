
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Delegacje
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	public delegate void Uchwyt (string s);
	
	
	class K_Klasa
	{
		public void PokazInny (string par)
		{
			MessageBox.Show (par,"Metoda PokazInny z Klasy K_Klasa",MessageBoxButtons.OK,MessageBoxIcon.Information);
		
		}
	}
	
	class K_Uruchomienie
	{
		public void Uruchom (params Uchwyt[] Param)
		{
			int Licznik = 1;
			foreach (Uchwyt Metoda in Param)
			{
				Metoda ("Uruchomienie metody nr "+Licznik +"z klasy K_Uruchomienie");
				Licznik++;
			}
		}
	}
	public partial class MainForm : Form
	{
		
		public delegate void Uchwyt2 ();
		K_Uruchomienie Uruchomienie = new K_Uruchomienie();
		K_Klasa Klasa = new K_Klasa ();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//Pokaz1 ("Zwykłe wywołanie");
			Uruchomienie.Uruchom (Pokaz1,Pokaz2,Pokaz3,Klasa.PokazInny);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void Pokaz()
		{
			MessageBox.Show ("Zwykła metoda","Metoda Pokaz z Klasy MainForm",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		public void Pokaz1 (string par)
		{
			MessageBox.Show (par,"Metoda Pokaz1 z Klasy MainForm",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		public void Pokaz2 (string par)
		{
			MessageBox.Show (par,"Metoda Pokaz2 z Klasy MainForm",MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}
		
		public void Pokaz3 (string par)
		{
			MessageBox.Show (par,"Metoda Pokaz3 z Klasy MainForm",MessageBoxButtons.OK,MessageBoxIcon.Error);
		}
	}
}
