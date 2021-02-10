
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BreakContinue
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		 string Tekst, Wynik = "";
		 
		 Tekst = textBox1.Text;
		 
		 if (Tekst.Length > 0)
		 {
		 	foreach (char Znak in Tekst)
		 	{
		 		if (Znak == '*') break;
		 		Wynik = Wynik + Znak;
		 	}
		 	MessageBox.Show ("Tekst do gwiazdki = " + Wynik,"Break i Continue",MessageBoxButtons.OK,MessageBoxIcon.Information);
		 }
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		string Tekst, Wynik = "";
		 
		 Tekst = textBox1.Text;
		 
		 if (Tekst.Length > 0)
		 {
		 	foreach (char Znak in Tekst)
		 	{
		 		if (Znak == '*') continue;
		 		Wynik = Wynik + Znak;
		 	}
		 	MessageBox.Show ("Tekst bez gwiazdek = " + Wynik,"Break i Continue",MessageBoxButtons.OK,MessageBoxIcon.Information);
		 }	
		}
	}
}
