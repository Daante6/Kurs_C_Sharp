
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PetlaDO
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
			DialogResult Wynik;
			
			do
			{
				Wynik = MessageBox.Show ("Wybierz przycisk TAK aby przerwać pętlę","Pętla DO",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
			} while (Wynik != DialogResult.Yes);
		}
	}
}
