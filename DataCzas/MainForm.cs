
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DataCzas
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
			string[] Lista;
			int DniWMiesiacu;
			DateTime Czas2;
			
			//DateTime Czas = new DateTime (2011,11,15,15,37,10); //new DateTime();
			
			DateTime Czas = DateTime.Now;
			//DateTime Czas = DateTime.UtcNow;
			
			richTextBox1.Clear();
			richTextBox1.AppendText ("Mamy rok: " + Czas.Year + "\n");
			richTextBox1.AppendText ("Miesiąc: " + Czas.Month + "\n");
			richTextBox1.AppendText ("Dzień: " + Czas.Day + "\n");
			
			string Dzien = "";
			DayOfWeek DzienTygodnia = Czas.DayOfWeek;
			
			switch (DzienTygodnia)
			{
				case DayOfWeek.Monday    : Dzien = "Poniedziałek";
										   break;
				case DayOfWeek.Tuesday   : Dzien = "Wtorek";
										   break;	
				case DayOfWeek.Wednesday : Dzien = "środa";
										   break;		
				case DayOfWeek.Thursday  : Dzien = "Czwartek";
										   break;				
				case DayOfWeek.Friday 	 : Dzien = "Piątek";
										   break;		
				case DayOfWeek.Saturday  : Dzien = "Sobota";
										   break;		
				case DayOfWeek.Sunday    : Dzien = "Niedziela";
										   break;										
				default : Dzien = "inny";
						  break;					   	
					
			}
			richTextBox1.AppendText ("Dzień tygodnia: " + Dzien + "\n");
			richTextBox1.AppendText ("Dzień roku: " + Czas.DayOfYear + "\n");
			
			DniWMiesiacu = DateTime.DaysInMonth (Czas.Year,Czas.Month);
			richTextBox1.AppendText ("Ten miesiąc ma dni: " + DniWMiesiacu + "\n");
			
			richTextBox1.AppendText ("Aktualna godzina: " + Czas.Hour +
 			                          ":" + Czas.Minute + ":" + Czas.Second +
 			                          " milisekundy " + Czas.Millisecond + "\n");
			
			richTextBox1.AppendText ("\nDostępne formaty czasu i daty: \n");
			Lista = Czas.GetDateTimeFormats();
			foreach (string Txt in Lista)
			{
				richTextBox1.AppendText (Txt + "\n");
			}
						
			Czas2 = Czas.Add (new TimeSpan (20,15,10));
			Lista = Czas2.GetDateTimeFormats();
			richTextBox1.AppendText ("\nZa 20 godzin, 15 minut i 10 sekund będzie: " + Lista[4] + "\n");
			
			Czas2 = Czas.Add (new TimeSpan (40,20,15,10));
			Lista = Czas2.GetDateTimeFormats();
			richTextBox1.AppendText ("\nZa 40 dni, 20 godzin, 15 minut i 10 sekund będzie: " + Lista[4] + "\n");
			
			Czas2 = Czas.AddYears (15).AddMonths(10).AddDays(5);
			Lista = Czas2.GetDateTimeFormats();
			richTextBox1.AppendText ("\nZa 15 lat 10 miesięcy i 5 dni będzie: " + Lista[4] + "\n");
			
			Czas2 = Czas.ToUniversalTime();
			richTextBox1.AppendText ("Czas UTC: " + Czas2.ToLongDateString() + 
			                         " Godzina " + Czas2.ToLongTimeString() + "\n");
			
			Czas2 = Czas.ToLocalTime();
			richTextBox1.AppendText ("Czas lokalny: " + Czas2.ToLongDateString() + 
			                         " Godzina " + Czas2.ToLongTimeString() + "\n");
			
		}
	}
}
