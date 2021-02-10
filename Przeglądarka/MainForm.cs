
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

namespace Przeglądarka
{
	
	public partial class MainForm : Form
	{
		string Historia;
		
		void Zapisz()
		{
			FileMode Tryb;
			if (File.Exists (Historia) == false)
			{
				Tryb = FileMode.CreateNew;
			} else
			{
				Tryb = FileMode.Create;
			}
			
			try
			{
				FileStream Strumien = new FileStream (Historia,Tryb);
				StreamWriter Dane = new StreamWriter (Strumien);
				
				foreach (string Linia in toolStripComboBox1.Items)
				{
					Dane.WriteLine (Linia);
				}
				
				Dane.Close();
				Strumien.Close();
				
			} catch (IOException)
			{
				MessageBox.Show("Błąd zapisu historii stron!","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void Wczytaj()
		{
			string Linia;
			if (File.Exists (Historia) == true)
			{
				toolStripComboBox1.Items.Clear();
				
				try
				{
					FileStream Strumien = new FileStream (Historia,FileMode.Open,FileAccess.Read,FileShare.ReadWrite);
					StreamReader Dane = new StreamReader (Strumien);
					
					while (Dane.EndOfStream == false)
					{
						Linia = Dane.ReadLine();
						toolStripComboBox1.Items.Add(Linia);
					}
					
					Dane.Close();
					Strumien.Close();
					
				} catch (IOException)
				{
				 MessageBox.Show("Błąd odczytu historii stron!","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);	
				}
			}
		}
		
		void Przyciski()
		{
			dalejToolStripMenuItem.Enabled = webBrowser1.CanGoForward;
			wsteczToolStripMenuItem.Enabled = webBrowser1.CanGoBack;
		}
		
		void Dodaj(string adres)
		{
			if (adres != "")
			{
			 if (toolStripComboBox1.Items.Contains (adres) == false)
				{
					toolStripComboBox1.Items.Add (adres);
				}
			}
		}
		
		void Strona (string adres)
		{
			if (adres != "")
			{
				webBrowser1.Navigate (adres);
				Dodaj(adres);
			}
		}

		public MainForm()
		{
			
			InitializeComponent();	
            Historia = Environment.CurrentDirectory + "\\Historia.txt";			
            Wczytaj();
            Przyciski();
            webBrowser1.GoHome();
		}
		
		void WebBrowser1Navigated(object sender, WebBrowserNavigatedEventArgs e)
		{
			Przyciski();
			toolStripComboBox1.Text = webBrowser1.Url.ToString();
			Text = webBrowser1.Url.ToString();
		}
		
		void WebBrowser1Navigating(object sender, WebBrowserNavigatingEventArgs e)
		{
		 Text = toolStripComboBox1.Text;
		}
		
		void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
			Dodaj(webBrowser1.Url.ToString());
			toolStripProgressBar1.Visible = false;
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			Zapisz();
		}
		
		void WebBrowser1ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
		{
			long Stan = Math.Abs(e.CurrentProgress);
			long Maks = Math.Abs(e.MaximumProgress);
			
			double Liczba = (double)Stan/(double)Maks;
			toolStripProgressBar1.Value = (int)(Liczba * toolStripProgressBar1.Maximum);
			if (toolStripProgressBar1.Value <= toolStripProgressBar1.Maximum - 1) toolStripProgressBar1.Visible = true;
		}
		
		void ToolStripComboBox1KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == 13)
			{
				Strona (toolStripComboBox1.Text);
				e.Handled = true;
			}
		}
		
		void ToolStripComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			Strona (toolStripComboBox1.Text);
		}
		
		void PrzejdźDoStronyToolStripMenuItemClick(object sender, EventArgs e)
		{
		 Strona (toolStripComboBox1.Text);	
		}
		
		void WsteczToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (webBrowser1.CanGoBack == true) webBrowser1.GoBack();
		}
		
		
		void DalejToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (webBrowser1.CanGoForward == true) webBrowser1.GoForward();
		}
		
		void OdświeżToolStripMenuItemClick(object sender, EventArgs e)
		{
			webBrowser1.Refresh (WebBrowserRefreshOption.Completely);
		}
		
		void ZatrzymajToolStripMenuItemClick(object sender, EventArgs e)
		{
			webBrowser1.Stop();
		}
		
		void ToolStripMenuItem1Click(object sender, EventArgs e)
		{
			webBrowser1.ShowPrintDialog();
		}
		
		void UstawieniaDrukuToolStripMenuItemClick(object sender, EventArgs e)
		{
			webBrowser1.ShowPageSetupDialog();
		}
		
		void PodglądWydrukuToolStripMenuItemClick(object sender, EventArgs e)
		{
			webBrowser1.ShowPrintPreviewDialog();
		}
		
		void CzyśćHistorięToolStripMenuItemClick(object sender, EventArgs e)
		{
			toolStripComboBox1.Items.Clear();
			Zapisz();
			toolStripComboBox1.Text = webBrowser1.Url.ToString();
		}
		
		void ZapiszStronęToolStripMenuItemClick(object sender, EventArgs e)
		{
			webBrowser1.ShowSaveAsDialog();
		}
		
		void WłaściwościStronyToolStripMenuItemClick(object sender, EventArgs e)
		{
			webBrowser1.ShowPropertiesDialog();
		}
	}
}
