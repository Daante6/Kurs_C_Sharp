
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Drzewo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int Numer = 1;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
		{
			richTextBox1.AppendText ("Zdarzenie AfterSelect\n");
			TreeNode Folder = treeView1.SelectedNode;
			
			if (Folder != null)
			{
				label1.Text = "Wybrano indeks " + Folder.Index + " na poziomie " + Folder.Level +"\n";
				richTextBox1.AppendText ("Indeks " + Folder.Index + " poziom " + Folder.Level +"\n");
			}
		}
		
		void TreeView1BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			richTextBox1.AppendText ("Zdarzenie BeforeSelect\n");
			TreeNode Folder = treeView1.SelectedNode;
			
			if (Folder != null)
			{				
				richTextBox1.AppendText ("Indeks " + Folder.Index + " poziom " + Folder.Level +"\n");
			}
		}
		
		void TreeView1AfterCollapse(object sender, TreeViewEventArgs e)
		{
			richTextBox1.AppendText ("Zdarzenie AfterCollapse dla gałęzi " + e.Node.Text +" \n");
		}
		
		void TreeView1AfterExpand(object sender, TreeViewEventArgs e)
		{
		 richTextBox1.AppendText ("Zdarzenie AfterExpand dla gałęzi " + e.Node.Text +" \n");			 
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			TreeNode Element = new TreeNode();
			
			Element.Text = "Element nr" + Numer;
			Numer++;
			treeView1.Nodes.Add (Element);			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			TreeNode Folder = treeView1.SelectedNode;
			if (Folder != null)
			{
			 TreeNode Element = new TreeNode();
			 Element.Text = "Element nr" + Numer;
			 Numer++;
			 Folder.Nodes.Add (Element);
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			TreeNode Folder = treeView1.SelectedNode;
			if (Folder != null)
			{
				Folder.Remove();
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string Tekst = "Nie wybrano";
			TreeNode Folder = treeView1.SelectedNode;
			if (Folder != null)
			{
				Tekst = Folder.FullPath;
			}
			MessageBox.Show (Tekst, "Pełna ścieżka do wybranej gałęzi");
		}
	}
}
