
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObiektRadioButton
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string[] Dane = new String[3] {"Adam","Nowak","Mężczyzna"};
		int Indeks = 0;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			radioButton1.Checked = true;
			radioButton3.Checked = true;
			RadioButton1CheckedChanged (this,null);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}		
		
		
		void RadioButton1Click(object sender, EventArgs e)
		{
		 //radioButton1.Checked = !radioButton1.Checked;	
		}
		
		void RadioButton2Click(object sender, EventArgs e)
		{
			//radioButton2.Checked = !radioButton2.Checked;
		}
		
		void RadioButton3Click(object sender, EventArgs e)
		{
			//radioButton3.Checked = !radioButton3.Checked;
		}
		
		void RadioButton4Click(object sender, EventArgs e)
		{
			//radioButton4.Checked = !radioButton4.Checked;
		}
		
		void RadioButton1CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked == true)
			{
				Indeks = 0;
				label1.Text = "Podaj imię:";
			} else
			{
			    Indeks = 1;
				label1.Text = "Podaj nazwisko:";	
			}
			
			if (radioButton3.Checked == true)
			{
				Dane[2] = "Mężczyzna";
			} else
			{
			    Dane[2] = "Kobieta";
			}
			
			textBox1.Text = Dane[Indeks];
			TextBox1TextChanged (sender,e);
			 
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			Dane[Indeks] = textBox1.Text;
			label2.Text = Dane[0] + " " + Dane[1] + " " + Dane[2];
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			//MessageBox.Show ("CheckedChanged");
		}
		
		void CheckBox1CheckStateChanged(object sender, EventArgs e)
		{
			//MessageBox.Show ("CheckedStateChanged");
			//checkBox1.CheckState = CheckState.Indeterminate;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if (((checkBox1.Checked && checkBox2.Checked) == true) && (checkBox3.Checked == false))
			{
				MessageBox.Show ("Zgadza się!","Dobrze",MessageBoxButtons.OK,MessageBoxIcon.Information);
			} else
			{
				MessageBox.Show ("Zła odpowiedź !!!","Źle",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
		}
	}
}
