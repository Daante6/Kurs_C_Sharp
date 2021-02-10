
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Maskowane
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
		
		void MaskedTextBox1MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			if (maskedTextBox1.MaskCompleted == false)
			{
			 MessageBox.Show ("Wprowadzono znak niezgodny z maską. Na pozycji: " + e.Position + " Komunikat: " + e.RejectionHint,"Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
			} else
			{
			MessageBox.Show ("Zakończono wprowadzanie tekstu w masce.","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			}
		}
		
		void MaskedTextBox1TextChanged(object sender, EventArgs e)
		{
		 label1.Text = "Text = " + maskedTextBox1.Text;	
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			maskedTextBox1.Mask = @"<LLL-000-<LLL|\AB\Cdef";
		}
	}
}
