
namespace ListaProsta
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(662, 20);
			this.textBox1.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Items.AddRange(new object[] {
									"Element 0",
									"Element 1",
									"Element 2",
									"Element 3",
									"Element 4",
									"Element 5"});
			this.listBox1.Location = new System.Drawing.Point(12, 38);
			this.listBox1.Name = "listBox1";
			this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBox1.Size = new System.Drawing.Size(283, 147);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
									"Element 0",
									"Element 1",
									"Element 2",
									"Element 3",
									"Element 4",
									"Element 5"});
			this.checkedListBox1.Location = new System.Drawing.Point(401, 38);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(273, 139);
			this.checkedListBox1.TabIndex = 2;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1SelectedIndexChanged);
			this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.CheckedListBox1SelectedIndexChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(310, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Dodaj";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(310, 67);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Usuń";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(310, 96);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Wstaw";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(310, 125);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "Czyść";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(310, 154);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 23);
			this.button5.TabIndex = 7;
			this.button5.Text = "Kolumny";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 201);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(283, 118);
			this.richTextBox1.TabIndex = 8;
			this.richTextBox1.Text = "";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(401, 201);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(273, 118);
			this.richTextBox2.TabIndex = 9;
			this.richTextBox2.Text = "";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 331);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "ListaProsta";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
