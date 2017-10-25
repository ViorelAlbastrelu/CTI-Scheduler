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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabDiscipline = new System.Windows.Forms.TabPage();
			this.tabProffesor = new System.Windows.Forms.TabPage();
			this.tabHall = new System.Windows.Forms.TabPage();
			this.tabShcedule = new System.Windows.Forms.TabPage();
			this.tabGeneration = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
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
			this.tabDiscipline.Size = new System.Drawing.Size(866, 428);
			this.tabDiscipline.TabIndex = 1;
			this.tabDiscipline.Text = "Discipline";
			this.tabDiscipline.UseVisualStyleBackColor = true;
			// 
			// tabProffesor
			// 
			this.tabProffesor.Location = new System.Drawing.Point(4, 22);
			this.tabProffesor.Name = "tabProffesor";
			this.tabProffesor.Padding = new System.Windows.Forms.Padding(3);
			this.tabProffesor.Size = new System.Drawing.Size(866, 428);
			this.tabProffesor.TabIndex = 2;
			this.tabProffesor.Text = "Profesori";
			this.tabProffesor.UseVisualStyleBackColor = true;
			this.tabProffesor.Click += new System.EventHandler(this.tabPage1_Click);
			// 
			// tabHall
			// 
			this.tabHall.Location = new System.Drawing.Point(4, 22);
			this.tabHall.Name = "tabHall";
			this.tabHall.Size = new System.Drawing.Size(866, 428);
			this.tabHall.TabIndex = 3;
			this.tabHall.Text = "Sali";
			this.tabHall.UseVisualStyleBackColor = true;
			// 
			// tabShcedule
			// 
			this.tabShcedule.Location = new System.Drawing.Point(4, 22);
			this.tabShcedule.Name = "tabShcedule";
			this.tabShcedule.Size = new System.Drawing.Size(866, 428);
			this.tabShcedule.TabIndex = 4;
			this.tabShcedule.Text = "Orar";
			this.tabShcedule.UseVisualStyleBackColor = true;
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
	}
}

