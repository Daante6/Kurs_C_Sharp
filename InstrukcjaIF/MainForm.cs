
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InstrukcjaIF
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
		 string Tekst;
         int Wiek;
         char Znak;
         string Tekst2 = "";

         Tekst = textBox1.Text;
         for (int i = 0;i<Tekst.Length;i++)
         {
         	Znak = Tekst[i];
         	if ((Znak>='0') && (Znak<='9'))
         	{
         	 Tekst2 = Tekst2 + Znak;	
         	};
         }
         
         if (Tekst2 == "")
         {
          Tekst2 = "0";	
         };
         
         MessageBox.Show ("Tekst2 = " + Tekst2);
         
         Wiek = Convert.ToInt32 (Tekst2);
         
         if (Wiek >=18) 
         {
         	MessageBox.Show ("Gratulacje!!! Jesteś pełnoletnią osobą.","Warunek spełniony");
         } else
           {
         	if (Wiek<5)
         	{
         	 MessageBox.Show ("Chyba żartujesz !!!. Program zostanie zakończony.","Informacja");	
         	} else 
         	  {
         	    MessageBox.Show ("Jeszcze nie jesteś pełnoletnią osobą. Program zostanie zakończony.","Warunek nie spełniony");
         	  };
         	Application.Exit();
           };
         MessageBox.Show ("Witaj w programie.","Informacja");
		}
	}
}
