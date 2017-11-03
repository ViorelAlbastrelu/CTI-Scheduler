namespace CTISchedule
{
	partial class Scheduler
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
			this.inchideAplicatiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.profesoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disciplineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelSchedule = new System.Windows.Forms.Panel();
			this.moduleFormContainer = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvScheduler = new System.Windows.Forms.DataGridView();
			this.daysColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.moduleColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.hoursColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sg1Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sg2Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.panelSchedule.SuspendLayout();
			this.moduleFormContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvScheduler)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.editToolStripMenuItem,
            this.ajutorToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1377, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fisierToolStripMenuItem
			// 
			this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.xToolStripMenuItem,
            this.inchideAplicatiaToolStripMenuItem});
			this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
			this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.fisierToolStripMenuItem.Text = "Fisier";
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.importToolStripMenuItem.Text = "Import";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.exportToolStripMenuItem.Text = "Export";
			// 
			// xToolStripMenuItem
			// 
			this.xToolStripMenuItem.Name = "xToolStripMenuItem";
			this.xToolStripMenuItem.Size = new System.Drawing.Size(157, 6);
			// 
			// inchideAplicatiaToolStripMenuItem
			// 
			this.inchideAplicatiaToolStripMenuItem.Name = "inchideAplicatiaToolStripMenuItem";
			this.inchideAplicatiaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.inchideAplicatiaToolStripMenuItem.Text = "Inchide aplicatia";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profesoriToolStripMenuItem,
            this.disciplineToolStripMenuItem,
            this.saliToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// profesoriToolStripMenuItem
			// 
			this.profesoriToolStripMenuItem.Name = "profesoriToolStripMenuItem";
			this.profesoriToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.profesoriToolStripMenuItem.Text = "Profesori";
			this.profesoriToolStripMenuItem.Click += new System.EventHandler(this.profesoriToolStripMenuItem_Click);
			// 
			// disciplineToolStripMenuItem
			// 
			this.disciplineToolStripMenuItem.Name = "disciplineToolStripMenuItem";
			this.disciplineToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.disciplineToolStripMenuItem.Text = "Discipline";
			// 
			// saliToolStripMenuItem
			// 
			this.saliToolStripMenuItem.Name = "saliToolStripMenuItem";
			this.saliToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.saliToolStripMenuItem.Text = "Sali";
			// 
			// ajutorToolStripMenuItem
			// 
			this.ajutorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informatiiToolStripMenuItem});
			this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
			this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.ajutorToolStripMenuItem.Text = "Ajutor";
			// 
			// informatiiToolStripMenuItem
			// 
			this.informatiiToolStripMenuItem.Name = "informatiiToolStripMenuItem";
			this.informatiiToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.informatiiToolStripMenuItem.Text = "Informatii";
			// 
			// panelSchedule
			// 
			this.panelSchedule.BackColor = System.Drawing.SystemColors.ControlLight;
			this.panelSchedule.Controls.Add(this.dgvScheduler);
			this.panelSchedule.Controls.Add(this.moduleFormContainer);
			this.panelSchedule.Location = new System.Drawing.Point(0, 27);
			this.panelSchedule.Name = "panelSchedule";
			this.panelSchedule.Size = new System.Drawing.Size(882, 442);
			this.panelSchedule.TabIndex = 2;
			// 
			// moduleFormContainer
			// 
			this.moduleFormContainer.BackColor = System.Drawing.SystemColors.MenuBar;
			this.moduleFormContainer.Controls.Add(this.comboBox4);
			this.moduleFormContainer.Controls.Add(this.label4);
			this.moduleFormContainer.Controls.Add(this.comboBox3);
			this.moduleFormContainer.Controls.Add(this.label3);
			this.moduleFormContainer.Controls.Add(this.comboBox2);
			this.moduleFormContainer.Controls.Add(this.label2);
			this.moduleFormContainer.Controls.Add(this.comboBox1);
			this.moduleFormContainer.Controls.Add(this.splitter1);
			this.moduleFormContainer.Controls.Add(this.label1);
			this.moduleFormContainer.Location = new System.Drawing.Point(655, 3);
			this.moduleFormContainer.Name = "moduleFormContainer";
			this.moduleFormContainer.Size = new System.Drawing.Size(224, 436);
			this.moduleFormContainer.TabIndex = 1;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 436);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Diciplina";
			// 
			// dgvScheduler
			// 
			this.dgvScheduler.AllowUserToDeleteRows = false;
			this.dgvScheduler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvScheduler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.daysColumn,
            this.moduleColumn,
            this.hoursColumn,
            this.sg1Column,
            this.sg2Column});
			this.dgvScheduler.Location = new System.Drawing.Point(3, 3);
			this.dgvScheduler.Name = "dgvScheduler";
			this.dgvScheduler.Size = new System.Drawing.Size(646, 436);
			this.dgvScheduler.TabIndex = 0;
			this.dgvScheduler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScheduler_CellClick);
			this.dgvScheduler.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvScheduler_CellPainting);
			// 
			// daysColumn
			// 
			this.daysColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.daysColumn.DefaultCellStyle = dataGridViewCellStyle2;
			this.daysColumn.HeaderText = "ZIUA";
			this.daysColumn.Name = "daysColumn";
			this.daysColumn.ReadOnly = true;
			this.daysColumn.Width = 57;
			// 
			// moduleColumn
			// 
			this.moduleColumn.HeaderText = "MODUL";
			this.moduleColumn.Name = "moduleColumn";
			this.moduleColumn.ReadOnly = true;
			// 
			// hoursColumn
			// 
			this.hoursColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
			this.hoursColumn.FillWeight = 20F;
			this.hoursColumn.HeaderText = "ORA";
			this.hoursColumn.Name = "hoursColumn";
			this.hoursColumn.ReadOnly = true;
			this.hoursColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.hoursColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.hoursColumn.Width = 21;
			// 
			// sg1Column
			// 
			this.sg1Column.HeaderText = "22c41a";
			this.sg1Column.Name = "sg1Column";
			this.sg1Column.ReadOnly = true;
			// 
			// sg2Column
			// 
			this.sg2Column.HeaderText = "22c41b";
			this.sg2Column.Name = "sg2Column";
			this.sg2Column.ReadOnly = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(36, 74);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(147, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(36, 128);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(147, 21);
			this.comboBox2.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Diciplina";
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(36, 185);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(147, 21);
			this.comboBox3.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Diciplina";
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(36, 238);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(147, 21);
			this.comboBox4.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 222);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(47, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Diciplina";
			// 
			// Scheduler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1377, 579);
			this.Controls.Add(this.panelSchedule);
			this.Controls.Add(this.menuStrip1);
			this.Name = "Scheduler";
			this.Text = "Scheduler";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelSchedule.ResumeLayout(false);
			this.moduleFormContainer.ResumeLayout(false);
			this.moduleFormContainer.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvScheduler)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator xToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inchideAplicatiaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem profesoriToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem disciplineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saliToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informatiiToolStripMenuItem;
		private System.Windows.Forms.Panel panelSchedule;
		private System.Windows.Forms.DataGridView dgvScheduler;
		private System.Windows.Forms.DataGridViewTextBoxColumn daysColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn moduleColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn hoursColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn sg1Column;
		private System.Windows.Forms.DataGridViewTextBoxColumn sg2Column;
		private System.Windows.Forms.Panel moduleFormContainer;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}