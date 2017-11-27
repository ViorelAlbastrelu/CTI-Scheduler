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
            this.btnLinkProfesorDisciplina = new System.Windows.Forms.Button();
            this.txtIdProfesor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lboxPModule = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboxPDiscipline = new System.Windows.Forms.ComboBox();
            this.lboxPDiscipline = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTitluProfesor = new System.Windows.Forms.TextBox();
            this.txtNumeProfesor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveModule = new System.Windows.Forms.Button();
            this.btnDeleteModule = new System.Windows.Forms.Button();
            this.btnCancelModule = new System.Windows.Forms.Button();
            this.moduleProfesorContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // moduleProfesorContainer
            // 
            this.moduleProfesorContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moduleProfesorContainer.Controls.Add(this.btnSaveModule);
            this.moduleProfesorContainer.Controls.Add(this.btnDeleteModule);
            this.moduleProfesorContainer.Controls.Add(this.btnCancelModule);
            this.moduleProfesorContainer.Controls.Add(this.btnLinkProfesorDisciplina);
            this.moduleProfesorContainer.Controls.Add(this.txtIdProfesor);
            this.moduleProfesorContainer.Controls.Add(this.label9);
            this.moduleProfesorContainer.Controls.Add(this.lboxPModule);
            this.moduleProfesorContainer.Controls.Add(this.label8);
            this.moduleProfesorContainer.Controls.Add(this.cboxPDiscipline);
            this.moduleProfesorContainer.Controls.Add(this.lboxPDiscipline);
            this.moduleProfesorContainer.Controls.Add(this.label7);
            this.moduleProfesorContainer.Controls.Add(this.label6);
            this.moduleProfesorContainer.Controls.Add(this.txtTitluProfesor);
            this.moduleProfesorContainer.Controls.Add(this.txtNumeProfesor);
            this.moduleProfesorContainer.Controls.Add(this.label5);
            this.moduleProfesorContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.moduleProfesorContainer.Location = new System.Drawing.Point(0, 0);
            this.moduleProfesorContainer.Name = "moduleProfesorContainer";
            this.moduleProfesorContainer.Size = new System.Drawing.Size(185, 441);
            this.moduleProfesorContainer.TabIndex = 2;
            // 
            // btnLinkProfesorDisciplina
            // 
            this.btnLinkProfesorDisciplina.Location = new System.Drawing.Point(107, 152);
            this.btnLinkProfesorDisciplina.Name = "btnLinkProfesorDisciplina";
            this.btnLinkProfesorDisciplina.Size = new System.Drawing.Size(66, 23);
            this.btnLinkProfesorDisciplina.TabIndex = 15;
            this.btnLinkProfesorDisciplina.Text = "Adauga";
            this.btnLinkProfesorDisciplina.UseVisualStyleBackColor = true;
            // 
            // txtIdProfesor
            // 
            this.txtIdProfesor.Location = new System.Drawing.Point(81, 14);
            this.txtIdProfesor.Name = "txtIdProfesor";
            this.txtIdProfesor.ReadOnly = true;
            this.txtIdProfesor.Size = new System.Drawing.Size(92, 20);
            this.txtIdProfesor.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Identificator";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Module";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Discipline";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Titlu";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nume";
            // 
            // btnSaveModule
            // 
            this.btnSaveModule.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveModule.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveModule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSaveModule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveModule.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveModule.Location = new System.Drawing.Point(16, 403);
            this.btnSaveModule.Name = "btnSaveModule";
            this.btnSaveModule.Size = new System.Drawing.Size(157, 23);
            this.btnSaveModule.TabIndex = 22;
            this.btnSaveModule.Text = "Salveaza";
            this.btnSaveModule.UseVisualStyleBackColor = false;
            // 
            // btnDeleteModule
            // 
            this.btnDeleteModule.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteModule.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteModule.Location = new System.Drawing.Point(98, 374);
            this.btnDeleteModule.Name = "btnDeleteModule";
            this.btnDeleteModule.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteModule.TabIndex = 21;
            this.btnDeleteModule.Text = "Sterge";
            this.btnDeleteModule.UseVisualStyleBackColor = false;
            // 
            // btnCancelModule
            // 
            this.btnCancelModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelModule.Location = new System.Drawing.Point(17, 374);
            this.btnCancelModule.Name = "btnCancelModule";
            this.btnCancelModule.Size = new System.Drawing.Size(75, 23);
            this.btnCancelModule.TabIndex = 20;
            this.btnCancelModule.Text = "Anuleaza";
            this.btnCancelModule.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lboxPModule;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboxPDiscipline;
        private System.Windows.Forms.ListBox lboxPDiscipline;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTitluProfesor;
        private System.Windows.Forms.TextBox txtNumeProfesor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveModule;
        private System.Windows.Forms.Button btnDeleteModule;
        private System.Windows.Forms.Button btnCancelModule;
    }
}
