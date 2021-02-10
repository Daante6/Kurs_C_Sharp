
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EdytorTekstu
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string Plik = "";
		string Znacznik = "";
		
		void Naglowek ()
		{
			if (richTextBox1.Modified == false)
			{
				Znacznik = "";
			} else
			{
				Znacznik = " *";
			}
			
			if (Plik == "")
			{
				Text = "Edytor tekstu formatowanego" + Znacznik;
			} else
			{
				Text = Plik + Znacznik;
			}			
			 
		}
		
		void Aktywacja()
		{			
			
		 cofnijToolStripMenuItem.Enabled = richTextBox1.CanUndo;
		 przywróćToolStripMenuItem.Enabled = richTextBox1.CanRedo;
			
		 if (richTextBox1.SelectionLength > 0)
		 {
		 	kopiujToolStripMenuItem.Enabled = true;
		 	kopiujToolStripMenuItem1.Enabled = true;
		 	wytnijToolStripMenuItem.Enabled = true;
		 	wytnijToolStripMenuItem1.Enabled = true;
		 } else
		 {
		 	kopiujToolStripMenuItem.Enabled = false;
		 	kopiujToolStripMenuItem1.Enabled = false;
		 	wytnijToolStripMenuItem.Enabled = false;
		 	wytnijToolStripMenuItem1.Enabled = false;
		 }
		 
		 zapiszToolStripMenuItem.Enabled = richTextBox1.Modified;
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			Naglowek ();
			Aktywacja();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void InformacjaToolStripMenuItemClick(object sender, EventArgs e)
		{
			MessageBox.Show ("Edytor tekstu formatowanego stworzony na potrzeby kursu", "www.kursy-komputerowe.pl",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		
		void RichTextBox1TextChanged(object sender, EventArgs e)
		{
			Naglowek();
		}
		
		void EdycjaToolStripMenuItemDropDownOpening(object sender, EventArgs e)
		{
			Aktywacja();
		}
		
		void ToolStripMenuItem1DropDownOpening(object sender, EventArgs e)
		{
			Aktywacja();
		}
		
		void ContextMenuStrip1Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Aktywacja();
		}
		
		void OtwórzToolStripMenuItemClick(object sender, EventArgs e)
		{
			
			if (Zamykanie() == false)
			{							
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					try
					{
						Plik = openFileDialog1.FileName;
						richTextBox1.LoadFile (Plik);
						richTextBox1.Modified = false;
					} catch (Exception)
					{
						MessageBox.Show ("Błąd odczytu pliku " + Plik,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Information);
						Plik = "";
					}
				}
			}
			Aktywacja();
			Naglowek();
		}
		
		void Zapisz (string Nazwa)
		{
			if (Nazwa != "")
			{
				try
				{
				 Plik = Nazwa;
				 richTextBox1.SaveFile(Plik);
				 richTextBox1.Modified = false;	
				} catch (Exception)
				{
				 MessageBox.Show ("Błąd zapisu pliku " + Plik,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Information);
				 Plik = "";	
				}
			}
			Naglowek();
		}
		
		void ZapiszJakoToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Zapisz (saveFileDialog1.FileName);
			}
		}
		
		void ZapiszToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (Plik == "")
			{
				ZapiszJakoToolStripMenuItemClick (sender,e);
			} else
			{
				Zapisz (Plik);
			}
		}
		
		void ZamknijToolStripMenuItemClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void CofnijToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (richTextBox1.CanUndo == true) richTextBox1.Undo();
		}
		
		void PrzywróćToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (richTextBox1.CanRedo == true) richTextBox1.Redo();
		}
		
		
		void KopiujToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (richTextBox1.SelectionLength > 0) richTextBox1.Copy();
		}
		
		void WytnijToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (richTextBox1.SelectionLength > 0) richTextBox1.Cut();
		}
		
		void WklejToolStripMenuItemClick(object sender, EventArgs e)
		{
			richTextBox1.Paste();
		}
		
		void ZaznaczWszystkoToolStripMenuItemClick(object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}
		
		void CzcionkaToolStripMenuItemClick(object sender, EventArgs e)
		{
			fontDialog1.Font = richTextBox1.SelectionFont;
			fontDialog1.Color = richTextBox1.SelectionColor;
			if (fontDialog1.ShowDialog() == DialogResult.OK)
			{
				richTextBox1.SelectionFont = fontDialog1.Font;
				richTextBox1.SelectionColor = fontDialog1.Color;
			}
			Naglowek();
		}
		
		bool Zamykanie()
		{
			bool Zwracany = false;
			
			if (richTextBox1.Modified == true)
			{				
				DialogResult Wynik;
				Wynik = MessageBox.Show ("Czy zapisać zmiany w aktualnym dokumencie?","Zmiany",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
				if (Wynik == DialogResult.Yes)
				{
					ZapiszToolStripMenuItemClick (this,null);
				} else if (Wynik == DialogResult.No)
				{
					Zwracany = false;
				} else 
				{
					Zwracany = true;
				}				
			}
			
			return Zwracany;
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = Zamykanie();
		}
	}
}
