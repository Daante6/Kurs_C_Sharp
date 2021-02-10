
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TypZnaku
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
          long Dlugosc;
		  char Znak;

		  richTextBox1.Clear();
		  Tekst = textBox1.Text;
		  Dlugosc = Tekst.Length;
		  
		  for (int i = 0; i<Dlugosc; i++)
		   {
		  	Znak = Tekst[i];
		  	richTextBox1.AppendText (Znak + " - ");
		  	
		  	if (char.IsLetterOrDigit (Znak))
		  	 {
		  		if (char.IsDigit(Znak))
		  		{
		  		 richTextBox1.AppendText ("jest cyfrą.");	
		  		} else if (char.IsLower (Znak))
			  		{
			  		  richTextBox1.AppendText ("jest małą literą.");	
			  		} else
			  		  {
			  			   //if (char.IsUpper (Znak) == true)
			  			   //{
			  		   richTextBox1.AppendText ("jest dużą literą.");	
			  			   //};
			  		  };
		  	 } else if (char.IsWhiteSpace (Znak))
		  			{
		  			 richTextBox1.AppendText ("jest białym znakiem.");	
		  			} else if (char.IsPunctuation (Znak))
				  		 	{
				  		 		richTextBox1.AppendText ("jest znakiem interpunkcyjnym.");	
				  		 	} else if (char.IsSymbol (Znak))
				  		 			{
				  		 			 richTextBox1.AppendText ("jest symbolem.");	
				  		 			};
		  	richTextBox1.AppendText ("\n");
		   };
		}
	}
}
