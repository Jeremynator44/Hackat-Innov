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
            ((System.ComponentModel.ISupportInitialize)dgvHackathon).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSHackathon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipes).BeginInit();
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
            dgvHackathon.Margin = new Padding(4, 5, 4, 5);
            dgvHackathon.MultiSelect = false;
            dgvHackathon.Name = "dgvHackathon";
            dgvHackathon.ReadOnly = true;
            dgvHackathon.RowHeadersWidth = 51;
            dgvHackathon.Size = new Size(941, 397);
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
            BtnFermer.Margin = new Padding(4, 5, 4, 5);
            BtnFermer.Name = "BtnFermer";
            BtnFermer.Size = new Size(127, 78);
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
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(261, 29);
            label1.TabIndex = 2;
            label1.Text = "Liste des Hackathons";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(49, 498);
            label2.Margin = new Padding(4, 0, 4, 0);
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
            dgvEquipes.Location = new Point(698, 311);
            dgvEquipes.Margin = new Padding(4, 5, 4, 5);
            dgvEquipes.Name = "dgvEquipes";
            dgvEquipes.ReadOnly = true;
            dgvEquipes.RowHeadersWidth = 51;
            dgvEquipes.Size = new Size(298, 156);
            dgvEquipes.TabIndex = 5;
            dgvEquipes.Visible = false;
            // 
            // FormHackathon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1045, 591);
            Controls.Add(dgvEquipes);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnFermer);
            Controls.Add(dgvHackathon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormHackathon";
            Text = "Gestion des Hackathons";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHackathon).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BSHackathon).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSEquipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEquipes).EndInit();
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
    }
}

