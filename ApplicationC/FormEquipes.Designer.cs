namespace ApplicationC
{
    partial class FormEquipes
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
            bsEquipe = new BindingSource(components);
            dgvEquipe = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            VoirLesMembresToolStripMenuItem = new ToolStripMenuItem();
            SupprimerEquipeToolStripMenuItem = new ToolStripMenuItem();
            DésinscrireEquipeToolStripMenuItem = new ToolStripMenuItem();
            dgvMembres = new DataGridView();
            bsMembre = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            cbTriHackathon = new ComboBox();
            BSListeH = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipe).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMembre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSListeH).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipe
            // 
            dgvEquipe.AllowUserToAddRows = false;
            dgvEquipe.AllowUserToDeleteRows = false;
            dgvEquipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEquipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipe.ContextMenuStrip = contextMenuStrip1;
            dgvEquipe.Location = new Point(46, 76);
            dgvEquipe.Margin = new Padding(4);
            dgvEquipe.MultiSelect = false;
            dgvEquipe.Name = "dgvEquipe";
            dgvEquipe.ReadOnly = true;
            dgvEquipe.RowHeadersWidth = 51;
            dgvEquipe.Size = new Size(655, 293);
            dgvEquipe.TabIndex = 2;
            dgvEquipe.CellClick += DgvEquipe_CellContentClick;
            dgvEquipe.CellContentClick += DgvEquipe_CellContentClick;
            dgvEquipe.CellMouseClick += DgvEquipe_CellMouseClick;
            dgvEquipe.Click += DgvEquipe_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { VoirLesMembresToolStripMenuItem, SupprimerEquipeToolStripMenuItem, DésinscrireEquipeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(165, 70);
            // 
            // VoirLesMembresToolStripMenuItem
            // 
            VoirLesMembresToolStripMenuItem.Name = "VoirLesMembresToolStripMenuItem";
            VoirLesMembresToolStripMenuItem.Size = new Size(164, 22);
            VoirLesMembresToolStripMenuItem.Text = "Voir les membres";
            VoirLesMembresToolStripMenuItem.Click += VoirLesMembresToolStripMenuItem_Click;
            // 
            // SupprimerEquipeToolStripMenuItem
            // 
            SupprimerEquipeToolStripMenuItem.Name = "SupprimerEquipeToolStripMenuItem";
            SupprimerEquipeToolStripMenuItem.Size = new Size(164, 22);
            SupprimerEquipeToolStripMenuItem.Text = "Supprimer";
            SupprimerEquipeToolStripMenuItem.Click += SupprimerEquipeToolStripMenuItem_Click;
            // 
            // DésinscrireEquipeToolStripMenuItem
            // 
            DésinscrireEquipeToolStripMenuItem.Name = "DésinscrireEquipeToolStripMenuItem";
            DésinscrireEquipeToolStripMenuItem.Size = new Size(164, 22);
            DésinscrireEquipeToolStripMenuItem.Text = "Désinscrire";
            DésinscrireEquipeToolStripMenuItem.Click += DésinscrireEquipeToolStripMenuItem_Click;
            // 
            // dgvMembres
            // 
            dgvMembres.AllowUserToAddRows = false;
            dgvMembres.AllowUserToDeleteRows = false;
            dgvMembres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembres.Location = new Point(296, 233);
            dgvMembres.Margin = new Padding(4);
            dgvMembres.Name = "dgvMembres";
            dgvMembres.ReadOnly = true;
            dgvMembres.RowHeadersWidth = 51;
            dgvMembres.Size = new Size(405, 136);
            dgvMembres.TabIndex = 6;
            dgvMembres.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 24);
            label1.TabIndex = 7;
            label1.Text = "Liste des Equipes Inscrites";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(46, 386);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(424, 20);
            label2.TabIndex = 8;
            label2.Text = "click droit sur l'équipe sélectionnée pour plus d'informations";
            // 
            // cbTriHackathon
            // 
            cbTriHackathon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTriHackathon.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTriHackathon.FormattingEnabled = true;
            cbTriHackathon.Location = new Point(709, 76);
            cbTriHackathon.Margin = new Padding(4, 3, 4, 3);
            cbTriHackathon.Name = "cbTriHackathon";
            cbTriHackathon.Size = new Size(183, 24);
            cbTriHackathon.TabIndex = 28;
            cbTriHackathon.SelectedIndexChanged += cbTriHackathon_SelectedIndexChanged;
            // 
            // BSListeH
            // 
            BSListeH.CurrentChanged += BSListeH_CurrentChanged;
            // 
            // FormEquipes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(905, 452);
            Controls.Add(cbTriHackathon);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMembres);
            Controls.Add(dgvEquipe);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEquipes";
            Text = "FormEquipes";
            Load += FormEquipes_Load;
            ((System.ComponentModel.ISupportInitialize)bsEquipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipe).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembres).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMembre).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSListeH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.BindingSource bsEquipe;
        private System.Windows.Forms.DataGridView dgvEquipe;
        private System.Windows.Forms.DataGridView dgvMembres;
        private System.Windows.Forms.BindingSource bsMembre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem VoirLesMembresToolStripMenuItem;
        private Label label1;
        private Label label2;
        private ComboBox cbTriHackathon;
        private BindingSource BSListeH;
        private ToolStripMenuItem SupprimerEquipeToolStripMenuItem;
        private ToolStripMenuItem DésinscrireEquipeToolStripMenuItem;
    }
}