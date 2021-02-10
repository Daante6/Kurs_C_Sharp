
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.IO;

namespace FolderyPliki
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string Startowy = "C:\\Windows";
		string Plik = @"C:\Testowy.plik";
		
		public MainForm()
		{
			string[] Lista;
			DirectoryInfo Informacja;
			DateTime Czas;
			
			InitializeComponent();
			
			richTextBox1.AppendText ("Bieżący folder aplikacji: " + Directory.GetCurrentDirectory());
			Lista = Directory.GetFiles(Startowy);
			richTextBox1.AppendText ("\n** Zawartość " + Startowy + "\n");
			foreach (string Linia in Lista)
			{
				richTextBox1.AppendText(" + " + Linia);
				Informacja = new DirectoryInfo (Linia);
				richTextBox1.AppendText ("\n   - atrybuty: ");
				
				if (Informacja.Attributes == FileAttributes.Normal)
				{
					richTextBox1.AppendText("brak ");
				}
				if ((Informacja.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
				{
					richTextBox1.AppendText("folder, ");
				}
				if ((Informacja.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
				{
					richTextBox1.AppendText("ukryty, ");
				}
				if ((Informacja.Attributes & FileAttributes.System) == FileAttributes.System)
				{
					richTextBox1.AppendText("systemowy, ");
				}
				if ((Informacja.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					richTextBox1.AppendText("tylko do odczytu, ");
				}
				if ((Informacja.Attributes & FileAttributes.Archive) == FileAttributes.Archive)
				{
					richTextBox1.AppendText("gotowy do archiwizacji, ");
				}
				if ((Informacja.Attributes & FileAttributes.NotContentIndexed) == FileAttributes.NotContentIndexed)
				{
					richTextBox1.AppendText("nie indeksowany, ");
				}
				if ((Informacja.Attributes & FileAttributes.Compressed) == FileAttributes.Compressed)
				{
					richTextBox1.AppendText("kompresowany, ");
				}
				if ((Informacja.Attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted)
				{
					richTextBox1.AppendText("szyfrowany, ");
				}
				
				richTextBox1.AppendText ("\n   - Data: ");
				Czas = Informacja.CreationTime;
				richTextBox1.AppendText (Czas.ToLongDateString()+ " Czas: " + Czas.ToLongTimeString());
				
				richTextBox1.AppendText ("\n   - Nazwa: " + Informacja.Name);
				richTextBox1.AppendText ("\n   - Rozszerzenie: " + Informacja.Extension);
				richTextBox1.AppendText ("\n   - Folder nadrzędny: " + Informacja.Parent);				
				richTextBox1.AppendText ("\n");
				
			}
			
			if (File.Exists(Plik) == false)
			{
				FileStream Strumien = File.Create (Plik);
				//Strumien.SetLength (2048);
				Strumien.Position = 2044;
				Strumien.WriteByte (65);
				Strumien.WriteByte (66);
				Strumien.WriteByte (67);
				Strumien.Position = 4095;
				Strumien.WriteByte (90);
				Strumien.Close();
				Informacja = new DirectoryInfo (Plik);
				
				Informacja.CreationTime = new DateTime (2015,01,25);
				Informacja.Attributes = FileAttributes.Archive | FileAttributes.ReadOnly;
				//File.Create (Plik).Close();
				MessageBox.Show ("Plik: " + Plik + " został utworzony","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
			} else
			{
				MessageBox.Show ("Plik: " + Plik + " juz istnieje !!!","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);				
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
		 string Folder = textBox1.Text;
		 if (Directory.Exists (Folder) == false)
		 {
		 	Directory.CreateDirectory (Folder);
		 	MessageBox.Show ("Folder: " + Folder + " został utworzony.","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
		 } else
		 {
		 	MessageBox.Show ("Folder: " + Folder + " juz istnieje !!!","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
		 }
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		 string Folder = textBox1.Text;
		 if (Directory.Exists (Folder) == true)
		 { 
		 	try
		 	{
		 	 Directory.Delete (Folder,true);
		 	 MessageBox.Show ("Folder: " + Folder + " został usunięty.","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
		 	} catch (Exception Wyjatek)
		 	 {
		 		MessageBox.Show ("Folder nie może zostać usunięty. " + Wyjatek.Message,"Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
		 	 }		 		
		 			 	
		 } else
		  {
		 	MessageBox.Show ("Folder: " + Folder + " nie istnieje !!!","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
		  }
		 
		 if (File.Exists (Plik) == true)
		 {
		 	File.SetAttributes (Plik,FileAttributes.Normal);
		 	File.Delete (Plik);
		 	MessageBox.Show ("Plik: " + Plik + " został usunięty","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
		 } else
		 {
		 	MessageBox.Show ("Plik: " + Plik + " nie istnieje !!!","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
		 }
		}
	}
}
