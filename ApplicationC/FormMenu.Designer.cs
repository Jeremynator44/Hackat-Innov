namespace ApplicationC
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            menuStripPrincipal = new MenuStrip();
            HackathonToolStripMenuItem = new ToolStripMenuItem();
            ListeDesHackathonsToolStripMenuItem = new ToolStripMenuItem();
            AjoutHackatonsToolStripMenuItem = new ToolStripMenuItem();
            ModifierHackathonsToolStripMenuItem = new ToolStripMenuItem();
            ArchiverHackathonsToolStripMenuItem = new ToolStripMenuItem();
            EquipeToolStripMenuItem = new ToolStripMenuItem();
            ListeDesEquipesToolStripMenuItem = new ToolStripMenuItem();
            AjouterEquipesToolStripMenuItem = new ToolStripMenuItem();
            ModifierEquipesToolStripMenuItem = new ToolStripMenuItem();
            MembreToolStripMenuItem = new ToolStripMenuItem();
            ListeDesMembresToolStripMenuItem = new ToolStripMenuItem();
            AjouterMembresToolStripMenuItem = new ToolStripMenuItem();
            ModifierMembresToolStripMenuItem = new ToolStripMenuItem();
            sécuritéToolStripMenuItem = new ToolStripMenuItem();
            activerToolStripMenuItem = new ToolStripMenuItem();
            désactiverToolStripMenuItem = new ToolStripMenuItem();
            ListeDésactivationToolStripMenuItem = new ToolStripMenuItem();
            SeDeconnecterToolStripMenuItem = new ToolStripMenuItem();
            QUITTERToolStripMenuItem = new ToolStripMenuItem();
            panelPrincipal = new Panel();
            pictureBox1 = new PictureBox();
            menuStripPrincipal.SuspendLayout();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            menuStripPrincipal.ImageScalingSize = new Size(20, 20);
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { HackathonToolStripMenuItem, EquipeToolStripMenuItem, MembreToolStripMenuItem, sécuritéToolStripMenuItem, SeDeconnecterToolStripMenuItem, QUITTERToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Padding = new Padding(7, 2, 0, 2);
            menuStripPrincipal.Size = new Size(906, 24);
            menuStripPrincipal.TabIndex = 0;
            menuStripPrincipal.Text = "menuStrip1";
            menuStripPrincipal.ItemClicked += menuStripPrincipal_ItemClicked;
            // 
            // HackathonToolStripMenuItem
            // 
            HackathonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ListeDesHackathonsToolStripMenuItem, AjoutHackatonsToolStripMenuItem, ModifierHackathonsToolStripMenuItem, ArchiverHackathonsToolStripMenuItem });
            HackathonToolStripMenuItem.Name = "HackathonToolStripMenuItem";
            HackathonToolStripMenuItem.Size = new Size(91, 20);
            HackathonToolStripMenuItem.Text = "HACKATHON";
            // 
            // ListeDesHackathonsToolStripMenuItem
            // 
            ListeDesHackathonsToolStripMenuItem.Name = "ListeDesHackathonsToolStripMenuItem";
            ListeDesHackathonsToolStripMenuItem.Size = new Size(164, 22);
            ListeDesHackathonsToolStripMenuItem.Text = "Liste Hackathons";
            ListeDesHackathonsToolStripMenuItem.Click += ListeDesHackathonsToolStripMenuItem_Click;
            // 
            // AjoutHackatonsToolStripMenuItem
            // 
            AjoutHackatonsToolStripMenuItem.Name = "AjoutHackatonsToolStripMenuItem";
            AjoutHackatonsToolStripMenuItem.Size = new Size(164, 22);
            AjoutHackatonsToolStripMenuItem.Text = "Ajouter";
            AjoutHackatonsToolStripMenuItem.Click += AjouterHackathonsToolStripMenuItem_Click;
            // 
            // ModifierHackathonsToolStripMenuItem
            // 
            ModifierHackathonsToolStripMenuItem.Name = "ModifierHackathonsToolStripMenuItem";
            ModifierHackathonsToolStripMenuItem.Size = new Size(164, 22);
            ModifierHackathonsToolStripMenuItem.Text = "Modifier";
            ModifierHackathonsToolStripMenuItem.Click += ModifierHackathonsToolStripMenuItem_Click;
            // 
            // ArchiverHackathonsToolStripMenuItem
            // 
            ArchiverHackathonsToolStripMenuItem.Name = "ArchiverHackathonsToolStripMenuItem";
            ArchiverHackathonsToolStripMenuItem.Size = new Size(164, 22);
            ArchiverHackathonsToolStripMenuItem.Text = "Archiver";
            ArchiverHackathonsToolStripMenuItem.Click += ArchiverHackathonsToolStripMenuItem_Click;
            // 
            // EquipeToolStripMenuItem
            // 
            EquipeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ListeDesEquipesToolStripMenuItem, AjouterEquipesToolStripMenuItem, ModifierEquipesToolStripMenuItem });
            EquipeToolStripMenuItem.Name = "EquipeToolStripMenuItem";
            EquipeToolStripMenuItem.Size = new Size(58, 20);
            EquipeToolStripMenuItem.Text = "EQUIPE";
            // 
            // ListeDesEquipesToolStripMenuItem
            // 
            ListeDesEquipesToolStripMenuItem.Name = "ListeDesEquipesToolStripMenuItem";
            ListeDesEquipesToolStripMenuItem.Size = new Size(180, 22);
            ListeDesEquipesToolStripMenuItem.Text = "Liste Equipes";
            ListeDesEquipesToolStripMenuItem.Click += ListeDesEquipesToolStripMenuItem_Click;
            // 
            // AjouterEquipesToolStripMenuItem
            // 
            AjouterEquipesToolStripMenuItem.Name = "AjouterEquipesToolStripMenuItem";
            AjouterEquipesToolStripMenuItem.Size = new Size(180, 22);
            AjouterEquipesToolStripMenuItem.Text = "Ajouter";
            AjouterEquipesToolStripMenuItem.Click += AjouterEquipesToolStripMenuItem_Click;
            // 
            // ModifierEquipesToolStripMenuItem
            // 
            ModifierEquipesToolStripMenuItem.Name = "ModifierEquipesToolStripMenuItem";
            ModifierEquipesToolStripMenuItem.Size = new Size(180, 22);
            ModifierEquipesToolStripMenuItem.Text = "Modifier";
            ModifierEquipesToolStripMenuItem.Click += ModifierEquipesToolStripMenuItem_Click;
            // 
            // MembreToolStripMenuItem
            // 
            MembreToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ListeDesMembresToolStripMenuItem, AjouterMembresToolStripMenuItem, ModifierMembresToolStripMenuItem });
            MembreToolStripMenuItem.Name = "MembreToolStripMenuItem";
            MembreToolStripMenuItem.Size = new Size(67, 20);
            MembreToolStripMenuItem.Text = "MEMBRE";
            // 
            // ListeDesMembresToolStripMenuItem
            // 
            ListeDesMembresToolStripMenuItem.Name = "ListeDesMembresToolStripMenuItem";
            ListeDesMembresToolStripMenuItem.Size = new Size(151, 22);
            ListeDesMembresToolStripMenuItem.Text = "Liste Membres";
            ListeDesMembresToolStripMenuItem.Click += ListeDesMembresToolStripMenuItem_Click;
            // 
            // AjouterMembresToolStripMenuItem
            // 
            AjouterMembresToolStripMenuItem.Name = "AjouterMembresToolStripMenuItem";
            AjouterMembresToolStripMenuItem.Size = new Size(151, 22);
            AjouterMembresToolStripMenuItem.Text = "Ajouter";
            AjouterMembresToolStripMenuItem.Click += AjouterMembresToolStripMenuItem_Click;
            // 
            // ModifierMembresToolStripMenuItem
            // 
            ModifierMembresToolStripMenuItem.Name = "ModifierMembresToolStripMenuItem";
            ModifierMembresToolStripMenuItem.Size = new Size(151, 22);
            ModifierMembresToolStripMenuItem.Text = "Modifier";
            ModifierMembresToolStripMenuItem.Click += ModifierMembresToolStripMenuItem_Click;
            // 
            // sécuritéToolStripMenuItem
            // 
            sécuritéToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { activerToolStripMenuItem, désactiverToolStripMenuItem, ListeDésactivationToolStripMenuItem });
            sécuritéToolStripMenuItem.Name = "sécuritéToolStripMenuItem";
            sécuritéToolStripMenuItem.Size = new Size(172, 20);
            sécuritéToolStripMenuItem.Text = "DOUBLE AUTHENTIFICATION";
            // 
            // activerToolStripMenuItem
            // 
            activerToolStripMenuItem.Name = "activerToolStripMenuItem";
            activerToolStripMenuItem.Size = new Size(172, 22);
            activerToolStripMenuItem.Text = "Activer";
            activerToolStripMenuItem.Click += activerToolStripMenuItem_Click;
            // 
            // désactiverToolStripMenuItem
            // 
            désactiverToolStripMenuItem.Name = "désactiverToolStripMenuItem";
            désactiverToolStripMenuItem.Size = new Size(172, 22);
            désactiverToolStripMenuItem.Text = "Désactiver";
            désactiverToolStripMenuItem.Click += désactiverToolStripMenuItem_Click;
            // 
            // ListeDésactivationToolStripMenuItem
            // 
            ListeDésactivationToolStripMenuItem.Name = "ListeDésactivationToolStripMenuItem";
            ListeDésactivationToolStripMenuItem.Size = new Size(172, 22);
            ListeDésactivationToolStripMenuItem.Text = "Liste Désactivation";
            // 
            // SeDeconnecterToolStripMenuItem
            // 
            SeDeconnecterToolStripMenuItem.Name = "SeDeconnecterToolStripMenuItem";
            SeDeconnecterToolStripMenuItem.Size = new Size(116, 20);
            SeDeconnecterToolStripMenuItem.Text = "SE DECONNECTER";
            SeDeconnecterToolStripMenuItem.Click += SeDeconnecterToolStripMenuItem_Click;
            // 
            // QUITTERToolStripMenuItem
            // 
            QUITTERToolStripMenuItem.Name = "QUITTERToolStripMenuItem";
            QUITTERToolStripMenuItem.Size = new Size(64, 20);
            QUITTERToolStripMenuItem.Text = "QUITTER";
            QUITTERToolStripMenuItem.Click += QUITTERToolStripMenuItem_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FloralWhite;
            panelPrincipal.BackgroundImageLayout = ImageLayout.Center;
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Location = new Point(0, 32);
            panelPrincipal.Margin = new Padding(4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(905, 452);
            panelPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(905, 452);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 484);
            Controls.Add(panelPrincipal);
            Controls.Add(menuStripPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripPrincipal;
            Margin = new Padding(4);
            Name = "FormMenu";
            Text = "HACKAT'INNOV";
            Load += FormMenu_Load;
            menuStripPrincipal.ResumeLayout(false);
            menuStripPrincipal.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem HackathonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListeDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjoutHackatonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EquipeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SeDeconnecterToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem ModifierHackathonsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem QUITTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArchiverHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListeDesEquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sécuritéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListeDésactivationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem désactiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MembreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListeDesMembresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjouterMembresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifierMembresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AjouterEquipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifierEquipesToolStripMenuItem;
    }
}