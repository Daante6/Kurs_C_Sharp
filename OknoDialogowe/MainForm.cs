﻿
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OknoDialogowe
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
			
			MessageBox.Show ("Okno podstawowe");
			MessageBox.Show ("Okno z przyciskami MessageBoxButtons.OKCancel","MessageBox",MessageBoxButtons.OKCancel);
			MessageBox.Show ("Okno z przyciskami MessageBoxButtons.YesNo","MessageBox",MessageBoxButtons.YesNo);
			MessageBox.Show ("Okno z przyciskami MessageBoxButtons.YesNoCancel","MessageBox",MessageBoxButtons.YesNoCancel);
			MessageBox.Show ("Okno z przyciskami MessageBoxButtons.RetryCancel","MessageBox",MessageBoxButtons.RetryCancel);
			MessageBox.Show ("Okno z przyciskami MessageBoxButtons.AbortRetryIgnore","MessageBox",MessageBoxButtons.AbortRetryIgnore);
	
			MessageBox.Show ("Okno z ikoną MessageBoxIcon.Information","MessageBox",MessageBoxButtons.OK,MessageBoxIcon.Information); //informacje dla użytkownika
			MessageBox.Show ("Okno z ikoną MessageBoxIcon.Question","MessageBox",MessageBoxButtons.OK,MessageBoxIcon.Question);	//nie jest rekomendowana
			MessageBox.Show ("Okno z ikoną MessageBoxIcon.Warning","MessageBox",MessageBoxButtons.OK,MessageBoxIcon.Warning);	//ostrzeżenie	
			MessageBox.Show ("Okno z ikoną MessageBoxIcon.Error","MessageBox",MessageBoxButtons.OK,MessageBoxIcon.Error); //informacja o błędzie programu
			MessageBox.Show ("Okno z ikoną MessageBoxIcon.None","MessageBox",MessageBoxButtons.OK,MessageBoxIcon.None);	//domyślna, jesli wywołana z mniej niż 4 argumentami
			
			//messagebox default button - jest zaznaczony, będzie wciśnięty po kliknięciu enter ; button 1/2/3 licząc od lewej
			MessageBox.Show ("Okno z przyciskami MessageBoxButtons.YesNoCancel i domyślnym przyciskiem MessageBoxDefaultButton.Button2","MessageBox",MessageBoxButtons.YesNoCancel,MessageBoxIcon.None,MessageBoxDefaultButton.Button2);
			
			// 6. argument - zachowanie tekstu okienka. Tzn wyrównanie domyślne, do prawej itp
			//rtl reading - jakby justowanie
			//service notification - okno nie utraci focusu
			MessageBox.Show ("Okno w trybie MessageBoxOptions.DefaultDesktopOnly","MessageBox",MessageBoxButtons.OK,MessageBoxIcon.None,MessageBoxDefaultButton.Button1,MessageBoxOptions.DefaultDesktopOnly);
			MessageBox.Show ("Okno w trybie MessageBoxOptions.RightAlign\nNowa linia","MessageBox",MessageBoxButtons.OK,MessageBoxIcon.None,MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);
			MessageBox.Show ("Okno w trybie MessageBoxOptions.RtlReading\nNowa linia","MessageBox",MessageBoxButtons.OK,MessageBoxIcon.None,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading);
			MessageBox.Show ("Okno w trybie MessageBoxOptions.ServiceNotification","MessageBox",MessageBoxButtons.OK,MessageBoxIcon.None,MessageBoxDefaultButton.Button1,MessageBoxOptions.ServiceNotification);
          
         //typ zmiennej do przechowywania odpowiedzi okna dialogowego
         DialogResult Wynik;
         
         Wynik = MessageBox.Show ("Wybierz przycisk","MessageBox",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
         if (Wynik == DialogResult.Yes)
          {
         	MessageBox.Show ("Naciśnięto przycisk Tak.","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);         	
         } else if (Wynik == DialogResult.No)
         	{
             	MessageBox.Show ("Naciśnięto przycisk Nie.","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);         	
     	
         	} else if (Wynik == DialogResult.Cancel) 
         		{
              	  MessageBox.Show ("Naciśnięto przycisk Anuluj.","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);         	
         		};
		}
	}
}
