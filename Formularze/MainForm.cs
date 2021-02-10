
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Formularze
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
			button1.Text = "Nowa nazwa przycisku";
			MessageBox.Show ("Wpisano tekst: " + textBox1.Text,"Informacja");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		  button1.Visible = false;
		  textBox1.Visible = false;
		  label1.Visible = false;		  
		}
		
		void Button3Click(object sender, EventArgs e)
		{
		  button1.Visible = true;
		  textBox1.Visible = true;
		  label1.Visible = true;		  
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
