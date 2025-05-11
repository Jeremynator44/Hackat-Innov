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
            btnArchiver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvArchivageListeHackatons).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsArchivageHackathon).BeginInit();
            SuspendLayout();
            // 
            // dgvArchivageListeHackatons
            // 
            dgvArchivageListeHackatons.AllowUserToAddRows = false;
            dgvArchivageListeHackatons.AllowUserToDeleteRows = false;
            dgvArchivageListeHackatons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArchivageListeHackatons.Location = new Point(12, 12);
            dgvArchivageListeHackatons.Name = "dgvArchivageListeHackatons";
            dgvArchivageListeHackatons.ReadOnly = true;
            dgvArchivageListeHackatons.RowHeadersWidth = 51;
            dgvArchivageListeHackatons.Size = new Size(992, 391);
            dgvArchivageListeHackatons.TabIndex = 0;
            // 
            // btnArchiver
            // 
            btnArchiver.Font = new Font("Segoe UI", 10F);
            btnArchiver.Location = new Point(424, 435);
            btnArchiver.Name = "btnArchiver";
            btnArchiver.Size = new Size(155, 36);
            btnArchiver.TabIndex = 1;
            btnArchiver.Text = "Archiver";
            btnArchiver.UseVisualStyleBackColor = true;
            btnArchiver.Click += btnArchiver_Click;
            // 
            // FormArchivageHackathon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1034, 603);
            Controls.Add(btnArchiver);
            Controls.Add(dgvArchivageListeHackatons);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormArchivageHackathon";
            Text = "ArchivageHackathon";
            Load += FormArchivageHackathon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArchivageListeHackatons).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsArchivageHackathon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvArchivageListeHackatons;
        private BindingSource bsArchivageHackathon;
        private Button btnArchiver;
    }
}