
namespace SprawdzanieNumerow
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.KomunikatNIP = new System.Windows.Forms.Label();
			this.KomunikatREGON = new System.Windows.Forms.Label();
			this.KomunikatPESEL = new System.Windows.Forms.Label();
			this.KomunikatEAN = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "NIP";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "REGON";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "PESEL";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(49, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "EAN";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(67, 9);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(221, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(67, 32);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(221, 20);
			this.textBox2.TabIndex = 5;
			this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(67, 55);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(221, 20);
			this.textBox3.TabIndex = 6;
			this.textBox3.TextChanged += new System.EventHandler(this.TextBox3TextChanged);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(67, 78);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(221, 20);
			this.textBox4.TabIndex = 7;
			this.textBox4.TextChanged += new System.EventHandler(this.TextBox4TextChanged);
			// 
			// KomunikatNIP
			// 
			this.KomunikatNIP.AutoSize = true;
			this.KomunikatNIP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.KomunikatNIP.Location = new System.Drawing.Point(294, 9);
			this.KomunikatNIP.Name = "KomunikatNIP";
			this.KomunikatNIP.Size = new System.Drawing.Size(109, 19);
			this.KomunikatNIP.TabIndex = 8;
			this.KomunikatNIP.Text = "Wpisz numer";
			this.KomunikatNIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// KomunikatREGON
			// 
			this.KomunikatREGON.AutoSize = true;
			this.KomunikatREGON.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.KomunikatREGON.Location = new System.Drawing.Point(294, 32);
			this.KomunikatREGON.Name = "KomunikatREGON";
			this.KomunikatREGON.Size = new System.Drawing.Size(109, 19);
			this.KomunikatREGON.TabIndex = 9;
			this.KomunikatREGON.Text = "Wpisz numer";
			this.KomunikatREGON.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// KomunikatPESEL
			// 
			this.KomunikatPESEL.AutoSize = true;
			this.KomunikatPESEL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.KomunikatPESEL.Location = new System.Drawing.Point(294, 55);
			this.KomunikatPESEL.Name = "KomunikatPESEL";
			this.KomunikatPESEL.Size = new System.Drawing.Size(109, 19);
			this.KomunikatPESEL.TabIndex = 10;
			this.KomunikatPESEL.Text = "Wpisz numer";
			this.KomunikatPESEL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// KomunikatEAN
			// 
			this.KomunikatEAN.AutoSize = true;
			this.KomunikatEAN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.KomunikatEAN.Location = new System.Drawing.Point(294, 78);
			this.KomunikatEAN.Name = "KomunikatEAN";
			this.KomunikatEAN.Size = new System.Drawing.Size(109, 19);
			this.KomunikatEAN.TabIndex = 11;
			this.KomunikatEAN.Text = "Wpisz numer";
			this.KomunikatEAN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 113);
			this.Controls.Add(this.KomunikatEAN);
			this.Controls.Add(this.KomunikatPESEL);
			this.Controls.Add(this.KomunikatREGON);
			this.Controls.Add(this.KomunikatNIP);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Sprawdzanie numerów";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label KomunikatEAN;
		private System.Windows.Forms.Label KomunikatPESEL;
		private System.Windows.Forms.Label KomunikatREGON;
		private System.Windows.Forms.Label KomunikatNIP;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
