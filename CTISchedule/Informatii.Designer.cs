﻿namespace CTISchedule
{
    partial class Informatii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Informatii));
            this.tabInformatii = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.helpImport1 = new CTISchedule.HelpImport();
            this.helpExport1 = new CTISchedule.HelpExport();
            this.tabInformatii.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInformatii
            // 
            this.tabInformatii.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabInformatii.Controls.Add(this.tabPage1);
            this.tabInformatii.Controls.Add(this.tabPage2);
            this.tabInformatii.Controls.Add(this.tabPage3);
            this.tabInformatii.Controls.Add(this.tabPage4);
            this.tabInformatii.Controls.Add(this.tabPage5);
            this.tabInformatii.Controls.Add(this.tabPage6);
            this.tabInformatii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInformatii.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabInformatii.ItemSize = new System.Drawing.Size(30, 80);
            this.tabInformatii.Location = new System.Drawing.Point(0, 0);
            this.tabInformatii.Multiline = true;
            this.tabInformatii.Name = "tabInformatii";
            this.tabInformatii.SelectedIndex = 0;
            this.tabInformatii.Size = new System.Drawing.Size(604, 441);
            this.tabInformatii.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabInformatii.TabIndex = 0;
            this.tabInformatii.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabInformatii_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(84, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(516, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Intro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(510, 427);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(84, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 253);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Orar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(84, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(396, 253);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modul";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(84, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(396, 253);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "CRUD";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.helpExport1);
            this.tabPage6.Location = new System.Drawing.Point(84, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(516, 433);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Export";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.helpImport1);
            this.tabPage5.Location = new System.Drawing.Point(84, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(516, 433);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Import";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // helpImport1
            // 
            this.helpImport1.AutoScroll = true;
            this.helpImport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpImport1.Location = new System.Drawing.Point(3, 3);
            this.helpImport1.Name = "helpImport1";
            this.helpImport1.Size = new System.Drawing.Size(510, 427);
            this.helpImport1.TabIndex = 0;
            // 
            // helpExport1
            // 
            this.helpExport1.AutoScroll = true;
            this.helpExport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpExport1.Location = new System.Drawing.Point(3, 3);
            this.helpExport1.Name = "helpExport1";
            this.helpExport1.Size = new System.Drawing.Size(510, 427);
            this.helpExport1.TabIndex = 0;
            // 
            // Informatii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 441);
            this.Controls.Add(this.tabInformatii);
            this.Name = "Informatii";
            this.Text = "Informatii";
            this.tabInformatii.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInformatii;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage5;
        private HelpImport helpImport1;
        private HelpExport helpExport1;
    }
}