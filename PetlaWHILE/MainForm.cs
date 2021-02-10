
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PetlaWHILE
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
		  string Tekst = "";
          string Wynik = "";
          int i = 0;
          char Znak;

          Tekst = textBox1.Text;
          if (Tekst.Length > 0)
          {
          	Tekst = Tekst + '*';
          	Znak = Tekst[i];
          	i++;
          	while (Znak != '*')
          	{
          	 Wynik = Wynik + Znak;
          	 Znak = Tekst[i];
          	 i++;
          	}
          	MessageBox.Show ("Tekst do pierwszej gwiazdki = " + Wynik,"Pętla WHILE");
          }
         
		}
	}
}
