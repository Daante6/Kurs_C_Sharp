
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zdarzenia
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
		
		void Button2Click(object sender, EventArgs e)
		{
			richTextBox1.Clear();
		}
		
		void MainFormActivated(object sender, EventArgs e)
		{
			richTextBox1.AppendText ("Okno - Activated\n");
			label1.Text = "Okno - Activated\n";
		}
		
		void MainFormDeactivate(object sender, EventArgs e)
		{
		 richTextBox1.AppendText ("Okno - Deactivate\n");
		 label1.Text = "Okno - Deactivate\n";	
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
		 richTextBox1.AppendText ("Okno - Load\n");
		 label1.Text = "Okno - Load\n";		
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit ();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void MainFormFormClosed(object sender, FormClosedEventArgs e)
		{
			MessageBox.Show ("Okno zamknięte. Przyczyna: "+ Convert.ToString(e.CloseReason),"Zdarzenie - FormClosed",MessageBoxButtons.OK,MessageBoxIcon.Information);
			if (e.CloseReason == CloseReason.ApplicationExitCall) MessageBox.Show ("Zamknięcie poprzez Application.Exit");
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
		 DialogResult Wynik;
		 
 	  	 richTextBox1.AppendText ("Okno - FormClosing\n");
		 label1.Text = "Okno - FormClosing\n";	
		 Wynik = MessageBox.Show ("Czy chcesz zamknąć to okno?","Zdarzenie FormClosing",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
		 if (Wynik == DialogResult.No) e.Cancel = true;
		}
		
		void MainFormResizeBegin(object sender, EventArgs e)
		{
		 richTextBox1.AppendText ("Okno - ResizeBegin\n");
		 label1.Text = "Okno - ResizeBegin\n";		
		}
		
		void MainFormResizeEnd(object sender, EventArgs e)
		{
		 richTextBox1.AppendText ("Okno - ResizeEnd\n");
		 label1.Text = "Okno - ResizeEnd\n";		
		}
		
		void MainFormResize(object sender, EventArgs e)
		{
		 richTextBox1.AppendText ("Okno - Resize\n");
		 label1.Text = "Okno - Resize\n";		
		}
		
		void MainFormMove(object sender, EventArgs e)
		{
		 richTextBox1.AppendText ("Okno - Move\n");
		 label1.Text = "Okno - Move\n";			
		}
		
		void MainFormMouseDown(object sender, MouseEventArgs e)
		{
		 richTextBox1.AppendText ("Okno - MouseDown\n");
		 label1.Text = "Okno - MouseDown\n";
		 richTextBox1.AppendText ("* " + Convert.ToString(e.Button) + "Pozycja " + Convert.ToString(e.X) + ", "+ Convert.ToString(e.Y) + "\n");
		 if (e.Button == MouseButtons.Middle) MessageBox.Show ("Wciśnięto przycisk środkowy","MouseDown");
		}
		
		void MainFormMouseUp(object sender, MouseEventArgs e)
		{
		 richTextBox1.AppendText ("Okno - MouseUp\n");
		 label1.Text = "Okno - MouseUp\n";	
richTextBox1.AppendText ("* " + Convert.ToString(e.Button) + "Pozycja " + Convert.ToString(e.X) + ", "+ Convert.ToString(e.Y) + "\n");		 
		}
		
		void MainFormPaint(object sender, PaintEventArgs e)
		{
		 richTextBox1.AppendText ("Okno - Paint\n");
		 label1.Text = "Okno - Paint\n";		
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			richTextBox1.AppendText ("Przycisk - Click\n");
		    label1.Text = "Przycisk - Click\n";
		}
		
		void Button1MouseClick(object sender, MouseEventArgs e)
		{
			richTextBox1.AppendText ("Przycisk - MouseClick\n");
		    label1.Text = "Przycisk - MouseClick\n";
		}
		
		void Button1Enter(object sender, EventArgs e)
		{
			richTextBox1.AppendText ("Przycisk - Enter\n");
		    label1.Text = "Przycisk - Enter\n";
		}
		
		void Button1Leave(object sender, EventArgs e)
		{
			richTextBox1.AppendText ("Przycisk - Leave\n");
		    label1.Text = "Przycisk - Leave\n";	
		}
		
		void Button1MouseEnter(object sender, EventArgs e)
		{
		 	richTextBox1.AppendText ("Przycisk - MouseEnter\n");
		    label1.Text = "Przycisk - MouseEnter\n";		
		}
		
		void Button1MouseLeave(object sender, EventArgs e)
		{
		    richTextBox1.AppendText ("Przycisk - MouseLeave\n");
		    label1.Text = "Przycisk - MouseLeave\n";			
		}
		
		void Button1MouseHover(object sender, EventArgs e)
		{
			richTextBox1.AppendText ("Przycisk - MouseHover\n");
		    label1.Text = "Przycisk - MouseHover\n";	
		}
		
		void Button1KeyPress(object sender, KeyPressEventArgs e)
		{
			richTextBox1.AppendText ("Przycisk - KeyPress. Wciśnięto: " + e.KeyChar + "\n");
		    label1.Text = "Przycisk - KeyPress. Wciśnięto: " + e.KeyChar + "\n";	
		    
		}
		
		void Button1PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
		    richTextBox1.AppendText ("Przycisk - PreviewKeyDown. Wciśnięte klawisze: ");
		    if (e.Alt == true) richTextBox1.AppendText ("Alt ");
		    if (e.Control == true) richTextBox1.AppendText ("Control ");
		    if (e.Shift == true) richTextBox1.AppendText ("Shift ");
		    richTextBox1.AppendText ("\n Modyfikatory: " + Convert.ToString(e.Modifiers) + "\n");
		    richTextBox1.AppendText (" Kod klawisza: " + Convert.ToString(e.KeyValue) + "\n");
		    label1.Text = "Przycisk - PreviewKeyDown\n";		
		   
		}
		
		void MainFormKeyPress(object sender, KeyPressEventArgs e)
		{
		 	richTextBox1.AppendText ("Okno - KeyPress\n");
		    label1.Text = "Okno - KeyPress\n";		
		}
	}
}
