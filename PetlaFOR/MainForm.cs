
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PetlaFOR
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
		  int i,j;
          int ile;
          
          ile = Convert.ToInt32(textBox1.Text);
          
          for (i = 1,j = 1;(i<=ile) && (j<=50);i++,j = j + 5)
			{
				MessageBox.Show ("Przejście pętli " + Convert.ToString(i) + " j = " + Convert.ToString(j),"Pętla");
			}
			MessageBox.Show ("Pętla zakończona Licznik = " + Convert.ToString(i),"Pętla");
		}
	}
}
