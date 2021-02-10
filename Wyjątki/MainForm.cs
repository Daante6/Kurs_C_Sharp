
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Wyjątki
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		double[] Tablica = new double[10];
		
		public MainForm()
		{
			
			InitializeComponent();		
			
			for (int i = 0; i<Tablica.Length; i++)
			{
				Tablica[i] = 1.1;
			}
			richTextBox1.Clear();
			richTextBox1.AppendText ("Elementy tablicy:\n");
			foreach (double Element in Tablica)
			{
				richTextBox1.AppendText (Convert.ToString (Element) + "\n");
			}
			
		}	
		
		void Button1Click(object sender, EventArgs e)
		{
		 uint Indeks;
		 double Wartosc;		 
		 
		 richTextBox1.Clear();
		 try
		 {
		   Indeks = Convert.ToUInt32(numericUpDown1.Value);
		   Wartosc = Convert.ToDouble (textBox1.Text);
		 
		  Tablica[Indeks] = Wartosc;
		 }		 
		 catch (FormatException)
		 {
		 	MessageBox.Show ("Nieprawidłowy format danych!!! ","Wyjątek",MessageBoxButtons.OK,MessageBoxIcon.Warning);
		 }		 
		 catch (IndexOutOfRangeException)
		 {
		 	MessageBox.Show ("Próba dostępu do niewłaściwego elementu tablicy!!!","Wyjątek",MessageBoxButtons.OK,MessageBoxIcon.Warning);
		 }
	 	 catch (Exception Wyjatek)
		 {
		 	MessageBox.Show ("Wystąpił wyjątek: " + Wyjatek.Message,"Wyjątek",MessageBoxButtons.OK,MessageBoxIcon.Warning);
		 }
	 	 finally
	 	 {
	 	 	MessageBox.Show ("Blok Finally","Finally",MessageBoxButtons.OK,MessageBoxIcon.Information);
	 	 }
		 richTextBox1.AppendText ("Elementy tablicy:\n");
		 foreach (double Element in Tablica)
			{
				richTextBox1.AppendText (Convert.ToString (Element) + "\n");
			}
		 /*Exception		  
		  *    *ArithmeticException 
		  *      - DivideByZeroException 
		  *      - NotFiniteNumberException 
		  *      - OverflowException
		  *    *FormatException
		  *    *IndexOutOfRangeException 
		  *    *InvalidCastException 
		  *    *OutOfMemoryException
		  *    *RankException
		  *    *IOException
		  *     - DirectoryNotFoundException
		  *     - FileNotFoundException
		  *     - PathTooLongException 
		  *     - FileLoadException
		  *     - EndOfStreamException 
		  *    *InternalBufferOverflowException
		  * 
		  * */
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			throw new InvalidCastException();
		}
	}
}
