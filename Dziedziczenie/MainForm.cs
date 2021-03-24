
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dziedziczenie
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	class K_Zwierzak
	{
		protected string Nazwa;
		protected int Wiek;
		
		public void PobierzDane (string Naz, int Wi)
		{
			Nazwa = Naz;
			Wiek = Wi;
		}
		
		public void PokazDane ()
		{
			MessageBox.Show ("Nazwa = " + Nazwa + "\nWiek = " + Wiek, "K_Zwierzak",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
		}
	}
	
	class K_Czlowiek : K_Zwierzak 
	{
	 string Adres;

	 public void PobierzDane (string Naz, int Wi, string Adr)
		{
	 	 PobierzDane (Naz,Wi);
	 	 PobierzAdres (Adr);
		}
	 // "new" oznacza tu, że zasłaniamy dziedziczoną metodę PokazDane, ale zachowujemy obie wersje. Wywołac "starą" wersję możemy używając base.
	 new public void PokazDane ()
		{
			MessageBox.Show ("Nazwa = " + Nazwa + "\nWiek = " + Wiek + "\nAdres = " + Adres, "K_Czlowiek",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
		}
	 
	 public void PokazDane (bool Naz, bool Adr)
	 {
	 	if (Naz == true)
	 	{
	 		base.PokazDane();
	 	}
	 
        if (Adr == true)
	 	{
        	PokazAdres();
	 	}	 	
	 }
	 
	 public void PobierzAdres (string Adr)
	 {
	 	Adres = Adr;
	 }
	 
	 public void PokazAdres()
	 {
	 	MessageBox.Show ("Adres = " + Adres, "K_Człowiek",MessageBoxButtons.OK,MessageBoxIcon.Information);
	 	//Nazwa+= " Zmodyfikowano";
	 }
	}
	
	
	class K_Firma : K_Czlowiek
	{
	 	string NIP;
	 	
	 	public void PobierzNIP (string ni)
	 	{
	 		NIP = ni;
	 	}
	 	
	 	public void PokazNIP()
	 	{
	 	 MessageBox.Show ("NIP = " + NIP, "K_Firma",MessageBoxButtons.OK,MessageBoxIcon.Information);	
	 	 //Nazwa+=" Zmodyfikowane w klasie K_Firma";
	 	}
	 	
	 	new public void PokazDane ()
		{
	 		base.PokazDane();
	 		PokazNIP();
		}
	 	
	 	public void PobierzDane (string Naz, int Wi, string Adr, string ni)
	 	{
	 		//PobierzDane (Naz,Wi,Adr);
	 		PobierzDane (Naz,Wi);
	 		PobierzAdres (Adr);
	 		PobierzNIP (ni); 		
	 	}
	}
	public partial class MainForm : Form
	{
		K_Zwierzak Zwierzak = new K_Zwierzak();
		K_Czlowiek Czlowiek = new K_Czlowiek();
		K_Firma Firma = new K_Firma();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			Zwierzak.PobierzDane ("Reksio",2);
			//Czlowiek.PobierzDane ("Adam",45);
			//Czlowiek.PobierzAdres ("Kościuszki 32 48-340 Głuchołazy");
			Czlowiek.PobierzDane ("Adam",45,"Kościuszki 32 48-340 Głuchołazy");
			Firma.PobierzDane ("Globalprofit",8,"Kościuszki 32 48-340 Głuchołazy","753-203-92-36");
				
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Zwierzak.PokazDane();
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Czlowiek.PokazDane();
			Czlowiek.PokazDane (true,false);
			//Czlowiek.PokazAdres();
			//Czlowiek.Nazwa+= " Zmodyfikowano na zewnątrz";
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Firma.PokazDane();
			//Firma.PokazNIP();
			
		}
	}
}
