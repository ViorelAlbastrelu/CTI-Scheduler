namespace CTISchedule
{
	partial class Schedule
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
			this.profesorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cTIScheduleDBDataSet = new CTISchedule.CTIScheduleDBDataSet();
			this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.profesorsTableAdapter = new CTISchedule.CTIScheduleDBDataSetTableAdapters.ProfesorsTableAdapter();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabShcedule = new System.Windows.Forms.TabPage();
			this.tabGeneration = new System.Windows.Forms.TabPage();
			this.tabHall = new System.Windows.Forms.TabPage();
			this.tabProffesor = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitluProfesor = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSubmitProfesor = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmailProfesor = new System.Windows.Forms.TextBox();
			this.txtPrenumeProfesor = new System.Windows.Forms.TextBox();
			this.txtNumeProfesor = new System.Windows.Forms.TextBox();
			this.btnCancelProfesor = new System.Windows.Forms.Button();
			this.txtIdProfesor = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnDeleteProfesor = new System.Windows.Forms.Button();
			this.dgvProfesor = new System.Windows.Forms.DataGridView();
			this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabDiscipline = new System.Windows.Forms.TabPage();
			this.tabDataImport = new System.Windows.Forms.TabPage();
			this.button1 = new System.Windows.Forms.Button();
			this.txtDataImport = new System.Windows.Forms.TextBox();
			this.btnCancelDataImport = new System.Windows.Forms.Button();
			this.btnSubmitDataImport = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			((System.ComponentModel.ISupportInitialize)(this.profesorsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cTIScheduleDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
			this.tabProffesor.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).BeginInit();
			this.tabDataImport.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// profesorsBindingSource
			// 
			this.profesorsBindingSource.DataMember = "Profesors";
			this.profesorsBindingSource.DataSource = this.cTIScheduleDBDataSet;
			// 
			// cTIScheduleDBDataSet
			// 
			this.cTIScheduleDBDataSet.DataSetName = "CTIScheduleDBDataSet";
			this.cTIScheduleDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// profesorBindingSource
			// 
			this.profesorBindingSource.DataMember = "Profesor";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
			this.label1.Location = new System.Drawing.Point(240, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 46);
			this.label1.TabIndex = 1;
			this.label1.Text = "CTI Schedule";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// profesorsTableAdapter
			// 
			this.profesorsTableAdapter.ClearBeforeFill = true;
			// 
			// tabShcedule
			// 
			this.tabShcedule.Location = new System.Drawing.Point(4, 22);
			this.tabShcedule.Name = "tabShcedule";
			this.tabShcedule.Size = new System.Drawing.Size(822, 417);
			this.tabShcedule.TabIndex = 4;
			this.tabShcedule.Text = "Orar";
			this.tabShcedule.UseVisualStyleBackColor = true;
			// 
			// tabGeneration
			// 
			this.tabGeneration.Location = new System.Drawing.Point(4, 22);
			this.tabGeneration.Name = "tabGeneration";
			this.tabGeneration.Size = new System.Drawing.Size(822, 417);
			this.tabGeneration.TabIndex = 5;
			this.tabGeneration.Text = "Generatii";
			this.tabGeneration.UseVisualStyleBackColor = true;
			// 
			// tabHall
			// 
			this.tabHall.Location = new System.Drawing.Point(4, 22);
			this.tabHall.Name = "tabHall";
			this.tabHall.Size = new System.Drawing.Size(822, 417);
			this.tabHall.TabIndex = 3;
			this.tabHall.Text = "Sali";
			this.tabHall.UseVisualStyleBackColor = true;
			// 
			// tabProffesor
			// 
			this.tabProffesor.Controls.Add(this.dgvProfesor);
			this.tabProffesor.Controls.Add(this.panel1);
			this.tabProffesor.Location = new System.Drawing.Point(4, 22);
			this.tabProffesor.Name = "tabProffesor";
			this.tabProffesor.Padding = new System.Windows.Forms.Padding(3);
			this.tabProffesor.Size = new System.Drawing.Size(822, 417);
			this.tabProffesor.TabIndex = 2;
			this.tabProffesor.Text = "Profesori";
			this.tabProffesor.UseVisualStyleBackColor = true;
			this.tabProffesor.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.btnDeleteProfesor);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtIdProfesor);
			this.panel1.Controls.Add(this.btnCancelProfesor);
			this.panel1.Controls.Add(this.txtNumeProfesor);
			this.panel1.Controls.Add(this.txtPrenumeProfesor);
			this.panel1.Controls.Add(this.txtEmailProfesor);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.btnSubmitProfesor);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtTitluProfesor);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(11, 59);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(251, 267);
			this.panel1.TabIndex = 10;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(124, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Prenume";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nume";
			// 
			// txtTitluProfesor
			// 
			this.txtTitluProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.profesorsBindingSource, "Titlu", true));
			this.txtTitluProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorsBindingSource, "Titlu", true));
			this.txtTitluProfesor.Location = new System.Drawing.Point(127, 145);
			this.txtTitluProfesor.Name = "txtTitluProfesor";
			this.txtTitluProfesor.Size = new System.Drawing.Size(100, 20);
			this.txtTitluProfesor.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(124, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Titlu";
			// 
			// btnSubmitProfesor
			// 
			this.btnSubmitProfesor.Location = new System.Drawing.Point(156, 231);
			this.btnSubmitProfesor.Name = "btnSubmitProfesor";
			this.btnSubmitProfesor.Size = new System.Drawing.Size(71, 23);
			this.btnSubmitProfesor.TabIndex = 8;
			this.btnSubmitProfesor.Text = "Salveaza";
			this.btnSubmitProfesor.UseVisualStyleBackColor = true;
			this.btnSubmitProfesor.Click += new System.EventHandler(this.btnSubmitProfesor_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Email";
			// 
			// txtEmailProfesor
			// 
			this.txtEmailProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.profesorsBindingSource, "Email", true));
			this.txtEmailProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorsBindingSource, "Email", true));
			this.txtEmailProfesor.Location = new System.Drawing.Point(16, 145);
			this.txtEmailProfesor.Name = "txtEmailProfesor";
			this.txtEmailProfesor.Size = new System.Drawing.Size(100, 20);
			this.txtEmailProfesor.TabIndex = 2;
			// 
			// txtPrenumeProfesor
			// 
			this.txtPrenumeProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.profesorsBindingSource, "Prenume", true));
			this.txtPrenumeProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorsBindingSource, "Prenume", true));
			this.txtPrenumeProfesor.Location = new System.Drawing.Point(127, 93);
			this.txtPrenumeProfesor.Name = "txtPrenumeProfesor";
			this.txtPrenumeProfesor.Size = new System.Drawing.Size(100, 20);
			this.txtPrenumeProfesor.TabIndex = 1;
			// 
			// txtNumeProfesor
			// 
			this.txtNumeProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorsBindingSource, "Nume", true));
			this.txtNumeProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.profesorsBindingSource, "Nume", true));
			this.txtNumeProfesor.Location = new System.Drawing.Point(16, 93);
			this.txtNumeProfesor.Name = "txtNumeProfesor";
			this.txtNumeProfesor.Size = new System.Drawing.Size(100, 20);
			this.txtNumeProfesor.TabIndex = 0;
			// 
			// btnCancelProfesor
			// 
			this.btnCancelProfesor.Location = new System.Drawing.Point(152, 23);
			this.btnCancelProfesor.Name = "btnCancelProfesor";
			this.btnCancelProfesor.Size = new System.Drawing.Size(75, 23);
			this.btnCancelProfesor.TabIndex = 9;
			this.btnCancelProfesor.Text = "Anuleaza";
			this.btnCancelProfesor.UseVisualStyleBackColor = true;
			this.btnCancelProfesor.Click += new System.EventHandler(this.btnCancelProfesor_Click);
			// 
			// txtIdProfesor
			// 
			this.txtIdProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.profesorsBindingSource, "Id", true));
			this.txtIdProfesor.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.profesorsBindingSource, "Id", true));
			this.txtIdProfesor.Location = new System.Drawing.Point(35, 23);
			this.txtIdProfesor.Name = "txtIdProfesor";
			this.txtIdProfesor.ReadOnly = true;
			this.txtIdProfesor.Size = new System.Drawing.Size(38, 20);
			this.txtIdProfesor.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(16, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Id";
			// 
			// btnDeleteProfesor
			// 
			this.btnDeleteProfesor.Location = new System.Drawing.Point(16, 231);
			this.btnDeleteProfesor.Name = "btnDeleteProfesor";
			this.btnDeleteProfesor.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteProfesor.TabIndex = 14;
			this.btnDeleteProfesor.Text = "Sterge";
			this.btnDeleteProfesor.UseVisualStyleBackColor = true;
			this.btnDeleteProfesor.Click += new System.EventHandler(this.btnDeleteProfesor_Click);
			// 
			// dgvProfesor
			// 
			this.dgvProfesor.AutoGenerateColumns = false;
			this.dgvProfesor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dgvProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn});
			this.dgvProfesor.DataSource = this.profesorsBindingSource;
			this.dgvProfesor.Location = new System.Drawing.Point(268, 59);
			this.dgvProfesor.MultiSelect = false;
			this.dgvProfesor.Name = "dgvProfesor";
			this.dgvProfesor.Size = new System.Drawing.Size(543, 267);
			this.dgvProfesor.TabIndex = 11;
			// 
			// titluDataGridViewTextBoxColumn
			// 
			this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
			this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
			this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			// 
			// prenumeDataGridViewTextBoxColumn
			// 
			this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
			this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
			this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
			// 
			// numeDataGridViewTextBoxColumn
			// 
			this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
			this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
			this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// tabDiscipline
			// 
			this.tabDiscipline.Location = new System.Drawing.Point(4, 22);
			this.tabDiscipline.Name = "tabDiscipline";
			this.tabDiscipline.Padding = new System.Windows.Forms.Padding(3);
			this.tabDiscipline.Size = new System.Drawing.Size(822, 417);
			this.tabDiscipline.TabIndex = 1;
			this.tabDiscipline.Text = "Discipline";
			this.tabDiscipline.UseVisualStyleBackColor = true;
			// 
			// tabDataImport
			// 
			this.tabDataImport.Controls.Add(this.btnSubmitDataImport);
			this.tabDataImport.Controls.Add(this.btnCancelDataImport);
			this.tabDataImport.Controls.Add(this.txtDataImport);
			this.tabDataImport.Controls.Add(this.button1);
			this.tabDataImport.Location = new System.Drawing.Point(4, 22);
			this.tabDataImport.Name = "tabDataImport";
			this.tabDataImport.Padding = new System.Windows.Forms.Padding(3);
			this.tabDataImport.Size = new System.Drawing.Size(822, 417);
			this.tabDataImport.TabIndex = 6;
			this.tabDataImport.Text = "Import Date";
			this.tabDataImport.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(479, 191);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(54, 24);
			this.button1.TabIndex = 0;
			this.button1.Text = "Cauta";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtDataImport
			// 
			this.txtDataImport.Location = new System.Drawing.Point(265, 194);
			this.txtDataImport.Name = "txtDataImport";
			this.txtDataImport.Size = new System.Drawing.Size(208, 20);
			this.txtDataImport.TabIndex = 1;
			// 
			// btnCancelDataImport
			// 
			this.btnCancelDataImport.Location = new System.Drawing.Point(265, 221);
			this.btnCancelDataImport.Name = "btnCancelDataImport";
			this.btnCancelDataImport.Size = new System.Drawing.Size(75, 23);
			this.btnCancelDataImport.TabIndex = 2;
			this.btnCancelDataImport.Text = "Anuleaza";
			this.btnCancelDataImport.UseVisualStyleBackColor = true;
			this.btnCancelDataImport.Click += new System.EventHandler(this.btnCancelDataImport_Click);
			// 
			// btnSubmitDataImport
			// 
			this.btnSubmitDataImport.Location = new System.Drawing.Point(458, 221);
			this.btnSubmitDataImport.Name = "btnSubmitDataImport";
			this.btnSubmitDataImport.Size = new System.Drawing.Size(75, 23);
			this.btnSubmitDataImport.TabIndex = 3;
			this.btnSubmitDataImport.Text = "Import";
			this.btnSubmitDataImport.UseVisualStyleBackColor = true;
			this.btnSubmitDataImport.Click += new System.EventHandler(this.btnSubmitDataImport_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabDataImport);
			this.tabControl1.Controls.Add(this.tabDiscipline);
			this.tabControl1.Controls.Add(this.tabProffesor);
			this.tabControl1.Controls.Add(this.tabHall);
			this.tabControl1.Controls.Add(this.tabGeneration);
			this.tabControl1.Controls.Add(this.tabShcedule);
			this.tabControl1.Location = new System.Drawing.Point(-3, 94);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(830, 443);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
			// 
			// Schedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 533);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabControl1);
			this.Name = "Schedule";
			this.Text = "CTI Schedule";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.profesorsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cTIScheduleDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
			this.tabProffesor.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).EndInit();
			this.tabDataImport.ResumeLayout(false);
			this.tabDataImport.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource profesorBindingSource;
		private CTIScheduleDBDataSet cTIScheduleDBDataSet;
		private System.Windows.Forms.BindingSource profesorsBindingSource;
		private CTIScheduleDBDataSetTableAdapters.ProfesorsTableAdapter profesorsTableAdapter;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TabPage tabShcedule;
		private System.Windows.Forms.TabPage tabGeneration;
		private System.Windows.Forms.TabPage tabHall;
		private System.Windows.Forms.TabPage tabProffesor;
		private System.Windows.Forms.DataGridView dgvProfesor;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnDeleteProfesor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIdProfesor;
		private System.Windows.Forms.Button btnCancelProfesor;
		private System.Windows.Forms.TextBox txtNumeProfesor;
		private System.Windows.Forms.TextBox txtPrenumeProfesor;
		private System.Windows.Forms.TextBox txtEmailProfesor;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSubmitProfesor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTitluProfesor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabDiscipline;
		private System.Windows.Forms.TabPage tabDataImport;
		private System.Windows.Forms.Button btnSubmitDataImport;
		private System.Windows.Forms.Button btnCancelDataImport;
		private System.Windows.Forms.TextBox txtDataImport;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}

