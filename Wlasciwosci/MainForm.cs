
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace Wlasciwosci
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	class K_Klasa
	{
		int Pole; //private, changed by "Wartosc"
		public int Wartosc
		{
			set
			{
			 Pole = value;
			 if (Pole > 10) Pole = 10;
			  else if (Pole < 0) Pole = 0;	
			}
			
			get
			{
				return Pole * 10;
			}
		}
		
		
		
		/*public void Przypisz(int Wart)
		{
			Pole = Wart;
			if (Pole > 10) Pole = 10;
			else if (Pole < 0) Pole = 0;
		}
		
		public int Odczytaj()
		{
			return Pole * 10;
		} */
	}
	
	public partial class MainForm : Form
	{
		K_Klasa Klasa = new K_Klasa();
		
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
		
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			int Wart,Wart2;
			string Tekst;
			
			Wart = Convert.ToInt32(numericUpDown1.Value);
			Wart2 = Klasa.Wartosc;
			Klasa.Wartosc = Wart;
			Tekst = Convert.ToString (Wart2);
			label2.Text = Tekst;
		}
	}
}
