
namespace EdytorTekstu
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.kopiujToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.wklejToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.wytnijToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.czcionkaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.otwórzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zapiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zapiszJakoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.edycjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cofnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.przywróćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.kopiujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wytnijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wklejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.zaznaczWszystkoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.czcionkaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.contextMenuStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
			this.richTextBox1.Location = new System.Drawing.Point(0, 27);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(537, 238);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1TextChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.kopiujToolStripMenuItem1,
									this.wklejToolStripMenuItem1,
									this.wytnijToolStripMenuItem1,
									this.czcionkaToolStripMenuItem1});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(123, 92);
			this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1Opening);
			// 
			// kopiujToolStripMenuItem1
			// 
			this.kopiujToolStripMenuItem1.Name = "kopiujToolStripMenuItem1";
			this.kopiujToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			this.kopiujToolStripMenuItem1.Text = "Kopiuj";
			this.kopiujToolStripMenuItem1.Click += new System.EventHandler(this.KopiujToolStripMenuItemClick);
			// 
			// wklejToolStripMenuItem1
			// 
			this.wklejToolStripMenuItem1.Name = "wklejToolStripMenuItem1";
			this.wklejToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			this.wklejToolStripMenuItem1.Text = "Wklej";
			this.wklejToolStripMenuItem1.Click += new System.EventHandler(this.WklejToolStripMenuItemClick);
			// 
			// wytnijToolStripMenuItem1
			// 
			this.wytnijToolStripMenuItem1.Name = "wytnijToolStripMenuItem1";
			this.wytnijToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			this.wytnijToolStripMenuItem1.Text = "Wytnij";
			this.wytnijToolStripMenuItem1.Click += new System.EventHandler(this.WytnijToolStripMenuItemClick);
			// 
			// czcionkaToolStripMenuItem1
			// 
			this.czcionkaToolStripMenuItem1.Name = "czcionkaToolStripMenuItem1";
			this.czcionkaToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
			this.czcionkaToolStripMenuItem1.Text = "Czcionka";
			this.czcionkaToolStripMenuItem1.Click += new System.EventHandler(this.CzcionkaToolStripMenuItemClick);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripMenuItem1,
									this.edycjaToolStripMenuItem,
									this.informacjaToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(537, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.otwórzToolStripMenuItem,
									this.zapiszToolStripMenuItem,
									this.zapiszJakoToolStripMenuItem,
									this.toolStripSeparator1,
									this.zamknijToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
			this.toolStripMenuItem1.Text = "Plik";
			this.toolStripMenuItem1.DropDownOpening += new System.EventHandler(this.ToolStripMenuItem1DropDownOpening);
			// 
			// otwórzToolStripMenuItem
			// 
			this.otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
			this.otwórzToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.otwórzToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.otwórzToolStripMenuItem.Text = "Otwórz";
			this.otwórzToolStripMenuItem.Click += new System.EventHandler(this.OtwórzToolStripMenuItemClick);
			// 
			// zapiszToolStripMenuItem
			// 
			this.zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
			this.zapiszToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.zapiszToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.zapiszToolStripMenuItem.Text = "Zapisz";
			this.zapiszToolStripMenuItem.Click += new System.EventHandler(this.ZapiszToolStripMenuItemClick);
			// 
			// zapiszJakoToolStripMenuItem
			// 
			this.zapiszJakoToolStripMenuItem.Name = "zapiszJakoToolStripMenuItem";
			this.zapiszJakoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.zapiszJakoToolStripMenuItem.Text = "Zapisz jako ...";
			this.zapiszJakoToolStripMenuItem.Click += new System.EventHandler(this.ZapiszJakoToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
			// 
			// zamknijToolStripMenuItem
			// 
			this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
			this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
			this.zamknijToolStripMenuItem.Text = "Zamknij";
			this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.ZamknijToolStripMenuItemClick);
			// 
			// edycjaToolStripMenuItem
			// 
			this.edycjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cofnijToolStripMenuItem,
									this.przywróćToolStripMenuItem,
									this.toolStripSeparator2,
									this.kopiujToolStripMenuItem,
									this.wytnijToolStripMenuItem,
									this.wklejToolStripMenuItem,
									this.toolStripSeparator3,
									this.zaznaczWszystkoToolStripMenuItem,
									this.czcionkaToolStripMenuItem});
			this.edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
			this.edycjaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.edycjaToolStripMenuItem.Text = "Edycja";
			this.edycjaToolStripMenuItem.DropDownOpening += new System.EventHandler(this.EdycjaToolStripMenuItemDropDownOpening);
			// 
			// cofnijToolStripMenuItem
			// 
			this.cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
			this.cofnijToolStripMenuItem.ShortcutKeyDisplayString = "";
			this.cofnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.cofnijToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.cofnijToolStripMenuItem.Text = "Cofnij";
			this.cofnijToolStripMenuItem.Click += new System.EventHandler(this.CofnijToolStripMenuItemClick);
			// 
			// przywróćToolStripMenuItem
			// 
			this.przywróćToolStripMenuItem.Name = "przywróćToolStripMenuItem";
			this.przywróćToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
			this.przywróćToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.przywróćToolStripMenuItem.Text = "Przywróć";
			this.przywróćToolStripMenuItem.Click += new System.EventHandler(this.PrzywróćToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
			// 
			// kopiujToolStripMenuItem
			// 
			this.kopiujToolStripMenuItem.Name = "kopiujToolStripMenuItem";
			this.kopiujToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.kopiujToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.kopiujToolStripMenuItem.Text = "Kopiuj";
			this.kopiujToolStripMenuItem.Click += new System.EventHandler(this.KopiujToolStripMenuItemClick);
			// 
			// wytnijToolStripMenuItem
			// 
			this.wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
			this.wytnijToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.wytnijToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.wytnijToolStripMenuItem.Text = "Wytnij";
			this.wytnijToolStripMenuItem.Click += new System.EventHandler(this.WytnijToolStripMenuItemClick);
			// 
			// wklejToolStripMenuItem
			// 
			this.wklejToolStripMenuItem.Name = "wklejToolStripMenuItem";
			this.wklejToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.wklejToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.wklejToolStripMenuItem.Text = "Wklej";
			this.wklejToolStripMenuItem.Click += new System.EventHandler(this.WklejToolStripMenuItemClick);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
			// 
			// zaznaczWszystkoToolStripMenuItem
			// 
			this.zaznaczWszystkoToolStripMenuItem.Name = "zaznaczWszystkoToolStripMenuItem";
			this.zaznaczWszystkoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
			this.zaznaczWszystkoToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.zaznaczWszystkoToolStripMenuItem.Text = "Zaznacz wszystko";
			this.zaznaczWszystkoToolStripMenuItem.Click += new System.EventHandler(this.ZaznaczWszystkoToolStripMenuItemClick);
			// 
			// czcionkaToolStripMenuItem
			// 
			this.czcionkaToolStripMenuItem.Name = "czcionkaToolStripMenuItem";
			this.czcionkaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.czcionkaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.czcionkaToolStripMenuItem.Text = "Czcionka";
			this.czcionkaToolStripMenuItem.Click += new System.EventHandler(this.CzcionkaToolStripMenuItemClick);
			// 
			// informacjaToolStripMenuItem
			// 
			this.informacjaToolStripMenuItem.Name = "informacjaToolStripMenuItem";
			this.informacjaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.informacjaToolStripMenuItem.Text = "Informacja";
			this.informacjaToolStripMenuItem.Click += new System.EventHandler(this.InformacjaToolStripMenuItemClick);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "*.rtf";
			this.saveFileDialog1.Filter = "Tekst RTF|*.rtf";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "*.rtf";
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "Tekst RTF|*.rtf";
			// 
			// fontDialog1
			// 
			this.fontDialog1.FontMustExist = true;
			this.fontDialog1.ShowColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(537, 264);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.richTextBox1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "EdytorTekstu";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.contextMenuStrip1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.FontDialog fontDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolStripMenuItem informacjaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zaznaczWszystkoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem przywróćToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cofnijToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem edycjaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem zapiszJakoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zapiszToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem otwórzToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem czcionkaToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem wytnijToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem wklejToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem kopiujToolStripMenuItem1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}
