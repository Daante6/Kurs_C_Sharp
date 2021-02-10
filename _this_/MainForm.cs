
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace _this_
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	class K_Klasa
	{
		public void Wywolanie (MainForm Uchwyt)
		{
			Uchwyt.Pokaz("Wywołanie z instancji klasy K_Klasa");
		}
	}
	
	
	
	public partial class MainForm : Form
	{
		K_Klasa Klasa = new K_Klasa();
		
		int Wartosc = 128;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//Pokaz ("Wywołanie z wnętrza klasy MainForm");
			
			Klasa.Wywolanie (this);
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void Pokaz (string nagl)
		{
			int Wartosc = 10;
			MessageBox.Show ("Wartosc = " + Wartosc +
			                  "\nthis.Wartosc = " + this.Wartosc,
			                 nagl, MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
	}
}
