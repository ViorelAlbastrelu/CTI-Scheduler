namespace CTISchedule
{
    partial class Import
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtImportPath = new System.Windows.Forms.TextBox();
            this.btnSaveImport = new System.Windows.Forms.Button();
            this.txtStatusImport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(193, 34);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Rasfoieste";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtImportPath
            // 
            this.txtImportPath.Location = new System.Drawing.Point(12, 34);
            this.txtImportPath.Name = "txtImportPath";
            this.txtImportPath.Size = new System.Drawing.Size(175, 20);
            this.txtImportPath.TabIndex = 1;
            // 
            // btnSaveImport
            // 
            this.btnSaveImport.Location = new System.Drawing.Point(12, 60);
            this.btnSaveImport.Name = "btnSaveImport";
            this.btnSaveImport.Size = new System.Drawing.Size(256, 23);
            this.btnSaveImport.TabIndex = 2;
            this.btnSaveImport.Text = "Salveaza";
            this.btnSaveImport.UseVisualStyleBackColor = true;
            this.btnSaveImport.Click += new System.EventHandler(this.btnSaveImport_Click);
            // 
            // txtStatusImport
            // 
            this.txtStatusImport.Location = new System.Drawing.Point(12, 89);
            this.txtStatusImport.Multiline = true;
            this.txtStatusImport.Name = "txtStatusImport";
            this.txtStatusImport.ReadOnly = true;
            this.txtStatusImport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusImport.Size = new System.Drawing.Size(254, 239);
            this.txtStatusImport.TabIndex = 3;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 340);
            this.Controls.Add(this.txtStatusImport);
            this.Controls.Add(this.btnSaveImport);
            this.Controls.Add(this.txtImportPath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Import";
            this.Text = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtImportPath;
        private System.Windows.Forms.Button btnSaveImport;
        private System.Windows.Forms.TextBox txtStatusImport;
    }
}