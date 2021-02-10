
namespace Przelicznik
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label10 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(555, 184);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.textBox3);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.comboBox2);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.comboBox1);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(547, 158);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Przelicznik";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.Location = new System.Drawing.Point(8, 116);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Przelicznik";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(8, 43);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Przelicznik";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(328, 19);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(201, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(276, 19);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Kwota:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(276, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(57, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Wynik = ";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(8, 92);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(240, 21);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.ComboBox2SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(8, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Na jaką walutę";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(8, 19);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(240, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(8, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Z jakiej waluty przeliczać";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label10);
			this.tabPage2.Controls.Add(this.textBox4);
			this.tabPage2.Controls.Add(this.label9);
			this.tabPage2.Controls.Add(this.label8);
			this.tabPage2.Controls.Add(this.button3);
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.listBox1);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(547, 158);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Kursy walut";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label10.Location = new System.Drawing.Point(247, 101);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(152, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "Cena jednostkowa w PLN";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(247, 117);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(166, 20);
			this.textBox4.TabIndex = 14;
			this.textBox4.TextChanged += new System.EventHandler(this.TextBox4TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label9.Location = new System.Drawing.Point(247, 62);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(29, 13);
			this.label9.TabIndex = 13;
			this.label9.Text = "Kraj";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label8.Location = new System.Drawing.Point(247, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(87, 13);
			this.label8.TabIndex = 12;
			this.label8.Text = "Symbol waluty";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(451, 80);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 11;
			this.button3.Text = "Aktualizuj";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(451, 51);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Usuń";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(451, 22);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "Dodaj";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label7.Location = new System.Drawing.Point(8, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 13);
			this.label7.TabIndex = 8;
			this.label7.Text = "Kursy walut";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(8, 19);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(213, 134);
			this.listBox1.TabIndex = 2;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.ListBox1SelectedIndexChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(247, 78);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(166, 20);
			this.textBox2.TabIndex = 1;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(247, 39);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(166, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 184);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Przelicznik";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}
