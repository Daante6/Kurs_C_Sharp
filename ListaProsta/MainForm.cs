
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ListaProsta
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
			listBox1.Items.Clear();
			checkedListBox1.Items.Clear();
			for (int i = 0; i<60;i++)
			{
				listBox1.Items.Add ("Element nr " + i);
				checkedListBox1.Items.Add ("Element nr " + i);
			}
			
			for (int i = 0;i<checkedListBox1.Items.Count;i = i + 3)
			{
				checkedListBox1.SetItemCheckState (i,CheckState.Indeterminate);				
			}
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			listBox1.Items.Add (textBox1.Text);
			checkedListBox1.Items.Add (textBox1.Text);
			textBox1.Text = "";
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			int Indeks = listBox1.SelectedIndex;
			richTextBox1.Clear();
			richTextBox1.AppendText ("Aktualna pozycja: " + Indeks + "\n");
			if (Indeks >= 0)
			{
				richTextBox1.AppendText ("Wybrany element: " + listBox1.Items[Indeks] + "\n");
			}
			
			richTextBox1.AppendText ("Zaznaczone elementy: \n");
			for (int i = 0;i<listBox1.SelectedItems.Count;i++)
			{
				richTextBox1.AppendText(listBox1.SelectedItems[i] + "\n");
			}
			
			//listBox1.SetSelected (Indeks,true)
			richTextBox1.AppendText ("Zaznaczone indeksy: \n");
			for (int i = 0;i<listBox1.Items.Count;i++)
			{
				if (listBox1.GetSelected (i) == true)
				{
					richTextBox1.AppendText (i +", ");
				}
			}
			richTextBox1.AppendText ("\n");
			
		}
		
		void CheckedListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			int Indeks = checkedListBox1.SelectedIndex;
			richTextBox2.Clear();
			richTextBox2.AppendText ("Aktualna pozycja: " + Indeks + "\n");
			if (Indeks >= 0)
			{
				richTextBox2.AppendText ("Wybrany element: " +  checkedListBox1.Items[Indeks] + "\n");
			}
			
			richTextBox2.AppendText ("Zaznaczone elementy: \n");
			for (int i = 0;i<checkedListBox1.CheckedItems.Count;i++)
			{
				richTextBox2.AppendText(checkedListBox1.CheckedItems[i] + "\n");
			}
			
			//checkedListBox1.SetItemChecked (Indeks,true);
			richTextBox2.AppendText ("Zaznaczone indeksy: \n");
			for (int i = 0;i<checkedListBox1.Items.Count;i++)
			{
				if (checkedListBox1.GetItemChecked(i) == true)
				{
					richTextBox2.AppendText (i +", ");
				}
			}
			richTextBox2.AppendText ("\n");
			
			CheckState Zaznaczenie;
			richTextBox2.AppendText ("Elementy nie ustalone: \n");
			for (int i = 0;i<checkedListBox1.Items.Count;i++)
			{
				Zaznaczenie = checkedListBox1.GetItemCheckState(i);
				if (Zaznaczenie == CheckState.Indeterminate)
				{
					richTextBox2.AppendText (checkedListBox1.Items[i] + "\n");
				}
			}
			richTextBox2.AppendText ("\n");
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex >= 0)
			{
			 listBox1.Items.RemoveAt (listBox1.SelectedIndex);
			}
			
			if (checkedListBox1.SelectedIndex >= 0)
			{
			 checkedListBox1.Items.RemoveAt (checkedListBox1.SelectedIndex);
			}
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			int Indeks = listBox1.SelectedIndex;
			if (Indeks >=0)
			{
			 listBox1.Items.Insert (Indeks,textBox1.Text);
			}
			
			Indeks = checkedListBox1.SelectedIndex;
			if (Indeks >=0)
			{
			 checkedListBox1.Items.Insert (Indeks,textBox1.Text);
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			checkedListBox1.Items.Clear();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
		 listBox1.ColumnWidth = 90;
		 checkedListBox1.ColumnWidth = 90;
		 listBox1.MultiColumn = !listBox1.MultiColumn;
		 checkedListBox1.MultiColumn = !checkedListBox1.MultiColumn;
		}
	}
}
