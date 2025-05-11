namespace ApplicationC
{
    partial class FormHackathon
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvHackathon = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            voirLesÉquipesToolStripMenuItem = new ToolStripMenuItem();
            BtnFermer = new Button();
            label1 = new Label();
            label2 = new Label();
            BSHackathon = new BindingSource(components);
            BSEquipe = new BindingSource(components);
            dgvEquipes = new DataGridView();
            cbTriHackathonThématique = new ComboBox();
            cbTriHackathonDate = new ComboBox();
            cbTriHackathonVille = new ComboBox();
            lblThématique = new Label();
            lblDate = new Label();
            lblVille = new Label();
            BSFiltreDate = new BindingSource(components);
            BSFiltreVille = new BindingSource(components);
            BSFiltreThematique = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvHackathon).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSHackathon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSFiltreDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSFiltreVille).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSFiltreThematique).BeginInit();
            SuspendLayout();
            // 
            // dgvHackathon
            // 
            dgvHackathon.AllowUserToAddRows = false;
            dgvHackathon.AllowUserToDeleteRows = false;
            dgvHackathon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvHackathon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHackathon.ContextMenuStrip = contextMenuStrip1;
            dgvHackathon.Location = new Point(55, 71);
            dgvHackathon.Margin = new Padding(5);
            dgvHackathon.MultiSelect = false;
            dgvHackathon.Name = "dgvHackathon";
            dgvHackathon.ReadOnly = true;
            dgvHackathon.RowHeadersWidth = 51;
            dgvHackathon.Size = new Size(746, 397);
            dgvHackathon.TabIndex = 0;
            dgvHackathon.CellClick += DgvHackathon_CellContentClick;
            dgvHackathon.CellContentClick += DgvHackathon_CellContentClick;
            dgvHackathon.CellMouseClick += DgvHackathon_CellMouseClick;
            dgvHackathon.Click += DgvHackathon_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { voirLesÉquipesToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(183, 28);
            // 
            // voirLesÉquipesToolStripMenuItem
            // 
            voirLesÉquipesToolStripMenuItem.Name = "voirLesÉquipesToolStripMenuItem";
            voirLesÉquipesToolStripMenuItem.Size = new Size(182, 24);
            voirLesÉquipesToolStripMenuItem.Text = "Voir les équipes";
            voirLesÉquipesToolStripMenuItem.Click += VoirLesÉquipesToolStripMenuItem_Click;
            // 
            // BtnFermer
            // 
            BtnFermer.BackColor = Color.Black;
            BtnFermer.FlatStyle = FlatStyle.Popup;
            BtnFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFermer.ForeColor = SystemColors.ControlLightLight;
            BtnFermer.Location = new Point(869, 477);
            BtnFermer.Margin = new Padding(5);
            BtnFermer.Name = "BtnFermer";
            BtnFermer.Size = new Size(127, 77);
            BtnFermer.TabIndex = 1;
            BtnFermer.Text = "FERMER";
            BtnFermer.UseVisualStyleBackColor = false;
            BtnFermer.Click += BtnFermer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 29);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 29);
            label1.TabIndex = 2;
            label1.Text = "Liste des Hackathons";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(49, 499);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(522, 25);
            label2.TabIndex = 4;
            label2.Text = "click droit sur l'hackathon sélectionné pour voir ses équipes";
            // 
            // dgvEquipes
            // 
            dgvEquipes.AllowUserToAddRows = false;
            dgvEquipes.AllowUserToDeleteRows = false;
            dgvEquipes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipes.Location = new Point(503, 312);
            dgvEquipes.Margin = new Padding(5);
            dgvEquipes.Name = "dgvEquipes";
            dgvEquipes.ReadOnly = true;
            dgvEquipes.RowHeadersWidth = 51;
            dgvEquipes.Size = new Size(298, 156);
            dgvEquipes.TabIndex = 5;
            dgvEquipes.Visible = false;
            // 
            // cbTriHackathonThématique
            // 
            cbTriHackathonThématique.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTriHackathonThématique.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTriHackathonThématique.FormattingEnabled = true;
            cbTriHackathonThématique.Location = new Point(810, 92);
            cbTriHackathonThématique.Margin = new Padding(5, 4, 5, 4);
            cbTriHackathonThématique.Name = "cbTriHackathonThématique";
            cbTriHackathonThématique.Size = new Size(209, 28);
            cbTriHackathonThématique.TabIndex = 29;
            cbTriHackathonThématique.SelectedIndexChanged += cbFiltreThematique_SelectedIndexChanged;
            // 
            // cbTriHackathonDate
            // 
            cbTriHackathonDate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTriHackathonDate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTriHackathonDate.FormattingEnabled = true;
            cbTriHackathonDate.Location = new Point(810, 199);
            cbTriHackathonDate.Margin = new Padding(5, 4, 5, 4);
            cbTriHackathonDate.Name = "cbTriHackathonDate";
            cbTriHackathonDate.Size = new Size(209, 28);
            cbTriHackathonDate.TabIndex = 30;
            cbTriHackathonDate.SelectedIndexChanged += cbFiltreDate_SelectedIndexChanged;
            // 
            // cbTriHackathonVille
            // 
            cbTriHackathonVille.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTriHackathonVille.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTriHackathonVille.FormattingEnabled = true;
            cbTriHackathonVille.Location = new Point(810, 312);
            cbTriHackathonVille.Margin = new Padding(5, 4, 5, 4);
            cbTriHackathonVille.Name = "cbTriHackathonVille";
            cbTriHackathonVille.Size = new Size(209, 28);
            cbTriHackathonVille.TabIndex = 31;
            cbTriHackathonVille.SelectedIndexChanged += cbTriHackathonVille_SelectedIndexChanged;
            // 
            // lblThématique
            // 
            lblThématique.AutoSize = true;
            lblThématique.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThématique.Location = new Point(810, 67);
            lblThématique.Margin = new Padding(5, 0, 5, 0);
            lblThématique.Name = "lblThématique";
            lblThématique.Size = new Size(96, 20);
            lblThématique.TabIndex = 32;
            lblThématique.Text = "Thématique";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(810, 173);
            lblDate.Margin = new Padding(5, 0, 5, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(45, 20);
            lblDate.TabIndex = 33;
            lblDate.Text = "Date";
            // 
            // lblVille
            // 
            lblVille.AutoSize = true;
            lblVille.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVille.Location = new Point(810, 287);
            lblVille.Margin = new Padding(5, 0, 5, 0);
            lblVille.Name = "lblVille";
            lblVille.Size = new Size(41, 20);
            lblVille.TabIndex = 34;
            lblVille.Text = "Ville";
            // 
            // BSFiltreDate
            // 
            BSFiltreDate.CurrentChanged += BSFiltreDate_CurrentChanged;
            // 
            // BSFiltreVille
            // 
            BSFiltreVille.CurrentChanged += BSFiltreVille_CurrentChanged;
            // 
            // BSFiltreThematique
            // 
            BSFiltreThematique.CurrentChanged += BSFiltreThematique_CurrentChanged;
            // 
            // FormHackathon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1034, 603);
            Controls.Add(lblVille);
            Controls.Add(lblDate);
            Controls.Add(lblThématique);
            Controls.Add(cbTriHackathonVille);
            Controls.Add(cbTriHackathonDate);
            Controls.Add(cbTriHackathonThématique);
            Controls.Add(dgvEquipes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnFermer);
            Controls.Add(dgvHackathon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "FormHackathon";
            Text = "Gestion des Hackathons";
            Load += FormHackathon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHackathon).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BSHackathon).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSEquipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipes).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSFiltreDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSFiltreVille).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSFiltreThematique).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource BSHackathon;
        private System.Windows.Forms.DataGridView dgvHackathon;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voirLesÉquipesToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource BSEquipe;
        private System.Windows.Forms.DataGridView dgvEquipes;
        private ComboBox cbTriHackathonThématique;
        private ComboBox cbTriHackathonDate;
        private ComboBox cbTriHackathonVille;
        private Label lblThématique;
        private Label lblDate;
        private Label lblVille;
        private BindingSource BSFiltreDate;
        private BindingSource BSFiltreVille;
        private BindingSource BSFiltreThematique;
    }
}

