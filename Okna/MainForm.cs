
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Okna
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
			
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Forma1 Okno1;
			Okno1 = new Forma1();
			
			DialogResult Wynik;
			
			Wynik = Okno1.ShowDialog();
			label1.Text = "Wynik = " + Convert.ToString(Wynik);
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			DialogResult Wynik;
			//Forma2 Okno2;
			//Okno2 = new Forma2();
			Forma2 Okno2 = new Forma2();

			Wynik = Okno2.ShowDialog();
			if (Wynik == DialogResult.OK)
			 {
			  label2.Text = "wpisano: " + Okno2.textBox1.Text;
			  
			} else if (Wynik == DialogResult.Cancel)
				{
				 label2.Text = "Anulowano."; 
				}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Forma2 Okno3;
			Okno3 = new Forma2();
			Okno3.Show();
			
		}
	}
}
