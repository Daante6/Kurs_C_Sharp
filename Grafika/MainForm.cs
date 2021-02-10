
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

//using System.Drawing.Drawing2D;

namespace Grafika
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Pen Pioro = new Pen(Color.Black,4);
		Point Pkt1 = new Point (10,10);
		Point Pkt2 = new Point (10,100);
		Rectangle Prostokat = new Rectangle (110,10,100,100);
		Font Czcionka = new Font ("Arial",18,FontStyle.Italic);
		SolidBrush Pendzel = new SolidBrush (Color.Blue);
		Rectangle Obszar = new Rectangle (340,10,100,100);
		System.Drawing.Drawing2D.LinearGradientBrush Pendzel2 = new System.Drawing.Drawing2D.LinearGradientBrush (new Point (229,120), new Point (439,190),Color.Red,Color.Green);
		Point Pozycja = new Point(230,120);
		Image Obraz = null;
		Image Obraz2 = null;
		TextureBrush Pendzel3;
		Font Czcionka2 = new Font ("Arial",55,FontStyle.Bold);
		Point[] Punkty = new Point[7];
		Graphics Graf;
		Bitmap Bitmapa;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Width = 490;
			Height = 600;
			button1.Left = DisplayRectangle.Width - button1.Width;
			button1.Top = DisplayRectangle.Height - button1.Height;
									
			try
			{
		  	 Obraz = Image.FromFile ("C:\\obraz.jpg");
			} catch (Exception)
			{
				Obraz = null;
				MessageBox.Show ("Brak pliku C:\\obraz.jpg","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			try
			{
		  	 Obraz2 = Image.FromFile ("C:\\obraz2.jpg");
			} catch (Exception)
			{
				Obraz2 = null;
				MessageBox.Show ("Brak pliku C:\\obraz2.jpg","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			
			if (Obraz2 != null)
			{
				Pendzel3 = new TextureBrush (Obraz2);
			}
			
			int mnoznik = 1;
			for (int i = 0;i<Punkty.Length;i++)
			{
				if ((double)i/2 == i/2) 
				{
					mnoznik = -1;
				} else
			 	 {
				  mnoznik = 1;	
				 }
				Punkty[i].X = 400 + (i*10)*mnoznik;
				Punkty[i].Y = 320 + (i*20);
			}
			
            Bitmapa = new Bitmap (DisplayRectangle.Width,DisplayRectangle.Height);			
			Graf = Graphics.FromImage (Bitmapa);
			
			Pendzel.Color = Color.Blue;
			Pioro.Color = Color.Black;
			Pioro.Width = 4;
			Graf.DrawLine (Pioro,Pkt1,Pkt2);
			
			Pioro.Color = Color.Yellow;
			Pioro.Width = 3;
			Graf.DrawLine (Pioro,10,10,100,10);
			
			Graf.DrawLine (new Pen (Color.Red,2),new Point (10,10), new Point (100,100));
			
			Pioro.Color = Color.Black;
			Pioro.Width = 4;
			Prostokat.X = 110;
			Prostokat.Y = 10;
			Prostokat.Width = 100;
			Prostokat.Height = 100;			
			Graf.DrawRectangle (Pioro,Prostokat);
			Pioro.Color = Color.Yellow;
			Graf.DrawRectangle (Pioro,130,30,60,60);
			
			Pioro.Color = Color.Blue;
			Graf.DrawEllipse (Pioro,110,10,100,100);
			
			Pioro.Color = Color.Red;
			Prostokat.X = 130;
			Prostokat.Y = 30;
			Prostokat.Width = 60;
			Prostokat.Height = 60;
			Graf.DrawEllipse (Pioro,Prostokat);
			
			Pioro.Color = Color.Black;
			Graf.DrawArc (Pioro,230,10,100,100,0,90);
			
			Pioro.Color = Color.Blue;
			Prostokat.X = 230;
			Prostokat.Y = 10;
			Prostokat.Width = 100;
			Prostokat.Height = 100;
			Graf.DrawArc (Pioro,Prostokat,180,90);
			
			Pioro.Color = Color.Black;
			Pioro.Width = 1;
			Graf.DrawRectangle (Pioro,Obszar);
			Graf.DrawString ("Przykładowy tekst",Czcionka,Pendzel,Obszar);
			
			Pendzel.Color = Color.Green;
			Graf.DrawString ("Przykładowy tekst 2",Czcionka,Pendzel,10,120);
			
			Graf.DrawString ("Przykładowy tekst 3",Czcionka,Pendzel2,Pozycja);
			
			if (Obraz != null)
			{
			 Graf.DrawImage (Obraz,10,160);
			 Graf.DrawImage (Obraz,250,160,200,40);
			}
			
			if (Obraz2 != null)
			{
				Graf.DrawString ("Tekst",Czcionka2,Pendzel3,235,190);
			}
			
			Graf.FillEllipse (Pendzel3, 10,340,140,100);
			
			Prostokat.X = 160;
			Prostokat.Y = 340;
			Prostokat.Width = 140;
			Prostokat.Height = 100;
			Graf.FillEllipse (Pendzel3, Prostokat);
			
			Graf.FillPie (Pendzel3,10,460,100,100,25,270);
			
			Prostokat.X = 20;
			Prostokat.Y = 455;
			Prostokat.Width = 100;
			Prostokat.Height = 100;
			Graf.FillPie (Pendzel3,Prostokat,295,90);
			
			Pioro.Color = Color.Red;
			Pioro.Width = 2;
			//Graf.DrawLines (Pioro,Punkty);
			//Graf.DrawCurve (Pioro,Punkty);
			//Graf.DrawClosedCurve (Pioro,Punkty);
			Graf.FillClosedCurve (Pendzel3,Punkty);
			
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormPaint(object sender, PaintEventArgs e)
		{
		 e.Graphics.DrawImage (Bitmapa,0,0);	
			
		}
		
		void Button1Paint(object sender, PaintEventArgs e)
		{
			if (Obraz != null)
			{			 
			 e.Graphics.DrawImage (Obraz,0,0,button1.Width,button1.Height);
			}
		}
	}
}
