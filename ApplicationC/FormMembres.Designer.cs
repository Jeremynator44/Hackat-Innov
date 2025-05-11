namespace ApplicationC
{
    partial class FormMembres
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
            dgvMembre = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SupprimerMembreToolStripMenuItem = new ToolStripMenuItem();
            bsMembre = new BindingSource(components);
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMembre).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsMembre).BeginInit();
            SuspendLayout();
            // 
            // dgvMembre
            // 
            dgvMembre.AllowUserToAddRows = false;
            dgvMembre.AllowUserToDeleteRows = false;
            dgvMembre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMembre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembre.ContextMenuStrip = contextMenuStrip1;
            dgvMembre.Location = new Point(46, 58);
            dgvMembre.Margin = new Padding(4);
            dgvMembre.MultiSelect = false;
            dgvMembre.Name = "dgvMembre";
            dgvMembre.ReadOnly = true;
            dgvMembre.RowHeadersWidth = 51;
            dgvMembre.Size = new Size(823, 328);
            dgvMembre.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { SupprimerMembreToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(130, 26);
            // 
            // SupprimerMembreToolStripMenuItem
            // 
            SupprimerMembreToolStripMenuItem.Name = "SupprimerMembreToolStripMenuItem";
            SupprimerMembreToolStripMenuItem.Size = new Size(129, 22);
            SupprimerMembreToolStripMenuItem.Text = "Supprimer";
            SupprimerMembreToolStripMenuItem.Click += SupprimerMembreToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(46, 403);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(435, 20);
            label2.TabIndex = 9;
            label2.Text = "click droit sur le membre sélectionné pour plus d'informations";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 24);
            label1.TabIndex = 10;
            label1.Text = "Liste des Membres";
            // 
            // FormMembres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(905, 452);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(dgvMembre);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormMembres";
            Text = "FormMembres";
            Load += FormMembres_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembre).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsMembre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMembre;
        private BindingSource bsMembre;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem SupprimerMembreToolStripMenuItem;
        private Label label2;
        private Label label1;
    }
}