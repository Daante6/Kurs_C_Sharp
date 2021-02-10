
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

namespace ZapisOdczyt
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
			DialogResult Wynik;
			
			Wynik = openFileDialog1.ShowDialog();
			
			if (Wynik == DialogResult.OK)
			{
				richTextBox1.Clear();
				string Nazwa = openFileDialog1.FileName;
				string Linia;
				int Licznik = 1;
				try
				{
					//StreamReader Dane = new StreamReader (Nazwa);
					
					FileStream Strumien = new FileStream (Nazwa,FileMode.Open,FileAccess.Read,FileShare.ReadWrite);
					StreamReader Dane = new StreamReader (Strumien);
					
					while (Dane.EndOfStream == false)
					{
					 Linia = Dane.ReadLine();					 
					 richTextBox1.AppendText (Licznik + ": " + Linia + "\n");
					 Licznik++;
					}
					
					Dane.Close();					
				} catch (IOException Wyjatek)
				  {
					MessageBox.Show ("Wystąpił błąd: " + Wyjatek.Message,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
				  }
			}
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			DialogResult Wynik = saveFileDialog1.ShowDialog();
			if (Wynik == DialogResult.OK)
			{
				string Nazwa = saveFileDialog1.FileName;
				string Linia;
				FileMode Tryb;
				if (File.Exists (Nazwa) == false)
				{
					Tryb = FileMode.CreateNew;
				} else
				  {
				  // Tryb = FileMode.Append;
				  // MessageBox.Show ("Plik juz istnieje. Tekst zostanie do niego dopisany","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
				  Tryb = FileMode.Create;
				  }
				
				try
				{
					FileStream Strumien = new FileStream (Nazwa,Tryb);
					StreamWriter Dane = new StreamWriter (Strumien);
					
					int Ile = richTextBox1.Lines.Length;
					for (int i = 0; i<Ile;i++)
					{
						Linia = richTextBox1.Lines[i];
						Dane.WriteLine (Linia);
					}
					
					Dane.Close();
					Strumien.Close();
					
				} catch (IOException Wyjatek)
				  {
					MessageBox.Show ("Wystąpił błąd: " + Wyjatek.Message,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
				  }
			}
		}
	}
}
