
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Threading;

namespace Watki
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
		//działa w tle
		void BackgroundWorker1DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			string[] Tekst = new String[100];
			int Przerwa;			
			
			Przerwa = (int)e.Argument;
			
			for (int i = 0;i<100;i++)
			{
				if (backgroundWorker1.CancellationPending == false)
				{
				  Tekst[i] = "Linia nr " + i;
				  // richTextBox1.AppendText ("Linia nr " + i) // żle!!!
				  Thread.Sleep (Przerwa);
				  //progressBar1.PerformStep(); // żle				  
				  backgroundWorker1.ReportProgress (i+1);
				} else
				 {
					e.Cancel = true;
					break;
				 }
			}
			
			e.Result = Tekst;
			
		}
		
		void BackgroundWorker1ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
		{
		 //progressBar1.PerformStep();	
		 progressBar1.Value = e.ProgressPercentage;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			backgroundWorker1.WorkerReportsProgress = true;
			backgroundWorker1.WorkerSupportsCancellation = true;
			backgroundWorker1.RunWorkerAsync(250);
		}
		
		void BackgroundWorker1RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if (e.Cancelled == true)
			{
				MessageBox.Show ("Wątek został anulowany","Wątki",MessageBoxButtons.OK,MessageBoxIcon.Information);
			} else
			 {			
				string[] Wynik = (string[])e.Result;
				foreach (string Linia in Wynik)
				{
					richTextBox1.AppendText (Linia + "\n");
				}
			 }
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			backgroundWorker1.CancelAsync();
		}
	}
}
