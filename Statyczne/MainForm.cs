
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Statyczne
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	class K_Klasa
	{
		static public int licznik;
		
		public K_Klasa()
		{
			licznik++;
			MessageBox.Show ("Dla tej instancji Licznik = "+licznik,"Konstruktor K_Klasa",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
		}
	}
	
	static class K_Pokaz
	{
		static K_Pokaz()
		{
			MessageBox.Show ("Konstruktor K_Pokaz ","K_Pokaz",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		static public void Dialog (string Nagl, params string[] Tek)
		{
			string Tekst = "";
			foreach (string Linia in Tek)
			{
				Tekst+= Linia + "\n";
			}
		    MessageBox.Show (Tekst,Nagl,MessageBoxButtons.OK,MessageBoxIcon.Information);	
			
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
			//K_Klasa.licznik = 10;
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			new K_Klasa();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//K_Pokaz Pokaz = new K_Pokaz();
			
			//Pokaz.Dialog ("Nagłówek","Metoda dialog","Druga linia","To jest kolejna linia");
		   K_Pokaz.Dialog ("Nagłówek","Metoda dialog","Druga linia","To jest kolejna linia");
			
		}
	}
}
