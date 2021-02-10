
namespace Drzewo
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
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node3");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node2", new System.Windows.Forms.TreeNode[] {
									treeNode1});
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
									treeNode2});
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Node5");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node6");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node4", new System.Windows.Forms.TreeNode[] {
									treeNode4,
									treeNode5});
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node1", new System.Windows.Forms.TreeNode[] {
									treeNode6});
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.label1 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.FullRowSelect = true;
			this.treeView1.HotTracking = true;
			this.treeView1.Location = new System.Drawing.Point(3, 12);
			this.treeView1.Name = "treeView1";
			treeNode1.Name = "Node3";
			treeNode1.Text = "Node3";
			treeNode2.Name = "Node2";
			treeNode2.Text = "Node2";
			treeNode3.Name = "Node0";
			treeNode3.Text = "Node0";
			treeNode4.Name = "Node5";
			treeNode4.Text = "Node5";
			treeNode5.Name = "Node6";
			treeNode5.Text = "Node6";
			treeNode6.Name = "Node4";
			treeNode6.Text = "Node4";
			treeNode7.Name = "Node1";
			treeNode7.Text = "Node1";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
									treeNode3,
									treeNode7});
			this.treeView1.ShowRootLines = false;
			this.treeView1.Size = new System.Drawing.Size(252, 245);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1AfterCollapse);
			this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1AfterExpand);
			this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView1BeforeSelect);
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1AfterSelect);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 260);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(386, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(281, 245);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(261, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Dodaj główny";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(261, 41);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(119, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Dodaj potomny";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(261, 70);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(119, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Usuń wybrany";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(261, 99);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(119, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "Pełna ścieżka";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(679, 301);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.treeView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Drzewo";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView treeView1;
	}
}
