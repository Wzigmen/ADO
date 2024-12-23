namespace Academy
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
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.statusStripStudents = new System.Windows.Forms.StatusStrip();
			this.tslStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.lblGroupsDirection = new System.Windows.Forms.Label();
			this.cbGroupsDirection = new System.Windows.Forms.ComboBox();
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			this.tslGroupCount = new System.Windows.Forms.StatusStrip();
			this.tslGroupsCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.tslTeachersCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.cbStudentsGroups = new System.Windows.Forms.ComboBox();
			this.cbStudentsDirections = new System.Windows.Forms.ComboBox();
			this.labelGroups = new System.Windows.Forms.Label();
			this.labelDirections = new System.Windows.Forms.Label();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.statusStripStudents.SuspendLayout();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
			this.tslGroupCount.SuspendLayout();
			this.tabPageTeachers.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Controls.Add(this.tabPageTeachers);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1002, 775);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.labelDirections);
			this.tabPageStudents.Controls.Add(this.labelGroups);
			this.tabPageStudents.Controls.Add(this.cbStudentsDirections);
			this.tabPageStudents.Controls.Add(this.cbStudentsGroups);
			this.tabPageStudents.Controls.Add(this.dgvStudents);
			this.tabPageStudents.Controls.Add(this.statusStripStudents);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(994, 749);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// dgvStudents
			// 
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudents.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(3, 57);
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.Size = new System.Drawing.Size(988, 664);
			this.dgvStudents.TabIndex = 1;
			// 
			// statusStripStudents
			// 
			this.statusStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStudentsCount});
			this.statusStripStudents.Location = new System.Drawing.Point(3, 724);
			this.statusStripStudents.Name = "statusStripStudents";
			this.statusStripStudents.Size = new System.Drawing.Size(988, 22);
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
			this.tabPageGroups.Controls.Add(this.lblGroupsDirection);
			this.tabPageGroups.Controls.Add(this.cbGroupsDirection);
			this.tabPageGroups.Controls.Add(this.dgvGroups);
			this.tabPageGroups.Controls.Add(this.tslGroupCount);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(994, 749);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// lblGroupsDirection
			// 
			this.lblGroupsDirection.AutoSize = true;
			this.lblGroupsDirection.Location = new System.Drawing.Point(229, 32);
			this.lblGroupsDirection.Name = "lblGroupsDirection";
			this.lblGroupsDirection.Size = new System.Drawing.Size(127, 13);
			this.lblGroupsDirection.TabIndex = 3;
			this.lblGroupsDirection.Text = "Направление обучения:";
			this.lblGroupsDirection.Click += new System.EventHandler(this.labelGroupsDirection_Click);
			// 
			// cbGroupsDirection
			// 
			this.cbGroupsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGroupsDirection.FormattingEnabled = true;
			this.cbGroupsDirection.Location = new System.Drawing.Point(362, 29);
			this.cbGroupsDirection.Name = "cbGroupsDirection";
			this.cbGroupsDirection.Size = new System.Drawing.Size(279, 21);
			this.cbGroupsDirection.TabIndex = 2;
			this.cbGroupsDirection.SelectedIndexChanged += new System.EventHandler(this.cbGroupsDirection_SelectedIndexChanged);
			// 
			// dgvGroups
			// 
			this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvGroups.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dgvGroups.Location = new System.Drawing.Point(3, 56);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.Size = new System.Drawing.Size(988, 668);
			this.dgvGroups.TabIndex = 1;
			// 
			// tslGroupCount
			// 
			this.tslGroupCount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslGroupsCount});
			this.tslGroupCount.Location = new System.Drawing.Point(3, 724);
			this.tslGroupCount.Name = "tslGroupCount";
			this.tslGroupCount.Size = new System.Drawing.Size(988, 22);
			this.tslGroupCount.TabIndex = 0;
			this.tslGroupCount.Text = "Количество групп";
			// 
			// tslGroupsCount
			// 
			this.tslGroupsCount.Name = "tslGroupsCount";
			this.tslGroupsCount.Size = new System.Drawing.Size(107, 17);
			this.tslGroupsCount.Text = "Количество групп";
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Controls.Add(this.statusStrip1);
			this.tabPageTeachers.Controls.Add(this.dgvTeachers);
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(994, 749);
			this.tabPageTeachers.TabIndex = 2;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTeachersCount});
			this.statusStrip1.Location = new System.Drawing.Point(3, 724);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(988, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// tslTeachersCount
			// 
			this.tslTeachersCount.Name = "tslTeachersCount";
			this.tslTeachersCount.Size = new System.Drawing.Size(171, 17);
			this.tslTeachersCount.Text = "Колличество преподавателей";
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvTeachers.BackgroundColor = System.Drawing.Color.LemonChiffon;
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(3, 55);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.Size = new System.Drawing.Size(988, 691);
			this.dgvTeachers.TabIndex = 0;
			// 
			// cbStudentsGroups
			// 
			this.cbStudentsGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStudentsGroups.FormattingEnabled = true;
			this.cbStudentsGroups.Location = new System.Drawing.Point(87, 21);
			this.cbStudentsGroups.Name = "cbStudentsGroups";
			this.cbStudentsGroups.Size = new System.Drawing.Size(121, 21);
			this.cbStudentsGroups.TabIndex = 2;
			// 
			// cbStudentsDirections
			// 
			this.cbStudentsDirections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStudentsDirections.FormattingEnabled = true;
			this.cbStudentsDirections.Location = new System.Drawing.Point(454, 21);
			this.cbStudentsDirections.Name = "cbStudentsDirections";
			this.cbStudentsDirections.Size = new System.Drawing.Size(490, 21);
			this.cbStudentsDirections.TabIndex = 3;
			// 
			// labelGroups
			// 
			this.labelGroups.AutoSize = true;
			this.labelGroups.Location = new System.Drawing.Point(36, 24);
			this.labelGroups.Name = "labelGroups";
			this.labelGroups.Size = new System.Drawing.Size(45, 13);
			this.labelGroups.TabIndex = 4;
			this.labelGroups.Text = "Группа:";
			// 
			// labelDirections
			// 
			this.labelDirections.AutoSize = true;
			this.labelDirections.Location = new System.Drawing.Point(321, 24);
			this.labelDirections.Name = "labelDirections";
			this.labelDirections.Size = new System.Drawing.Size(127, 13);
			this.labelDirections.TabIndex = 5;
			this.labelDirections.Text = "Направление обучения:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1002, 775);
			this.Controls.Add(this.tabControl);
			this.Name = "MainForm";
			this.Text = "Academy";
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.statusStripStudents.ResumeLayout(false);
			this.statusStripStudents.PerformLayout();
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageGroups.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
			this.tslGroupCount.ResumeLayout(false);
			this.tslGroupCount.PerformLayout();
			this.tabPageTeachers.ResumeLayout(false);
			this.tabPageTeachers.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
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
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.DataGridView dgvGroups;
		private System.Windows.Forms.Label lblGroupsDirection;
		private System.Windows.Forms.ComboBox cbGroupsDirection;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.DataGridView dgvTeachers;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tslTeachersCount;
		private System.Windows.Forms.Label labelDirections;
		private System.Windows.Forms.Label labelGroups;
		private System.Windows.Forms.ComboBox cbStudentsDirections;
		private System.Windows.Forms.ComboBox cbStudentsGroups;
	}
}

