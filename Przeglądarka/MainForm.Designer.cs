
namespace Przeglądarka
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
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.właściwościStronyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zapiszStronęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.czyśćHistorięToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.podglądWydrukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ustawieniaDrukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.zatrzymajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.odświeżToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dalejToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.wsteczToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
			this.przejdźDoStronyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// webBrowser1
			// 
			this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.webBrowser1.Location = new System.Drawing.Point(0, 2);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(666, 234);
			this.webBrowser1.TabIndex = 0;
			this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.WebBrowser1DocumentCompleted);
			this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.WebBrowser1Navigated);
			this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.WebBrowser1Navigating);
			this.webBrowser1.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.WebBrowser1ProgressChanged);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripDropDownButton1,
									this.toolStripDropDownButton2,
									this.toolStripDropDownButton3,
									this.toolStripProgressBar1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 239);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(666, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.właściwościStronyToolStripMenuItem,
									this.zapiszStronęToolStripMenuItem,
									this.czyśćHistorięToolStripMenuItem,
									this.podglądWydrukuToolStripMenuItem,
									this.ustawieniaDrukuToolStripMenuItem,
									this.toolStripMenuItem1});
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
			this.toolStripDropDownButton1.Text = "Opcje";
			// 
			// właściwościStronyToolStripMenuItem
			// 
			this.właściwościStronyToolStripMenuItem.Name = "właściwościStronyToolStripMenuItem";
			this.właściwościStronyToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.właściwościStronyToolStripMenuItem.Text = "Właściwości strony";
			this.właściwościStronyToolStripMenuItem.Click += new System.EventHandler(this.WłaściwościStronyToolStripMenuItemClick);
			// 
			// zapiszStronęToolStripMenuItem
			// 
			this.zapiszStronęToolStripMenuItem.Name = "zapiszStronęToolStripMenuItem";
			this.zapiszStronęToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.zapiszStronęToolStripMenuItem.Text = "Zapisz stronę";
			this.zapiszStronęToolStripMenuItem.Click += new System.EventHandler(this.ZapiszStronęToolStripMenuItemClick);
			// 
			// czyśćHistorięToolStripMenuItem
			// 
			this.czyśćHistorięToolStripMenuItem.Name = "czyśćHistorięToolStripMenuItem";
			this.czyśćHistorięToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.czyśćHistorięToolStripMenuItem.Text = "Czyść historię";
			this.czyśćHistorięToolStripMenuItem.Click += new System.EventHandler(this.CzyśćHistorięToolStripMenuItemClick);
			// 
			// podglądWydrukuToolStripMenuItem
			// 
			this.podglądWydrukuToolStripMenuItem.Name = "podglądWydrukuToolStripMenuItem";
			this.podglądWydrukuToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.podglądWydrukuToolStripMenuItem.Text = "Podgląd wydruku";
			this.podglądWydrukuToolStripMenuItem.Click += new System.EventHandler(this.PodglądWydrukuToolStripMenuItemClick);
			// 
			// ustawieniaDrukuToolStripMenuItem
			// 
			this.ustawieniaDrukuToolStripMenuItem.Name = "ustawieniaDrukuToolStripMenuItem";
			this.ustawieniaDrukuToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.ustawieniaDrukuToolStripMenuItem.Text = "Ustawienia druku";
			this.ustawieniaDrukuToolStripMenuItem.Click += new System.EventHandler(this.UstawieniaDrukuToolStripMenuItemClick);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
			this.toolStripMenuItem1.Text = "Drukuj";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1Click);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.zatrzymajToolStripMenuItem,
									this.odświeżToolStripMenuItem,
									this.dalejToolStripMenuItem,
									this.wsteczToolStripMenuItem});
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(75, 22);
			this.toolStripDropDownButton2.Text = "Nawigacja";
			// 
			// zatrzymajToolStripMenuItem
			// 
			this.zatrzymajToolStripMenuItem.Name = "zatrzymajToolStripMenuItem";
			this.zatrzymajToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.zatrzymajToolStripMenuItem.Text = "Zatrzymaj";
			this.zatrzymajToolStripMenuItem.Click += new System.EventHandler(this.ZatrzymajToolStripMenuItemClick);
			// 
			// odświeżToolStripMenuItem
			// 
			this.odświeżToolStripMenuItem.Name = "odświeżToolStripMenuItem";
			this.odświeżToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.odświeżToolStripMenuItem.Text = "Odśwież";
			this.odświeżToolStripMenuItem.Click += new System.EventHandler(this.OdświeżToolStripMenuItemClick);
			// 
			// dalejToolStripMenuItem
			// 
			this.dalejToolStripMenuItem.Name = "dalejToolStripMenuItem";
			this.dalejToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.dalejToolStripMenuItem.Text = "Dalej";
			this.dalejToolStripMenuItem.Click += new System.EventHandler(this.DalejToolStripMenuItemClick);
			// 
			// wsteczToolStripMenuItem
			// 
			this.wsteczToolStripMenuItem.Name = "wsteczToolStripMenuItem";
			this.wsteczToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.wsteczToolStripMenuItem.Text = "Wstecz";
			this.wsteczToolStripMenuItem.Click += new System.EventHandler(this.WsteczToolStripMenuItemClick);
			// 
			// toolStripDropDownButton3
			// 
			this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripComboBox1,
									this.przejdźDoStronyToolStripMenuItem});
			this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
			this.toolStripDropDownButton3.Size = new System.Drawing.Size(52, 22);
			this.toolStripDropDownButton3.Text = "Idź do";
			// 
			// toolStripComboBox1
			// 
			this.toolStripComboBox1.AutoSize = false;
			this.toolStripComboBox1.DropDownWidth = 300;
			this.toolStripComboBox1.Name = "toolStripComboBox1";
			this.toolStripComboBox1.Size = new System.Drawing.Size(300, 23);
			this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.ToolStripComboBox1SelectedIndexChanged);
			this.toolStripComboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ToolStripComboBox1KeyPress);
			// 
			// przejdźDoStronyToolStripMenuItem
			// 
			this.przejdźDoStronyToolStripMenuItem.Name = "przejdźDoStronyToolStripMenuItem";
			this.przejdźDoStronyToolStripMenuItem.Size = new System.Drawing.Size(360, 22);
			this.przejdźDoStronyToolStripMenuItem.Text = "Przejdź do strony";
			this.przejdźDoStronyToolStripMenuItem.Click += new System.EventHandler(this.PrzejdźDoStronyToolStripMenuItemClick);
			// 
			// toolStripProgressBar1
			// 
			this.toolStripProgressBar1.Name = "toolStripProgressBar1";
			this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 264);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.webBrowser1);
			this.MinimumSize = new System.Drawing.Size(400, 300);
			this.Name = "MainForm";
			this.Text = "Przeglądarka";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
		private System.Windows.Forms.ToolStripMenuItem przejdźDoStronyToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
		private System.Windows.Forms.ToolStripMenuItem wsteczToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dalejToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem odświeżToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zatrzymajToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem ustawieniaDrukuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem podglądWydrukuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem czyśćHistorięToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zapiszStronęToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem właściwościStronyToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.WebBrowser webBrowser1;
	}
}
