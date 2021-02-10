
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InstrukcjaSWITCH
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
			int Cyfra;
			char Znak = 'a';
			
			Cyfra = Convert.ToInt32(numericUpDown1.Value);
			if (textBox1.Text.Length > 0)
			{
			 Znak = textBox1.Text[0];
			}
			
			switch (Cyfra)
			{
					case 0: MessageBox.Show ("Wybrano cyfrę zero","Switch",MessageBoxButtons.OK,MessageBoxIcon.Information);
					        break;
				    case 1: MessageBox.Show ("Wybrano cyfrę jeden","Switch",MessageBoxButtons.OK,MessageBoxIcon.Information);
				            break;
				    case 2: MessageBox.Show ("Wybrano cyfrę dwa","Switch",MessageBoxButtons.OK,MessageBoxIcon.Information);
				            break;
				    case 3: MessageBox.Show ("Wybrano cyfrę trzy","Switch",MessageBoxButtons.OK,MessageBoxIcon.Information);
				    		break;
				    case 4: MessageBox.Show ("Wybrano cyfrę cztery","Switch",MessageBoxButtons.OK,MessageBoxIcon.Information);
				    		break;
				    case 5: MessageBox.Show ("Wybrano cyfrę pięć","Switch",MessageBoxButtons.OK,MessageBoxIcon.Information);
				    		break;
				   	default: MessageBox.Show ("Wybrano inną cyfrę","Switch",MessageBoxButtons.OK,MessageBoxIcon.Information);
				     		break;
			}
			
			switch (Znak)
			{
				case 'i':
				case 'e':
				case 'a':
				case 'o':
				case 'u':
				case 'y': MessageBox.Show ("Litera jest samogłoską","Switch",MessageBoxButtons.OK,MessageBoxIcon.Information);
				     	  break;
				
				default: MessageBox.Show ("Litera jest spółgłoską","Switch",MessageBoxButtons.OK,MessageBoxIcon.Information);
				     	 break;
			}
		}
	}
}
