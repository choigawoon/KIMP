﻿namespace ProfilerClient
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox2;
            Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox3;
            Aga.Controls.Tree.NodeControls.NodeTextBox nodeTextBox1;
            Aga.Controls.Tree.NodeControls.NodeDecimalTextBox nodeDecimalTextBox1;
            Aga.Controls.Tree.NodeControls.NodeDecimalTextBox nodeDecimalTextBox2;
            Aga.Controls.Tree.NodeControls.NodeDecimalTextBox nodeDecimalTextBox5;
            Aga.Controls.Tree.NodeControls.NodeDecimalTextBox nodeDecimalTextBox6;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.treeColumn4 = new Aga.Controls.Tree.TreeColumn();
            this.treeColumn5 = new Aga.Controls.Tree.TreeColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.treeViewAdv1 = new Aga.Controls.Tree.TreeViewAdv();
            this.treeColumn1 = new Aga.Controls.Tree.TreeColumn();
            this.treeColumn2 = new Aga.Controls.Tree.TreeColumn();
            this.treeColumn3 = new Aga.Controls.Tree.TreeColumn();
            this.treeColumn6 = new Aga.Controls.Tree.TreeColumn();
            this.treeColumn7 = new Aga.Controls.Tree.TreeColumn();
            panel1 = new System.Windows.Forms.Panel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            nodeTextBox2 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            nodeTextBox3 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            nodeTextBox1 = new Aga.Controls.Tree.NodeControls.NodeTextBox();
            nodeDecimalTextBox1 = new Aga.Controls.Tree.NodeControls.NodeDecimalTextBox();
            nodeDecimalTextBox2 = new Aga.Controls.Tree.NodeControls.NodeDecimalTextBox();
            nodeDecimalTextBox5 = new Aga.Controls.Tree.NodeControls.NodeDecimalTextBox();
            nodeDecimalTextBox6 = new Aga.Controls.Tree.NodeControls.NodeDecimalTextBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(this.textBox1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(669, 23);
            panel1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(519, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "localhost:5000";
            this.textBox1.WordWrap = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(this.findButton);
            flowLayoutPanel1.Controls.Add(this.button1);
            flowLayoutPanel1.Controls.Add(this.button2);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            flowLayoutPanel1.Location = new System.Drawing.Point(519, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(150, 23);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // findButton
            // 
            this.findButton.AutoSize = true;
            this.findButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.findButton.Location = new System.Drawing.Point(3, 0);
            this.findButton.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(39, 22);
            this.findButton.TabIndex = 4;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(45, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 22);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(105, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pause";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nodeTextBox2
            // 
            nodeTextBox2.DataPropertyName = "TkBytesAsString";
            nodeTextBox2.IncrementalSearchEnabled = true;
            nodeTextBox2.LeftMargin = 3;
            nodeTextBox2.ParentColumn = this.treeColumn4;
            nodeTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // treeColumn4
            // 
            this.treeColumn4.Header = "TkBytes";
            this.treeColumn4.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.treeColumn4.TooltipText = "Total allocated memory rounded to nearest kilo bytes (including child call)";
            this.treeColumn4.Width = 60;
            // 
            // nodeTextBox3
            // 
            nodeTextBox3.DataPropertyName = "SkBytesAsString";
            nodeTextBox3.IncrementalSearchEnabled = true;
            nodeTextBox3.LeftMargin = 3;
            nodeTextBox3.ParentColumn = this.treeColumn5;
            nodeTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // treeColumn5
            // 
            this.treeColumn5.Header = "SkBytes";
            this.treeColumn5.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.treeColumn5.TooltipText = "Self allocated memory rounded to nearest kilo bytes (child call not included)";
            this.treeColumn5.Width = 60;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AllowColumnReorder = true;
            this.treeViewAdv1.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewAdv1.Columns.Add(this.treeColumn1);
            this.treeViewAdv1.Columns.Add(this.treeColumn2);
            this.treeViewAdv1.Columns.Add(this.treeColumn3);
            this.treeViewAdv1.Columns.Add(this.treeColumn4);
            this.treeViewAdv1.Columns.Add(this.treeColumn5);
            this.treeViewAdv1.Columns.Add(this.treeColumn6);
            this.treeViewAdv1.Columns.Add(this.treeColumn7);
            this.treeViewAdv1.DefaultToolTipProvider = null;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAdv1.DragDropMarkColor = System.Drawing.Color.Black;
            this.treeViewAdv1.FullRowSelect = true;
            this.treeViewAdv1.GridLineStyle = ((Aga.Controls.Tree.GridLineStyle)((Aga.Controls.Tree.GridLineStyle.Horizontal | Aga.Controls.Tree.GridLineStyle.Vertical)));
            this.treeViewAdv1.Indent = 12;
            this.treeViewAdv1.LineColor = System.Drawing.SystemColors.ControlDark;
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 23);
            this.treeViewAdv1.Model = null;
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.NodeControls.Add(nodeTextBox1);
            this.treeViewAdv1.NodeControls.Add(nodeDecimalTextBox1);
            this.treeViewAdv1.NodeControls.Add(nodeDecimalTextBox2);
            this.treeViewAdv1.NodeControls.Add(nodeTextBox2);
            this.treeViewAdv1.NodeControls.Add(nodeTextBox3);
            this.treeViewAdv1.NodeControls.Add(nodeDecimalTextBox5);
            this.treeViewAdv1.NodeControls.Add(nodeDecimalTextBox6);
            this.treeViewAdv1.SelectedNode = null;
            this.treeViewAdv1.Size = new System.Drawing.Size(669, 318);
            this.treeViewAdv1.TabIndex = 2;
            this.treeViewAdv1.Text = "treeViewAdv1";
            this.treeViewAdv1.UseColumns = true;
            this.treeViewAdv1.ColumnClicked += new System.EventHandler<Aga.Controls.Tree.TreeColumnEventArgs>(this.treeViewAdv1_ColumnClicked);
            // 
            // treeColumn1
            // 
            this.treeColumn1.Header = "Callstack";
            this.treeColumn1.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn1.TooltipText = "Function name";
            this.treeColumn1.Width = 300;
            // 
            // treeColumn2
            // 
            this.treeColumn2.Header = "TCount";
            this.treeColumn2.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.treeColumn2.TooltipText = "Total no. of allocation count (including child call)";
            this.treeColumn2.Width = 60;
            // 
            // treeColumn3
            // 
            this.treeColumn3.Header = "SCount";
            this.treeColumn3.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.treeColumn3.TooltipText = "Self no. of allocation count (child call not included)";
            this.treeColumn3.Width = 60;
            // 
            // treeColumn6
            // 
            this.treeColumn6.Header = "SCount/F";
            this.treeColumn6.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.treeColumn6.TooltipText = "Self no. of allocation count per frame";
            this.treeColumn6.Width = 60;
            // 
            // treeColumn7
            // 
            this.treeColumn7.Header = "Call/F";
            this.treeColumn7.SortOrder = System.Windows.Forms.SortOrder.None;
            this.treeColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.treeColumn7.TooltipText = "No. of call per frame";
            this.treeColumn7.Width = 60;
            // 
            // nodeTextBox1
            // 
            nodeTextBox1.DataPropertyName = "Name";
            nodeTextBox1.EditEnabled = false;
            nodeTextBox1.IncrementalSearchEnabled = true;
            nodeTextBox1.LeftMargin = 3;
            nodeTextBox1.ParentColumn = this.treeColumn1;
            // 
            // nodeDecimalTextBox1
            // 
            nodeDecimalTextBox1.DataPropertyName = "TCount";
            nodeDecimalTextBox1.EditEnabled = false;
            nodeDecimalTextBox1.IncrementalSearchEnabled = true;
            nodeDecimalTextBox1.LeftMargin = 3;
            nodeDecimalTextBox1.ParentColumn = this.treeColumn2;
            nodeDecimalTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nodeDecimalTextBox2
            // 
            nodeDecimalTextBox2.DataPropertyName = "SCount";
            nodeDecimalTextBox2.EditEnabled = false;
            nodeDecimalTextBox2.IncrementalSearchEnabled = true;
            nodeDecimalTextBox2.LeftMargin = 3;
            nodeDecimalTextBox2.ParentColumn = this.treeColumn3;
            nodeDecimalTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nodeDecimalTextBox5
            // 
            nodeDecimalTextBox5.DataPropertyName = "SCountPerFrame";
            nodeDecimalTextBox5.IncrementalSearchEnabled = true;
            nodeDecimalTextBox5.LeftMargin = 3;
            nodeDecimalTextBox5.ParentColumn = this.treeColumn6;
            nodeDecimalTextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nodeDecimalTextBox6
            // 
            nodeDecimalTextBox6.DataPropertyName = "CallPerFrame";
            nodeDecimalTextBox6.IncrementalSearchEnabled = true;
            nodeDecimalTextBox6.LeftMargin = 3;
            nodeDecimalTextBox6.ParentColumn = this.treeColumn7;
            nodeDecimalTextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 341);
            this.Controls.Add(this.treeViewAdv1);
            this.Controls.Add(panel1);
            this.Name = "Form1";
            this.Text = "Memory profiler client";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox textBox1;
		private Aga.Controls.Tree.TreeViewAdv treeViewAdv1;
		private Aga.Controls.Tree.TreeColumn treeColumn1;
        private Aga.Controls.Tree.TreeColumn treeColumn2;
        private Aga.Controls.Tree.TreeColumn treeColumn3;
		private Aga.Controls.Tree.TreeColumn treeColumn4;
		private Aga.Controls.Tree.TreeColumn treeColumn5;
		private Aga.Controls.Tree.TreeColumn treeColumn6;
        private Aga.Controls.Tree.TreeColumn treeColumn7;
		private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button findButton;
	}
}

