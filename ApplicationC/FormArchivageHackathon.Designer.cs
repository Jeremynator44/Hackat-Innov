namespace ApplicationC
{
    partial class FormArchivageHackathon
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
            components = new System.ComponentModel.Container();
            dgvArchivageListeHackatons = new DataGridView();
            bsArchivageHackathon = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvArchivageListeHackatons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsArchivageHackathon).BeginInit();
            SuspendLayout();
            // 
            // dgvArchivageListeHackatons
            // 
            dgvArchivageListeHackatons.AllowUserToAddRows = false;
            dgvArchivageListeHackatons.AllowUserToDeleteRows = false;
            dgvArchivageListeHackatons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchivageListeHackatons.Location = new Point(28, 150);
            dgvArchivageListeHackatons.Name = "dgvArchivageListeHackatons";
            dgvArchivageListeHackatons.ReadOnly = true;
            dgvArchivageListeHackatons.RowHeadersWidth = 51;
            dgvArchivageListeHackatons.Size = new Size(679, 370);
            dgvArchivageListeHackatons.TabIndex = 0;
            // 
            // FormArchivageHackathon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1016, 556);
            Controls.Add(dgvArchivageListeHackatons);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormArchivageHackathon";
            Text = "ArchivageHackathon";
            Load += this.FormArchivageHackathon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArchivageListeHackatons).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsArchivageHackathon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArchivageListeHackatons;
        private BindingSource bsArchivageHackathon;
    }
}