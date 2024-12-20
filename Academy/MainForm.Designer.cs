﻿namespace Academy
{
	partial class MainForm
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.statusStripStudents = new System.Windows.Forms.StatusStrip();
			this.tslStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.tslGroupCount = new System.Windows.Forms.StatusStrip();
			this.tslGroupsCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.statusStripStudents.SuspendLayout();
			this.tabPageGroups.SuspendLayout();
			this.tslGroupCount.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 450);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
			this.tabPageStudents.Controls.Add(this.statusStripStudents);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(792, 424);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Location = new System.Drawing.Point(0, 27);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(792, 369);
			this.dataGridViewStudents.TabIndex = 1;
			// 
			// statusStripStudents
			// 
			this.statusStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStudentsCount});
			this.statusStripStudents.Location = new System.Drawing.Point(3, 399);
			this.statusStripStudents.Name = "statusStripStudents";
			this.statusStripStudents.Size = new System.Drawing.Size(786, 22);
			this.statusStripStudents.TabIndex = 0;
			this.statusStripStudents.Text = "statusStripStudents";
			// 
			// tslStudentsCount
			// 
			this.tslStudentsCount.Name = "tslStudentsCount";
			this.tslStudentsCount.Size = new System.Drawing.Size(129, 17);
			this.tslStudentsCount.Text = "Количество студентов";
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.dataGridViewGroups);
			this.tabPageGroups.Controls.Add(this.tslGroupCount);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(792, 424);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// tslGroupCount
			// 
			this.tslGroupCount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslGroupsCount});
			this.tslGroupCount.Location = new System.Drawing.Point(3, 399);
			this.tslGroupCount.Name = "tslGroupCount";
			this.tslGroupCount.Size = new System.Drawing.Size(786, 22);
			this.tslGroupCount.TabIndex = 0;
			this.tslGroupCount.Text = "Количество групп";
			// 
			// tslGroupsCount
			// 
			this.tslGroupsCount.Name = "tslGroupsCount";
			this.tslGroupsCount.Size = new System.Drawing.Size(107, 17);
			this.tslGroupsCount.Text = "Количество групп";
			// 
			// dataGridViewGroups
			// 
			this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewGroups.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewGroups.Name = "dataGridViewGroups";
			this.dataGridViewGroups.Size = new System.Drawing.Size(786, 396);
			this.dataGridViewGroups.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.Text = "Academy";
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.statusStripStudents.ResumeLayout(false);
			this.statusStripStudents.PerformLayout();
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageGroups.PerformLayout();
			this.tslGroupCount.ResumeLayout(false);
			this.tslGroupCount.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.StatusStrip statusStripStudents;
		private System.Windows.Forms.StatusStrip tslGroupCount;
		private System.Windows.Forms.ToolStripStatusLabel tslStudentsCount;
		private System.Windows.Forms.ToolStripStatusLabel tslGroupsCount;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.DataGridView dataGridViewGroups;
	}
}

