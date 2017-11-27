namespace CTISchedule
{
    partial class FormDisciplina
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
            this.moduleDiscplinaContainer = new System.Windows.Forms.Panel();
            this.txtNumeScurt = new System.Windows.Forms.TextBox();
            this.labelNumeScurt = new System.Windows.Forms.Label();
            this.txtSemestru = new System.Windows.Forms.TextBox();
            this.labelSemestru = new System.Windows.Forms.Label();
            this.txtIdDisciplina = new System.Windows.Forms.TextBox();
            this.labelIndentificator = new System.Windows.Forms.Label();
            this.cboxDAnStudiu = new System.Windows.Forms.ComboBox();
            this.labelNume = new System.Windows.Forms.Label();
            this.txtNumeDisciplina = new System.Windows.Forms.TextBox();
            this.labelAnStudiu = new System.Windows.Forms.Label();
            this.btnSaveDisciplina = new System.Windows.Forms.Button();
            this.btnDeleteDisciplina = new System.Windows.Forms.Button();
            this.btnCancelDisciplina = new System.Windows.Forms.Button();
            this.moduleDiscplinaContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // moduleDiscplinaContainer
            // 
            this.moduleDiscplinaContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.moduleDiscplinaContainer.Controls.Add(this.btnSaveDisciplina);
            this.moduleDiscplinaContainer.Controls.Add(this.btnDeleteDisciplina);
            this.moduleDiscplinaContainer.Controls.Add(this.btnCancelDisciplina);
            this.moduleDiscplinaContainer.Controls.Add(this.txtNumeScurt);
            this.moduleDiscplinaContainer.Controls.Add(this.labelNumeScurt);
            this.moduleDiscplinaContainer.Controls.Add(this.txtSemestru);
            this.moduleDiscplinaContainer.Controls.Add(this.labelSemestru);
            this.moduleDiscplinaContainer.Controls.Add(this.txtIdDisciplina);
            this.moduleDiscplinaContainer.Controls.Add(this.labelIndentificator);
            this.moduleDiscplinaContainer.Controls.Add(this.cboxDAnStudiu);
            this.moduleDiscplinaContainer.Controls.Add(this.labelNume);
            this.moduleDiscplinaContainer.Controls.Add(this.txtNumeDisciplina);
            this.moduleDiscplinaContainer.Controls.Add(this.labelAnStudiu);
            this.moduleDiscplinaContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.moduleDiscplinaContainer.Location = new System.Drawing.Point(0, 0);
            this.moduleDiscplinaContainer.Name = "moduleDiscplinaContainer";
            this.moduleDiscplinaContainer.Size = new System.Drawing.Size(185, 440);
            this.moduleDiscplinaContainer.TabIndex = 2;
            // 
            // txtNumeScurt
            // 
            this.txtNumeScurt.Location = new System.Drawing.Point(87, 134);
            this.txtNumeScurt.Name = "txtNumeScurt";
            this.txtNumeScurt.Size = new System.Drawing.Size(92, 20);
            this.txtNumeScurt.TabIndex = 20;
            // 
            // labelNumeScurt
            // 
            this.labelNumeScurt.AutoSize = true;
            this.labelNumeScurt.Location = new System.Drawing.Point(10, 137);
            this.labelNumeScurt.Name = "labelNumeScurt";
            this.labelNumeScurt.Size = new System.Drawing.Size(63, 13);
            this.labelNumeScurt.TabIndex = 19;
            this.labelNumeScurt.Text = "Nume Scurt";
            // 
            // txtSemestru
            // 
            this.txtSemestru.Location = new System.Drawing.Point(87, 160);
            this.txtSemestru.Name = "txtSemestru";
            this.txtSemestru.Size = new System.Drawing.Size(92, 20);
            this.txtSemestru.TabIndex = 18;
            // 
            // labelSemestru
            // 
            this.labelSemestru.AutoSize = true;
            this.labelSemestru.Location = new System.Drawing.Point(10, 163);
            this.labelSemestru.Name = "labelSemestru";
            this.labelSemestru.Size = new System.Drawing.Size(51, 13);
            this.labelSemestru.TabIndex = 17;
            this.labelSemestru.Text = "Semestru";
            // 
            // txtIdDisciplina
            // 
            this.txtIdDisciplina.Location = new System.Drawing.Point(10, 27);
            this.txtIdDisciplina.Name = "txtIdDisciplina";
            this.txtIdDisciplina.ReadOnly = true;
            this.txtIdDisciplina.Size = new System.Drawing.Size(169, 20);
            this.txtIdDisciplina.TabIndex = 16;
            // 
            // labelIndentificator
            // 
            this.labelIndentificator.AutoSize = true;
            this.labelIndentificator.Location = new System.Drawing.Point(10, 11);
            this.labelIndentificator.Name = "labelIndentificator";
            this.labelIndentificator.Size = new System.Drawing.Size(62, 13);
            this.labelIndentificator.TabIndex = 15;
            this.labelIndentificator.Text = "Identificator";
            // 
            // cboxDAnStudiu
            // 
            this.cboxDAnStudiu.FormattingEnabled = true;
            this.cboxDAnStudiu.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboxDAnStudiu.Location = new System.Drawing.Point(87, 107);
            this.cboxDAnStudiu.Name = "cboxDAnStudiu";
            this.cboxDAnStudiu.Size = new System.Drawing.Size(92, 21);
            this.cboxDAnStudiu.TabIndex = 4;
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(10, 60);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(35, 13);
            this.labelNume.TabIndex = 3;
            this.labelNume.Text = "Nume";
            // 
            // txtNumeDisciplina
            // 
            this.txtNumeDisciplina.Location = new System.Drawing.Point(10, 76);
            this.txtNumeDisciplina.Name = "txtNumeDisciplina";
            this.txtNumeDisciplina.Size = new System.Drawing.Size(169, 20);
            this.txtNumeDisciplina.TabIndex = 2;
            // 
            // labelAnStudiu
            // 
            this.labelAnStudiu.AutoSize = true;
            this.labelAnStudiu.Location = new System.Drawing.Point(10, 110);
            this.labelAnStudiu.Name = "labelAnStudiu";
            this.labelAnStudiu.Size = new System.Drawing.Size(74, 13);
            this.labelAnStudiu.TabIndex = 1;
            this.labelAnStudiu.Text = "Anul de studiu";
            // 
            // btnSaveDisciplina
            // 
            this.btnSaveDisciplina.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveDisciplina.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveDisciplina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnSaveDisciplina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDisciplina.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSaveDisciplina.Location = new System.Drawing.Point(10, 404);
            this.btnSaveDisciplina.Name = "btnSaveDisciplina";
            this.btnSaveDisciplina.Size = new System.Drawing.Size(170, 23);
            this.btnSaveDisciplina.TabIndex = 23;
            this.btnSaveDisciplina.Text = "Salveaza";
            this.btnSaveDisciplina.UseVisualStyleBackColor = false;
            // 
            // btnDeleteDisciplina
            // 
            this.btnDeleteDisciplina.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeleteDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDisciplina.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDeleteDisciplina.Location = new System.Drawing.Point(97, 375);
            this.btnDeleteDisciplina.Name = "btnDeleteDisciplina";
            this.btnDeleteDisciplina.Size = new System.Drawing.Size(82, 23);
            this.btnDeleteDisciplina.TabIndex = 22;
            this.btnDeleteDisciplina.Text = "Sterge";
            this.btnDeleteDisciplina.UseVisualStyleBackColor = false;
            // 
            // btnCancelDisciplina
            // 
            this.btnCancelDisciplina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDisciplina.Location = new System.Drawing.Point(10, 375);
            this.btnCancelDisciplina.Name = "btnCancelDisciplina";
            this.btnCancelDisciplina.Size = new System.Drawing.Size(82, 23);
            this.btnCancelDisciplina.TabIndex = 21;
            this.btnCancelDisciplina.Text = "Anuleaza";
            this.btnCancelDisciplina.UseVisualStyleBackColor = true;
            // 
            // FormDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.moduleDiscplinaContainer);
            this.Name = "FormDisciplina";
            this.Size = new System.Drawing.Size(185, 440);
            this.moduleDiscplinaContainer.ResumeLayout(false);
            this.moduleDiscplinaContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel moduleDiscplinaContainer;
        private System.Windows.Forms.TextBox txtNumeScurt;
        private System.Windows.Forms.Label labelNumeScurt;
        private System.Windows.Forms.TextBox txtSemestru;
        private System.Windows.Forms.Label labelSemestru;
        private System.Windows.Forms.TextBox txtIdDisciplina;
        private System.Windows.Forms.Label labelIndentificator;
        private System.Windows.Forms.ComboBox cboxDAnStudiu;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.TextBox txtNumeDisciplina;
        private System.Windows.Forms.Label labelAnStudiu;
        private System.Windows.Forms.Button btnSaveDisciplina;
        private System.Windows.Forms.Button btnDeleteDisciplina;
        private System.Windows.Forms.Button btnCancelDisciplina;
    }
}
