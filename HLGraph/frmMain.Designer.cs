﻿namespace HLGraph
{
	partial class frmMain
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
			this.ucGraph1 = new HLGraph.ucGraph();
			this.SuspendLayout();
			// 
			// ucGraph1
			// 
			this.ucGraph1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ucGraph1.Location = new System.Drawing.Point(0, 0);
			this.ucGraph1.Name = "ucGraph1";
			this.ucGraph1.Size = new System.Drawing.Size(841, 715);
			this.ucGraph1.TabIndex = 0;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 715);
			this.Controls.Add(this.ucGraph1);
			this.Name = "frmMain";
			this.Text = "HL Graph";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private ucGraph ucGraph1;
	}
}

