
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ListaZlozona
{
	
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int NumerKolumny = 1;
		int NumerElementu = 1;
		int NumerObrazka = 0;
		int NumerGrupy = 1;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Grupy();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		void Button1Click(object sender, EventArgs e)
		{
			ColumnHeader Kolumna = new ColumnHeader();
			Kolumna.Text = "Kolumna nr " + NumerKolumny;
			NumerKolumny++;
			listView1.Columns.Add (Kolumna);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
		 int Liczba = listView1.Columns.Count;
		 if (Liczba > 0)
		 {
		 	listView1.Columns.RemoveAt (Liczba - 1);
		 	NumerKolumny--;
		 	if (NumerKolumny < 1) NumerKolumny = 1;
		 }
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			ListViewItem Element = new ListViewItem();
			Element.Text = "Element nr " + NumerElementu;
			NumerElementu++;
			Element.ImageIndex = NumerObrazka;
			NumerObrazka++;
			if (NumerObrazka >= imageList1.Images.Count) NumerObrazka = 0;
			if (NumerObrazka >= imageList2.Images.Count) NumerObrazka = 0;
			
			for (int i = 0; i<(listView1.Columns.Count-1);i++)
			{
			 Element.SubItems.Add ("Podelement nr " + i);
			}
			listView1.Items.Add (Element);
		}
		
		
		
		void Button4Click(object sender, EventArgs e)
		{
			for (int i =  listView1.SelectedItems.Count - 1; i >= 0;i--)
			{
				listView1.SelectedItems[i].Remove();
			}
		}
		
		void Button5Click(object sender, EventArgs e)
		{			
		 listView1.View = View.LargeIcon;	
		}
		
		void Button6Click(object sender, EventArgs e)
		{			
		 listView1.View = View.SmallIcon;		
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			listView1.View = View.Details;
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			listView1.View = View.List;	
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			listView1.View = View.Tile;
		}
		
		void Grupy ()
		{
			listBox1.Sorted = false;
			listBox1.SelectionMode = SelectionMode.One;
			listBox1.Items.Clear();
			for (int i = 0; i <listView1.Groups.Count;i++)
			{
				listBox1.Items.Add (listView1.Groups[i].Header);
			}
		}
		
		
		void Button10Click(object sender, EventArgs e)
		{
			ListViewGroup Grupa = new ListViewGroup();
			Grupa.Header = "Grupa nr " + NumerGrupy;
			NumerGrupy++;
			listView1.Groups.Add (Grupa);
			Grupy();
		}
		
		void Button11Click(object sender, EventArgs e)
		{
		 int Indeks = listBox1.SelectedIndex;
         
		 if ((Indeks >= 0) && (Indeks < listView1.Groups.Count))
		 {
		 	listView1.Groups.RemoveAt (Indeks);
		 }
		 Grupy();
		}
		
		void Button12Click(object sender, EventArgs e)
		{
		  int Indeks = listBox1.SelectedIndex;
         
		 if ((Indeks >= 0) && (Indeks < listView1.Groups.Count))
		 {
		 	for (int i = 0; i < listView1.SelectedItems.Count;i++)
		 	{
		 		listView1.SelectedItems[i].Group = listView1.Groups[Indeks];
		 	}
		 }
		}
		
		void ListView1SelectedIndexChanged(object sender, EventArgs e)
		{
			richTextBox1.Clear();
			if (listView1.SelectedItems.Count > 0)
			{
				richTextBox1.AppendText ("***Wybrane elementy: \n");
				for (int i = 0; i < listView1.SelectedItems.Count;i++)
				{
					richTextBox1.AppendText(listView1.SelectedItems[i].Text + "\n");
				}
			}
		}
	}
}
