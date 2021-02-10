
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Klasy
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
	 class K_Klasa
	 {
	  private string Tekst;
      private int Liczba;
      private string Nazwa;
      
      public K_Klasa (string naz)
      {
      	Nazwa = naz;
      	MessageBox.Show ("Uruchomiony konstruktor", Nazwa + " konstruktor", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      
      ~K_Klasa ()
      {
      	MessageBox.Show ("Uruchomiony destruktor", Nazwa + " destruktor", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      
      public void Pokaz ()
      {
      	string Komunikat;
      	
      	Komunikat = "Pole Tekst = " + Tekst +"\n";
      	Komunikat+= "Pole Liczba = " + Liczba;
      	
      	MessageBox.Show (Komunikat, Nazwa + " metoda Pokaz", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      
      public void Zmien (string arg1, int arg2)
      {
      	Tekst = arg1;
      	Liczba = arg2;
      	if (Liczba>10) Liczba = 10;
      }
      
      public int Podaj_Liczbe ()
      {
      	// Ten kod zostanie wykonany
      	return Liczba;
      	// Ten kod nie zostanie wykonany
      }
      
      public string Podaj_Tekst ()
      {
      	// Ten kod zostanie wykonany
      	return Tekst;
      	// Ten kod nie zostanie wykonany
      }
	 }
		
	 K_Klasa Instancja1;
	 K_Klasa Instancja2;
	 
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
			Instancja1 = new K_Klasa ("Instancja pierwsza");
			Instancja2 = new K_Klasa ("Instancja druga");
			button1.Enabled = false;
			button2.Enabled = true;
			button3.Enabled = true;			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Instancja1.Pokaz();
			Instancja2.Pokaz();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Instancja1.Zmien (textBox1.Text,Convert.ToInt32(numericUpDown1.Value));			    
			Instancja2.Zmien (textBox1.Text + " Inna instancja",Convert.ToInt32(numericUpDown1.Value) + 100);	
			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (Instancja1 != null) 
			{
			 MessageBox.Show ("Pole Tekst =" + Instancja1.Podaj_Tekst(),"Instancja1",MessageBoxButtons.OK, MessageBoxIcon.Information);
			 MessageBox.Show ("Pole Liczba =" + Instancja1.Podaj_Liczbe(),"Instancja1",MessageBoxButtons.OK, MessageBoxIcon.Information);	
			}
			
			if (Instancja2 != null) 
			{
			 MessageBox.Show ("Pole Tekst =" + Instancja2.Podaj_Tekst(),"Instancja2",MessageBoxButtons.OK, MessageBoxIcon.Information);
			 MessageBox.Show ("Pole Liczba =" + Instancja2.Podaj_Liczbe(),"Instancja2",MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
