namespace CTISchedule
{
    partial class FormProfesor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.moduleProfesorContainer = new System.Windows.Forms.Panel();
            this.btnSaveProfesor = new System.Windows.Forms.Button();
            this.btnDeleteProfesor = new System.Windows.Forms.Button();
            this.btnCancelProfesor = new System.Windows.Forms.Button();
            this.btnLinkProfesorDisciplina = new System.Windows.Forms.Button();
            this.txtIdProfesor = new System.Windows.Forms.TextBox();
            this.labelIdentificator = new System.Windows.Forms.Label();
            this.lboxPModule = new System.Windows.Forms.ListBox();
            this.labelModule = new System.Windows.Forms.Label();
            this.cboxPDiscipline = new System.Windows.Forms.ComboBox();
            this.lboxPDiscipline = new System.Windows.Forms.ListBox();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.labelTitlu = new System.Windows.Forms.Label();
            this.txtTitluProfesor = new System.Windows.Forms.TextBox();
            this.txtNumeProfesor = new System.Windows.Forms.TextBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.moduleProfesorContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // moduleProfesorContainer
            // 
            this.moduleProfesorContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moduleProfesorContainer.Controls.Add(this.btnSaveProfesor);
            this.moduleProfesorContainer.Controls.Add(this.btnDeleteProfesor);
            this.moduleProfesorContainer.Controls.Add(this.btnCancelProfesor);
            this.moduleProfesorContainer.Controls.Add(this.btnLinkProfesorDisciplina);
            this.moduleProfesorContainer.Controls.Add(this.txtIdProfesor);
            this.moduleProfesorContainer.Controls.Add(this.labelIdentificator);
            this.moduleProfesorContainer.Controls.Add(this.lboxPModule);
            this.moduleProfesorContainer.Controls.Add(this.labelModule);
            this.moduleProfesorContainer.Controls.Add(this.cboxPDiscipline);
            this.moduleProfesorContainer.Controls.Add(this.lboxPDiscipline);
            this.moduleProfesorContainer.Controls.Add(this.labelDiscipline);
            this.moduleProfesorContainer.Controls.Add(this.labelTitlu);
            this.moduleProfesorContainer.Controls.Add(this.txtTitluProfesor);
            this.moduleProfesorContainer.Controls.Add(this.txtNumeProfesor);
            this.moduleProfesorContainer.Controls.Add(this.labelNume);
            this.moduleProfesorContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.moduleProfesorContainer.Location = new System.Drawing.Point(0, 0);
            this.moduleProfesorContainer.Name = "moduleProfesorContainer";
            this.moduleProfesorContainer.Size = new System.Drawing.Size(185, 441);
            this.moduleProfesorContainer.TabIndex = 2;
            // 
            // btnSaveProfesor
            // 
            this.btnSaveProfesor.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveProfesor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveProfesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSaveProfesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfesor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveProfesor.Location = new System.Drawing.Point(16, 403);
            this.btnSaveProfesor.Name = "btnSaveProfesor";
            this.btnSaveProfesor.Size = new System.Drawing.Size(157, 23);
            this.btnSaveProfesor.TabIndex = 22;
            this.btnSaveProfesor.Text = "Salveaza";
            this.btnSaveProfesor.UseVisualStyleBackColor = false;
            // 
            // btnDeleteProfesor
            // 
            this.btnDeleteProfesor.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProfesor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteProfesor.Location = new System.Drawing.Point(98, 374);
            this.btnDeleteProfesor.Name = "btnDeleteProfesor";
            this.btnDeleteProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteProfesor.TabIndex = 21;
            this.btnDeleteProfesor.Text = "Sterge";
            this.btnDeleteProfesor.UseVisualStyleBackColor = false;
            // 
            // btnCancelProfesor
            // 
            this.btnCancelProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelProfesor.Location = new System.Drawing.Point(17, 374);
            this.btnCancelProfesor.Name = "btnCancelProfesor";
            this.btnCancelProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnCancelProfesor.TabIndex = 20;
            this.btnCancelProfesor.Text = "Anuleaza";
            this.btnCancelProfesor.UseVisualStyleBackColor = true;
            // 
            // btnLinkProfesorDisciplina
            // 
            this.btnLinkProfesorDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinkProfesorDisciplina.Location = new System.Drawing.Point(107, 152);
            this.btnLinkProfesorDisciplina.Name = "btnLinkProfesorDisciplina";
            this.btnLinkProfesorDisciplina.Size = new System.Drawing.Size(66, 23);
            this.btnLinkProfesorDisciplina.TabIndex = 15;
            this.btnLinkProfesorDisciplina.Text = "Adauga";
            this.btnLinkProfesorDisciplina.UseVisualStyleBackColor = true;
            // 
            // txtIdProfesor
            // 
            this.txtIdProfesor.Location = new System.Drawing.Point(81, 11);
            this.txtIdProfesor.Name = "txtIdProfesor";
            this.txtIdProfesor.ReadOnly = true;
            this.txtIdProfesor.Size = new System.Drawing.Size(92, 20);
            this.txtIdProfesor.TabIndex = 14;
            // 
            // labelIdentificator
            // 
            this.labelIdentificator.AutoSize = true;
            this.labelIdentificator.Location = new System.Drawing.Point(13, 14);
            this.labelIdentificator.Name = "labelIdentificator";
            this.labelIdentificator.Size = new System.Drawing.Size(62, 13);
            this.labelIdentificator.TabIndex = 13;
            this.labelIdentificator.Text = "Identificator";
            // 
            // lboxPModule
            // 
            this.lboxPModule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxPModule.FormattingEnabled = true;
            this.lboxPModule.Location = new System.Drawing.Point(16, 269);
            this.lboxPModule.Name = "lboxPModule";
            this.lboxPModule.Size = new System.Drawing.Size(157, 67);
            this.lboxPModule.TabIndex = 8;
            // 
            // labelModule
            // 
            this.labelModule.AutoSize = true;
            this.labelModule.Location = new System.Drawing.Point(13, 253);
            this.labelModule.Name = "labelModule";
            this.labelModule.Size = new System.Drawing.Size(42, 13);
            this.labelModule.TabIndex = 7;
            this.labelModule.Text = "Module";
            // 
            // cboxPDiscipline
            // 
            this.cboxPDiscipline.DisplayMember = "NumeScurt";
            this.cboxPDiscipline.FormattingEnabled = true;
            this.cboxPDiscipline.Location = new System.Drawing.Point(16, 154);
            this.cboxPDiscipline.Name = "cboxPDiscipline";
            this.cboxPDiscipline.Size = new System.Drawing.Size(84, 21);
            this.cboxPDiscipline.TabIndex = 6;
            this.cboxPDiscipline.ValueMember = "Id";
            // 
            // lboxPDiscipline
            // 
            this.lboxPDiscipline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxPDiscipline.FormattingEnabled = true;
            this.lboxPDiscipline.Location = new System.Drawing.Point(16, 181);
            this.lboxPDiscipline.Name = "lboxPDiscipline";
            this.lboxPDiscipline.Size = new System.Drawing.Size(157, 54);
            this.lboxPDiscipline.TabIndex = 5;
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Location = new System.Drawing.Point(13, 138);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(52, 13);
            this.labelDiscipline.TabIndex = 4;
            this.labelDiscipline.Text = "Discipline";
            // 
            // labelTitlu
            // 
            this.labelTitlu.AutoSize = true;
            this.labelTitlu.Location = new System.Drawing.Point(13, 89);
            this.labelTitlu.Name = "labelTitlu";
            this.labelTitlu.Size = new System.Drawing.Size(27, 13);
            this.labelTitlu.TabIndex = 3;
            this.labelTitlu.Text = "Titlu";
            // 
            // txtTitluProfesor
            // 
            this.txtTitluProfesor.Location = new System.Drawing.Point(16, 105);
            this.txtTitluProfesor.Name = "txtTitluProfesor";
            this.txtTitluProfesor.Size = new System.Drawing.Size(157, 20);
            this.txtTitluProfesor.TabIndex = 2;
            // 
            // txtNumeProfesor
            // 
            this.txtNumeProfesor.Location = new System.Drawing.Point(16, 56);
            this.txtNumeProfesor.Name = "txtNumeProfesor";
            this.txtNumeProfesor.Size = new System.Drawing.Size(157, 20);
            this.txtNumeProfesor.TabIndex = 1;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(13, 39);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 0;
            this.labelNume.Text = "Nume";
            // 
            // FormProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleProfesorContainer);
            this.Name = "FormProfesor";
            this.Size = new System.Drawing.Size(185, 441);
            this.moduleProfesorContainer.ResumeLayout(false);
            this.moduleProfesorContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel moduleProfesorContainer;
        private System.Windows.Forms.Button btnLinkProfesorDisciplina;
        private System.Windows.Forms.TextBox txtIdProfesor;
        private System.Windows.Forms.Label labelIdentificator;
        private System.Windows.Forms.ListBox lboxPModule;
        private System.Windows.Forms.Label labelModule;
        private System.Windows.Forms.ComboBox cboxPDiscipline;
        private System.Windows.Forms.ListBox lboxPDiscipline;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.Label labelTitlu;
        private System.Windows.Forms.TextBox txtTitluProfesor;
        private System.Windows.Forms.TextBox txtNumeProfesor;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Button btnSaveProfesor;
        private System.Windows.Forms.Button btnDeleteProfesor;
        private System.Windows.Forms.Button btnCancelProfesor;
    }
}
