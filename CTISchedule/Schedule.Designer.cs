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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabDiscipline = new System.Windows.Forms.TabPage();
			this.tabProffesor = new System.Windows.Forms.TabPage();
			this.btnCancelProfesor = new System.Windows.Forms.Button();
			this.btnSubmitProfesor = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitluProfesor = new System.Windows.Forms.TextBox();
			this.txtEmailProfesor = new System.Windows.Forms.TextBox();
			this.txtPrenumeProfesor = new System.Windows.Forms.TextBox();
			this.txtNumeProfesor = new System.Windows.Forms.TextBox();
			this.tabHall = new System.Windows.Forms.TabPage();
			this.tabGeneration = new System.Windows.Forms.TabPage();
			this.tabShcedule = new System.Windows.Forms.TabPage();
			this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabProffesor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabDiscipline);
			this.tabControl1.Controls.Add(this.tabProffesor);
			this.tabControl1.Controls.Add(this.tabHall);
			this.tabControl1.Controls.Add(this.tabGeneration);
			this.tabControl1.Controls.Add(this.tabShcedule);
			this.tabControl1.Location = new System.Drawing.Point(-3, 94);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(766, 443);
			this.tabControl1.TabIndex = 0;
			// 
			// tabDiscipline
			// 
			this.tabDiscipline.Location = new System.Drawing.Point(4, 22);
			this.tabDiscipline.Name = "tabDiscipline";
			this.tabDiscipline.Padding = new System.Windows.Forms.Padding(3);
			this.tabDiscipline.Size = new System.Drawing.Size(758, 417);
			this.tabDiscipline.TabIndex = 1;
			this.tabDiscipline.Text = "Discipline";
			this.tabDiscipline.UseVisualStyleBackColor = true;
			// 
			// tabProffesor
			// 
			this.tabProffesor.Controls.Add(this.btnCancelProfesor);
			this.tabProffesor.Controls.Add(this.btnSubmitProfesor);
			this.tabProffesor.Controls.Add(this.label5);
			this.tabProffesor.Controls.Add(this.label4);
			this.tabProffesor.Controls.Add(this.label3);
			this.tabProffesor.Controls.Add(this.label2);
			this.tabProffesor.Controls.Add(this.txtTitluProfesor);
			this.tabProffesor.Controls.Add(this.txtEmailProfesor);
			this.tabProffesor.Controls.Add(this.txtPrenumeProfesor);
			this.tabProffesor.Controls.Add(this.txtNumeProfesor);
			this.tabProffesor.Location = new System.Drawing.Point(4, 22);
			this.tabProffesor.Name = "tabProffesor";
			this.tabProffesor.Padding = new System.Windows.Forms.Padding(3);
			this.tabProffesor.Size = new System.Drawing.Size(758, 417);
			this.tabProffesor.TabIndex = 2;
			this.tabProffesor.Text = "Profesori";
			this.tabProffesor.UseVisualStyleBackColor = true;
			this.tabProffesor.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// btnCancelProfesor
			// 
			this.btnCancelProfesor.Location = new System.Drawing.Point(40, 158);
			this.btnCancelProfesor.Name = "btnCancelProfesor";
			this.btnCancelProfesor.Size = new System.Drawing.Size(100, 23);
			this.btnCancelProfesor.TabIndex = 9;
			this.btnCancelProfesor.Text = "Anuleaza";
			this.btnCancelProfesor.UseVisualStyleBackColor = true;
			// 
			// btnSubmitProfesor
			// 
			this.btnSubmitProfesor.Location = new System.Drawing.Point(163, 158);
			this.btnSubmitProfesor.Name = "btnSubmitProfesor";
			this.btnSubmitProfesor.Size = new System.Drawing.Size(100, 23);
			this.btnSubmitProfesor.TabIndex = 8;
			this.btnSubmitProfesor.Text = "Salveaza";
			this.btnSubmitProfesor.UseVisualStyleBackColor = true;
			this.btnSubmitProfesor.Click += new System.EventHandler(this.btnSubmitProfesor_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(160, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(27, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Titlu";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(160, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Prenume";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nume";
			// 
			// txtTitluProfesor
			// 
			this.txtTitluProfesor.Location = new System.Drawing.Point(163, 116);
			this.txtTitluProfesor.Name = "txtTitluProfesor";
			this.txtTitluProfesor.Size = new System.Drawing.Size(100, 20);
			this.txtTitluProfesor.TabIndex = 3;
			// 
			// txtEmailProfesor
			// 
			this.txtEmailProfesor.Location = new System.Drawing.Point(40, 116);
			this.txtEmailProfesor.Name = "txtEmailProfesor";
			this.txtEmailProfesor.Size = new System.Drawing.Size(100, 20);
			this.txtEmailProfesor.TabIndex = 2;
			// 
			// txtPrenumeProfesor
			// 
			this.txtPrenumeProfesor.Location = new System.Drawing.Point(163, 69);
			this.txtPrenumeProfesor.Name = "txtPrenumeProfesor";
			this.txtPrenumeProfesor.Size = new System.Drawing.Size(100, 20);
			this.txtPrenumeProfesor.TabIndex = 1;
			// 
			// txtNumeProfesor
			// 
			this.txtNumeProfesor.Location = new System.Drawing.Point(40, 69);
			this.txtNumeProfesor.Name = "txtNumeProfesor";
			this.txtNumeProfesor.Size = new System.Drawing.Size(100, 20);
			this.txtNumeProfesor.TabIndex = 0;
			// 
			// tabHall
			// 
			this.tabHall.Location = new System.Drawing.Point(4, 22);
			this.tabHall.Name = "tabHall";
			this.tabHall.Size = new System.Drawing.Size(758, 417);
			this.tabHall.TabIndex = 3;
			this.tabHall.Text = "Sali";
			this.tabHall.UseVisualStyleBackColor = true;
			// 
			// tabGeneration
			// 
			this.tabGeneration.Location = new System.Drawing.Point(4, 22);
			this.tabGeneration.Name = "tabGeneration";
			this.tabGeneration.Size = new System.Drawing.Size(758, 417);
			this.tabGeneration.TabIndex = 5;
			this.tabGeneration.Text = "Generatii";
			this.tabGeneration.UseVisualStyleBackColor = true;
			// 
			// tabShcedule
			// 
			this.tabShcedule.Location = new System.Drawing.Point(4, 22);
			this.tabShcedule.Name = "tabShcedule";
			this.tabShcedule.Size = new System.Drawing.Size(758, 417);
			this.tabShcedule.TabIndex = 4;
			this.tabShcedule.Text = "Orar";
			this.tabShcedule.UseVisualStyleBackColor = true;
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
			// Schedule
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 533);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabControl1);
			this.Name = "Schedule";
			this.Text = "CTI Schedule";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabProffesor.ResumeLayout(false);
			this.tabProffesor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabDiscipline;
		private System.Windows.Forms.TabPage tabProffesor;
		private System.Windows.Forms.TabPage tabHall;
		private System.Windows.Forms.TabPage tabGeneration;
		private System.Windows.Forms.TabPage tabShcedule;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource profesorBindingSource;
		private System.Windows.Forms.Button btnCancelProfesor;
		private System.Windows.Forms.Button btnSubmitProfesor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitluProfesor;
		private System.Windows.Forms.TextBox txtEmailProfesor;
		private System.Windows.Forms.TextBox txtPrenumeProfesor;
		private System.Windows.Forms.TextBox txtNumeProfesor;
	}
}

