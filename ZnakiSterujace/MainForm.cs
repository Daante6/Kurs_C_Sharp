
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ZnakiSterujace
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
			char Znak = '\'';
			MessageBox.Show ("To jest pierwsza linia\r\nTo jest kolejna linia\tTo tekst po tabulcji.");
			MessageBox.Show ("To jest zmienna \"test\", a to jest pojedynczy cudzysłów " + Znak);
			MessageBox.Show ("To jest symbol backslash \\");
		}
	}
}
