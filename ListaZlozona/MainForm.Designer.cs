
namespace ListaZlozona
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Nagłówek1", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Nagłówek 2", System.Windows.Forms.HorizontalAlignment.Left);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.imageList2 = new System.Windows.Forms.ImageList(this.components);
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1});
			listViewGroup1.Header = "Nagłówek1";
			listViewGroup1.Name = "listViewGroup1";
			listViewGroup2.Header = "Nagłówek 2";
			listViewGroup2.Name = "listViewGroup2";
			this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
									listViewGroup1,
									listViewGroup2});
			this.listView1.LargeImageList = this.imageList2;
			this.listView1.Location = new System.Drawing.Point(1, 1);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(530, 211);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Domyślna";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "Chrobry.JPG");
			this.imageList1.Images.SetKeyName(1, "Droga do groty góralskiej.JPG");
			this.imageList1.Images.SetKeyName(2, "Duży staw - czarna woda - czechy 2.JPG");
			this.imageList1.Images.SetKeyName(3, "Duży staw - czarna woda - czechy 3.JPG");
			this.imageList1.Images.SetKeyName(4, "Duży staw - czarna woda - czechy 4.JPG");
			this.imageList1.Images.SetKeyName(5, "HPIM0069.JPG");
			this.imageList1.Images.SetKeyName(6, "HPIM0511.JPG");
			this.imageList1.Images.SetKeyName(7, "IMG_0016.JPG");
			this.imageList1.Images.SetKeyName(8, "IMG_0020x.JPG");
			this.imageList1.Images.SetKeyName(9, "IMG_0021.JPG");
			this.imageList1.Images.SetKeyName(10, "IMG_0038.JPG");
			this.imageList1.Images.SetKeyName(11, "IMG_0050.JPG");
			this.imageList1.Images.SetKeyName(12, "IMG_0054.JPG");
			this.imageList1.Images.SetKeyName(13, "IMG_0082.JPG");
			this.imageList1.Images.SetKeyName(14, "IMG_0083.JPG");
			this.imageList1.Images.SetKeyName(15, "IMG_0103.JPG");
			this.imageList1.Images.SetKeyName(16, "IMG_0123.JPG");
			this.imageList1.Images.SetKeyName(17, "IMG_0173.JPG");
			this.imageList1.Images.SetKeyName(18, "IMG_0539.JPG");
			this.imageList1.Images.SetKeyName(19, "IMG_1313.JPG");
			this.imageList1.Images.SetKeyName(20, "IMG_1754_1.jpg");
			this.imageList1.Images.SetKeyName(21, "IMG_1761_1.jpg");
			this.imageList1.Images.SetKeyName(22, "IMG_1762_1.jpg");
			this.imageList1.Images.SetKeyName(23, "IMG_1768.JPG");
			this.imageList1.Images.SetKeyName(24, "IMG_1817.JPG");
			this.imageList1.Images.SetKeyName(25, "IMG_1824.JPG");
			this.imageList1.Images.SetKeyName(26, "IMG_1849_1.jpg");
			this.imageList1.Images.SetKeyName(27, "IMG_2062_1.jpg");
			this.imageList1.Images.SetKeyName(28, "IMG_2095.JPG");
			this.imageList1.Images.SetKeyName(29, "IMG_2238_1.jpg");
			this.imageList1.Images.SetKeyName(30, "IMG_2513.JPG");
			this.imageList1.Images.SetKeyName(31, "IMG_2516.JPG");
			this.imageList1.Images.SetKeyName(32, "IMG_2517.JPG");
			this.imageList1.Images.SetKeyName(33, "Jezioro przy granicy.jpg");
			this.imageList1.Images.SetKeyName(34, "Koło 300 schodków - most.JPG");
			this.imageList1.Images.SetKeyName(35, "Koło Chatki.JPG");
			this.imageList1.Images.SetKeyName(36, "Kopa z niebieskiego szlaku zima.JPG");
			this.imageList1.Images.SetKeyName(37, "Kościół Marii Pomocnej - czechy.JPG");
			this.imageList1.Images.SetKeyName(38, "Kościół Marii Pomocnej - czechy 2.JPG");
			this.imageList1.Images.SetKeyName(39, "Kościół Marii Pomocnej - czechy 3.JPG");
			this.imageList1.Images.SetKeyName(40, "Kościół w Piasecznej.JPG");
			this.imageList1.Images.SetKeyName(41, "Kościół w Piasecznej2.JPG");
			this.imageList1.Images.SetKeyName(42, "Kościółek na chrobrym 1.jpg");
			this.imageList1.Images.SetKeyName(43, "Kościółek na chrobrym 2.jpg");
			this.imageList1.Images.SetKeyName(44, "Kościółek na chrobrym 3.jpg");
			this.imageList1.Images.SetKeyName(45, "Kościółek na chrobrym 5.jpg");
			this.imageList1.Images.SetKeyName(46, "Krzyż koło karolinek2_1.jpg");
			// 
			// imageList2
			// 
			this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
			this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList2.Images.SetKeyName(0, "Chrobry.JPG");
			this.imageList2.Images.SetKeyName(1, "Droga do groty góralskiej.JPG");
			this.imageList2.Images.SetKeyName(2, "Duży staw - czarna woda - czechy 2.JPG");
			this.imageList2.Images.SetKeyName(3, "Duży staw - czarna woda - czechy 3.JPG");
			this.imageList2.Images.SetKeyName(4, "Duży staw - czarna woda - czechy 4.JPG");
			this.imageList2.Images.SetKeyName(5, "HPIM0069.JPG");
			this.imageList2.Images.SetKeyName(6, "HPIM0511.JPG");
			this.imageList2.Images.SetKeyName(7, "IMG_0016.JPG");
			this.imageList2.Images.SetKeyName(8, "IMG_0020x.JPG");
			this.imageList2.Images.SetKeyName(9, "IMG_0021.JPG");
			this.imageList2.Images.SetKeyName(10, "IMG_0038.JPG");
			this.imageList2.Images.SetKeyName(11, "IMG_0050.JPG");
			this.imageList2.Images.SetKeyName(12, "IMG_0054.JPG");
			this.imageList2.Images.SetKeyName(13, "IMG_0082.JPG");
			this.imageList2.Images.SetKeyName(14, "IMG_0083.JPG");
			this.imageList2.Images.SetKeyName(15, "IMG_0103.JPG");
			this.imageList2.Images.SetKeyName(16, "IMG_0123.JPG");
			this.imageList2.Images.SetKeyName(17, "IMG_0173.JPG");
			this.imageList2.Images.SetKeyName(18, "IMG_0539.JPG");
			this.imageList2.Images.SetKeyName(19, "IMG_1313.JPG");
			this.imageList2.Images.SetKeyName(20, "IMG_1754_1.jpg");
			this.imageList2.Images.SetKeyName(21, "IMG_1761_1.jpg");
			this.imageList2.Images.SetKeyName(22, "IMG_1762_1.jpg");
			this.imageList2.Images.SetKeyName(23, "IMG_1768.JPG");
			this.imageList2.Images.SetKeyName(24, "IMG_1817.JPG");
			this.imageList2.Images.SetKeyName(25, "IMG_1824.JPG");
			this.imageList2.Images.SetKeyName(26, "IMG_1849_1.jpg");
			this.imageList2.Images.SetKeyName(27, "IMG_2062_1.jpg");
			this.imageList2.Images.SetKeyName(28, "IMG_2095.JPG");
			this.imageList2.Images.SetKeyName(29, "IMG_2238_1.jpg");
			this.imageList2.Images.SetKeyName(30, "IMG_2513.JPG");
			this.imageList2.Images.SetKeyName(31, "IMG_2516.JPG");
			this.imageList2.Images.SetKeyName(32, "IMG_2517.JPG");
			this.imageList2.Images.SetKeyName(33, "Jezioro przy granicy.jpg");
			this.imageList2.Images.SetKeyName(34, "Koło 300 schodków - most.JPG");
			this.imageList2.Images.SetKeyName(35, "Koło Chatki.JPG");
			this.imageList2.Images.SetKeyName(36, "Kopa z niebieskiego szlaku zima.JPG");
			this.imageList2.Images.SetKeyName(37, "Kościół Marii Pomocnej - czechy.JPG");
			this.imageList2.Images.SetKeyName(38, "Kościół Marii Pomocnej - czechy 2.JPG");
			this.imageList2.Images.SetKeyName(39, "Kościół Marii Pomocnej - czechy 3.JPG");
			this.imageList2.Images.SetKeyName(40, "Kościół w Piasecznej.JPG");
			this.imageList2.Images.SetKeyName(41, "Kościół w Piasecznej2.JPG");
			this.imageList2.Images.SetKeyName(42, "Kościółek na chrobrym 1.jpg");
			this.imageList2.Images.SetKeyName(43, "Kościółek na chrobrym 2.jpg");
			this.imageList2.Images.SetKeyName(44, "Kościółek na chrobrym 3.jpg");
			this.imageList2.Images.SetKeyName(45, "Kościółek na chrobrym 5.jpg");
			this.imageList2.Images.SetKeyName(46, "Krzyż koło karolinek2_1.jpg");
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(537, 1);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(149, 211);
			this.richTextBox1.TabIndex = 1;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(537, 215);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Grupy";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(537, 236);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(149, 95);
			this.listBox1.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1, 218);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(109, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Dodaj kolumnę";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(1, 247);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(109, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "Usuń kolumnę";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(1, 276);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(109, 23);
			this.button3.TabIndex = 6;
			this.button3.Text = "Dodaj element";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(1, 304);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(109, 23);
			this.button4.TabIndex = 7;
			this.button4.Text = "Usuń element";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(148, 218);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 8;
			this.button5.Text = "Duże ikony";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(229, 218);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(75, 23);
			this.button6.TabIndex = 9;
			this.button6.Text = "Małe ikony";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.Button6Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(148, 247);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(75, 23);
			this.button7.TabIndex = 10;
			this.button7.Text = "Detale";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.Button7Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(229, 247);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(75, 23);
			this.button8.TabIndex = 11;
			this.button8.Text = "Lista";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.Button8Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(148, 276);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(156, 23);
			this.button9.TabIndex = 12;
			this.button9.Text = "Kafelki";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.Button9Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(396, 236);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(135, 23);
			this.button10.TabIndex = 13;
			this.button10.Text = "Dodaj grupę";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.Button10Click);
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(396, 265);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(135, 23);
			this.button11.TabIndex = 14;
			this.button11.Text = "Usuń wybraną grupę";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.Button11Click);
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(396, 294);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(135, 23);
			this.button12.TabIndex = 15;
			this.button12.Text = "Przypisz grupę";
			this.button12.UseVisualStyleBackColor = true;
			this.button12.Click += new System.EventHandler(this.Button12Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 339);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Lista złożona - ListView";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ImageList imageList2;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.ListView listView1;
	}
}
