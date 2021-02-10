
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Okna
{
	/// <summary>
	/// Description of Forma1.
	/// </summary>
	public partial class Forma1 : Form
	{
		public Forma1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			MessageBox.Show ("Kliknięto przycisk Anuluj.");
		}
	}
}
