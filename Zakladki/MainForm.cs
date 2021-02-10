
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zakladki
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		string OdczytajOsobe (int Numer)
		{
			string Wynik = "";
			string Nazwa = "";
			int licznik = 0;
			
			if ((Numer >= 0) && (Numer < tabControl1.TabPages.Count))
			{
				TabPage Zakladka = tabControl1.TabPages[Numer];
				for (int i = 0; i<Zakladka.Controls.Count; i++)
				{
					Nazwa = Zakladka.Controls[i].Name;
					if (Nazwa == "Im")
					{
						Wynik += Zakladka.Controls[i].Text + " ";
						if (Zakladka.Controls[i].Text != "") licznik++;
					} else if (Nazwa == "Naz")
					{
						Wynik += Zakladka.Controls[i].Text + " ";
						if (Zakladka.Controls[i].Text != "") licznik++;
					}
				}
			}
			
			if (licznik == 0) Wynik = "";
			return Wynik;
		}
		
		void Pokaz (object s, EventArgs e)
		{
			int Indeks = tabControl1.SelectedIndex;
			string Tekst = OdczytajOsobe (Indeks);
			MessageBox.Show (Tekst,"Dane z zakładki");
			//MessageBox.Show ("Zdarzenie Click");
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			TabControl1SelectedIndexChanged (this,null);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TabControl1SelectedIndexChanged(object sender, EventArgs e)
		{
			label2.Text = "Wybrano zakładkę o indeksie " + tabControl1.SelectedIndex;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			int Indeks = tabControl1.TabPages.Count + 1;
			TabPage Zakladka = new TabPage();
			Zakladka.Text = "Osoba nr " + Indeks;
			
			Label Etykieta = new Label();
			Etykieta.Text = "Nazwisko nr " + Indeks;
			Etykieta.Left = 10;
			Etykieta.Top = 10;
			Etykieta.TextAlign = ContentAlignment.MiddleCenter;
			Etykieta.AutoSize = true;
			Zakladka.Controls.Add (Etykieta);
			
			TextBox Pole = new TextBox();
			Pole.Name = "Naz";
			Pole.Top = Etykieta.Top;
			Pole.Left = Etykieta.Left + Etykieta.Width + 10;
			Pole.Width = 200;
			Zakladka.Controls.Add (Pole);
			
			Label Etykieta2 = new Label();
			Etykieta2.Text = "Imię nr " + Indeks;
			Etykieta2.Left = Etykieta.Left;
			Etykieta2.Top = Etykieta.Top + Etykieta.Height + 10;
			Etykieta2.TextAlign = ContentAlignment.MiddleCenter;
			Etykieta2.AutoSize = true;
			Zakladka.Controls.Add (Etykieta2);
			
			TextBox Pole2 = new TextBox();
			Pole2.Name = "Im";
			Pole2.Top = Etykieta2.Top;
			Pole2.Left = Pole.Left;
			Pole2.Width = 200;
			Zakladka.Controls.Add (Pole2);
			
			Button Przycisk = new Button();
			Przycisk.Text = "Pokaż";
			Przycisk.Left = 10;
			Przycisk.Top = Etykieta2.Top + Etykieta2.Height + 25;
			Przycisk.Click+= new EventHandler (this.Pokaz);
			Zakladka.Controls.Add (Przycisk);
			
			tabControl1.TabPages.Add(Zakladka);
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			int Indeks = tabControl1.SelectedIndex;
			if (Indeks >= 1)
			{
				tabControl1.TabPages.RemoveAt (Indeks);
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string Tekst = "";
			string Wynik;
			
			for (int i = 0; i <tabControl1.TabPages.Count;i++)
			{
				Wynik = OdczytajOsobe (i);
				if (Wynik != "")
				{
					Tekst += Wynik + "\n"; 
				}				
			}
			MessageBox.Show (Tekst,"Dane osób");
		}
	}
}
