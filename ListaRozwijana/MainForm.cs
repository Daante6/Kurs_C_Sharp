
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ListaRozwijana
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
			comboBox1.Items.Clear();
			for (int i=0;i<20;i++)
			{
				comboBox1.Items.Add ("Element nr " + i);
			}
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			label2.Text = "Indeks: " + comboBox1.SelectedIndex;
			richTextBox1.AppendText ("Zmieniono właściwość: SelectedIndex \n");
		}
		
		void ComboBox1TextChanged(object sender, EventArgs e)
		{
			label1.Text = "Wybrano: " + comboBox1.Text;
			richTextBox1.AppendText ("Zmieniono właściwość: Text \n");
			label2.Text = "Indeks: " + comboBox1.SelectedIndex;
		}
		
		void ComboBox1SelectionChangeCommitted(object sender, EventArgs e)
		{
			richTextBox1.AppendText ("Wybrano element numer " + comboBox1.SelectedIndex + " i zwinięto listę \n");
		}
		
		void ComboBox1DropDown(object sender, EventArgs e)
		{
		richTextBox1.AppendText ("Rozwinięto listę. \n");	
		}
		
		void ComboBox1DropDownClosed(object sender, EventArgs e)
		{
			richTextBox1.AppendText ("Zwinięto listę \n");
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		 int Indeks = comboBox1.SelectedIndex;
		 if (Indeks >= 0)
		 {
		 	comboBox1.Items.RemoveAt (Indeks);
		 }
		ComboBox1SelectedIndexChanged (sender,e); 
		
		}
	}
}
