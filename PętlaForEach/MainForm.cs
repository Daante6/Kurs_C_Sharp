
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PętlaForEach
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
			string Tekst;
			
			Tekst = textBox1.Text;
			richTextBox1.Clear();
			richTextBox1.AppendText ("Tekst rozbity na znaki:\n");
			
			foreach (char Znak in Tekst)
			{
				richTextBox1.AppendText (Znak + "\n");
			}
		}
	}
}
