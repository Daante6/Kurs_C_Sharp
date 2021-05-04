
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Struktury
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	//różnica między klasą a strukturą (rekordem): w strukturze nie ma konieczności tworzenia instancji, są szybsze
	//struktury nie mogą dziedziczyć
	//struktury nie mogą posiadać destruktora
	struct S_Dane
	{
	  public string Imie, Nazwisko;
      public int Wiek;

      public S_Dane (string im, string naz, int wi)
      {
      	Imie = im;
      	Nazwisko = naz;
      	Wiek = wi;
      	MessageBox.Show ("Uruchomiono konstruktor z trzema argumentami", "Metoda struktury S_Dane",
      	                 MessageBoxButtons.OK,MessageBoxIcon.Information); 
      }
      
      public void Pokaz()
      {
      	MessageBox.Show (Imie + " " + Nazwisko +
      	                 " wiek: " + Wiek, "Metoda struktury S_Dane",
      	                 MessageBoxButtons.OK,MessageBoxIcon.Information);     	                
      }
	}
	
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			S_Dane Osoba1 = new S_Dane ("Adam","Nowak",45);
			S_Dane Osoba2;
			
			/*Osoba1.Imie = "Adam";
			Osoba1.Nazwisko = "Nowak";
			Osoba1.Wiek = 45;*/
			Osoba2.Imie = "Anna";
			Osoba2.Nazwisko = "Kowalska";
			Osoba2.Wiek = 30;
			
			Osoba1.Pokaz();
			Osoba2.Pokaz();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
