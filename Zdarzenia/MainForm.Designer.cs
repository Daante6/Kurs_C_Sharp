
namespace Zdarzenia
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(224, 293);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(242, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(439, 282);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Przycisk";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			this.button1.Enter += new System.EventHandler(this.Button1Enter);
			this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Button1KeyPress);
			this.button1.Leave += new System.EventHandler(this.Button1Leave);
			this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1MouseClick);
			this.button1.MouseEnter += new System.EventHandler(this.Button1MouseEnter);
			this.button1.MouseLeave += new System.EventHandler(this.Button1MouseLeave);
			this.button1.MouseHover += new System.EventHandler(this.Button1MouseHover);
			this.button1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Button1PreviewKeyDown);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(349, 282);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Czyść";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(349, 241);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Zamknij 1";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(439, 241);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Zamknij 2";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(526, 317);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.richTextBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "Zdarzenia";
			this.Activated += new System.EventHandler(this.MainFormActivated);
			this.Deactivate += new System.EventHandler(this.MainFormDeactivate);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFormFormClosed);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResizeBegin += new System.EventHandler(this.MainFormResizeBegin);
			this.ResizeEnd += new System.EventHandler(this.MainFormResizeEnd);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainFormKeyPress);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainFormMouseUp);
			this.Move += new System.EventHandler(this.MainFormMove);
			this.Resize += new System.EventHandler(this.MainFormResize);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}
