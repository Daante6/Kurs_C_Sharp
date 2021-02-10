
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Formularz
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
			MessageBox.Show ("Kliknięto przycisk","Informacja");
			
		}
	}
}
