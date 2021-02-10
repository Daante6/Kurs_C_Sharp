
namespace Kalendarz
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
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy/MMMM/dd (dddd) \'godzina\' HH:mm:ss";
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(90, 12);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(328, 20);
			this.dateTimePicker1.TabIndex = 0;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1ValueChanged);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "yyyy/MMMM/dd (dddd) \'godzina\' HH:mm:ss";
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker2.Location = new System.Drawing.Point(90, 45);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(327, 20);
			this.dateTimePicker2.TabIndex = 1;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker1ValueChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(7, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Start";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Koniec";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "label3";
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.AnnuallyBoldedDates = new System.DateTime[] {
						new System.DateTime(2012, 2, 1, 0, 0, 0, 0)};
			this.monthCalendar1.BoldedDates = new System.DateTime[] {
						new System.DateTime(2011, 6, 10, 0, 0, 0, 0)};
			this.monthCalendar1.Location = new System.Drawing.Point(18, 103);
			this.monthCalendar1.MaxSelectionCount = 4096;
			this.monthCalendar1.MonthlyBoldedDates = new System.DateTime[] {
						new System.DateTime(2011, 7, 9, 0, 0, 0, 0),
						new System.DateTime(2011, 5, 4, 0, 0, 0, 0)};
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.ShowWeekNumbers = true;
			this.monthCalendar1.TabIndex = 5;
			this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar1DateSelected);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(223, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(194, 162);
			this.label4.TabIndex = 6;
			this.label4.Text = "label4";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(430, 283);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Kalendarz";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}
