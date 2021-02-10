
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ObiektTimer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int Ky = 10;
		
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
		
		void Button3Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
			button1.Top = button1.Top + Ky;
			if ((button1.Top + button1.Height) > Height)
			{
				Ky = -Ky; // Ky * -1;
				button1.Top = Height - button1.Height;
			} else if (button1.Top < 0)
		  	  {
				button1.Top = 0;
				Ky = -Ky;
			  }
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		 timer1.Enabled = true;
         button1.Enabled = false;
         button2.Enabled = true;
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			 timer1.Enabled = false;
             button1.Enabled = true;
             button2.Enabled = false;
		}
		
		void TrackBar1ValueChanged(object sender, EventArgs e)
		{
			timer1.Interval = trackBar1.Value;
			label1.Text = "Interwał = " + trackBar1.Value;
		}
	}
}
