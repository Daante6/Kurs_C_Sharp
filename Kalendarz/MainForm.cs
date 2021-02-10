
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Kalendarz
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		TimeSpan Wynik;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			DateTimePicker1ValueChanged (this,null);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void DateTimePicker1ValueChanged(object sender, EventArgs e)
		{
			
			Wynik = dateTimePicker1.Value - dateTimePicker2.Value;
			label3.Text = "Różnica czasu wynosi: " + Wynik.Days + " dni " + Wynik.Hours +
				          " godzin " + Wynik.Minutes + " minut " + Wynik.Seconds + " sekund ";
			//monthCalendar1.SelectionStart = dateTimePicker1.Value;
			//monthCalendar1.SelectionEnd = dateTimePicker2.Value;
			MonthCalendar1DateSelected (sender, null);
		}
		
		void MonthCalendar1DateSelected(object sender, DateRangeEventArgs e)
		{		 	
		 Wynik = dateTimePicker1.Value - dateTimePicker2.Value;	
		 DateTime Data = monthCalendar1.SelectionStart;
		 DateTime Data2 = Data.Add (Wynik);
		 label4.Text = "Data po przesunięciu: " + Data2.ToLongDateString() + " czas: " + Data2.ToLongTimeString();
		}
	}
}
