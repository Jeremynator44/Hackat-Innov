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
            hACKATHONToolStripMenuItem = new ToolStripMenuItem();
            listeDesHackathonsToolStripMenuItem = new ToolStripMenuItem();
            gestionDesHackathonsToolStripMenuItem = new ToolStripMenuItem();
            modificationToolStripMenuItem = new ToolStripMenuItem();
            archivageToolStripMenuItem = new ToolStripMenuItem();
            eQUIPEToolStripMenuItem = new ToolStripMenuItem();
            listeMembreToolStripMenuItem = new ToolStripMenuItem();
            listeEquipesToolStripMenuItem = new ToolStripMenuItem();
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
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { hACKATHONToolStripMenuItem, eQUIPEToolStripMenuItem, SeDeconnecterToolStripMenuItem, QUITTERToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Padding = new Padding(8, 3, 0, 3);
            menuStripPrincipal.Size = new Size(1067, 30);
            menuStripPrincipal.TabIndex = 0;
            menuStripPrincipal.Text = "menuStrip1";
            menuStripPrincipal.ItemClicked += menuStripPrincipal_ItemClicked;
            // 
            // hACKATHONToolStripMenuItem
            // 
            hACKATHONToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesHackathonsToolStripMenuItem, gestionDesHackathonsToolStripMenuItem, modificationToolStripMenuItem, archivageToolStripMenuItem });
            hACKATHONToolStripMenuItem.Name = "hACKATHONToolStripMenuItem";
            hACKATHONToolStripMenuItem.Size = new Size(112, 24);
            hACKATHONToolStripMenuItem.Text = "HACKATHON";
            // 
            // listeDesHackathonsToolStripMenuItem
            // 
            listeDesHackathonsToolStripMenuItem.Name = "listeDesHackathonsToolStripMenuItem";
            listeDesHackathonsToolStripMenuItem.Size = new Size(200, 26);
            listeDesHackathonsToolStripMenuItem.Text = "Liste hackathons";
            listeDesHackathonsToolStripMenuItem.Click += ListeDesHackathonsToolStripMenuItem_Click;
            // 
            // gestionDesHackathonsToolStripMenuItem
            // 
            gestionDesHackathonsToolStripMenuItem.Name = "gestionDesHackathonsToolStripMenuItem";
            gestionDesHackathonsToolStripMenuItem.Size = new Size(200, 26);
            gestionDesHackathonsToolStripMenuItem.Text = "Ajouter";
            gestionDesHackathonsToolStripMenuItem.Click += GestionDesHackathonsToolStripMenuItem_Click;
            // 
            // modificationToolStripMenuItem
            // 
            modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            modificationToolStripMenuItem.Size = new Size(200, 26);
            modificationToolStripMenuItem.Text = "Modifier";
            modificationToolStripMenuItem.Click += ModificationToolStripMenuItem_Click;
            // 
            // archivageToolStripMenuItem
            // 
            archivageToolStripMenuItem.Name = "archivageToolStripMenuItem";
            archivageToolStripMenuItem.Size = new Size(200, 26);
            archivageToolStripMenuItem.Text = "Archiver";
            archivageToolStripMenuItem.Click += ArchivageToolStripMenuItem_Click;
            // 
            // eQUIPEToolStripMenuItem
            // 
            eQUIPEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeMembreToolStripMenuItem, listeEquipesToolStripMenuItem });
            eQUIPEToolStripMenuItem.Name = "eQUIPEToolStripMenuItem";
            eQUIPEToolStripMenuItem.Size = new Size(72, 24);
            eQUIPEToolStripMenuItem.Text = "EQUIPE";
            // 
            // listeMembreToolStripMenuItem
            // 
            listeMembreToolStripMenuItem.Name = "listeMembreToolStripMenuItem";
            listeMembreToolStripMenuItem.Size = new Size(224, 26);
            listeMembreToolStripMenuItem.Text = "Liste Membres";
            listeMembreToolStripMenuItem.Click += ListeDesMembresToolStripMenuItem_Click;
            // 
            // listeEquipesToolStripMenuItem
            // 
            listeEquipesToolStripMenuItem.Name = "listeEquipesToolStripMenuItem";
            listeEquipesToolStripMenuItem.Size = new Size(224, 26);
            listeEquipesToolStripMenuItem.Text = "Liste Equipes";
            listeEquipesToolStripMenuItem.Click += ListeDesEquipesToolStripMenuItem_Click;
            // 
            // SeDeconnecterToolStripMenuItem
            // 
            SeDeconnecterToolStripMenuItem.Name = "SeDeconnecterToolStripMenuItem";
            SeDeconnecterToolStripMenuItem.Size = new Size(146, 24);
            SeDeconnecterToolStripMenuItem.Text = "SE DECONNECTER";
            SeDeconnecterToolStripMenuItem.Click += SeDeconnecterToolStripMenuItem_Click;
            // 
            // QUITTERToolStripMenuItem
            // 
            QUITTERToolStripMenuItem.Name = "QUITTERToolStripMenuItem";
            QUITTERToolStripMenuItem.Size = new Size(81, 24);
            QUITTERToolStripMenuItem.Text = "QUITTER";
            QUITTERToolStripMenuItem.Click += QUITTERToolStripMenuItem_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FloralWhite;
            panelPrincipal.BackgroundImageLayout = ImageLayout.Center;
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Location = new Point(0, 43);
            panelPrincipal.Margin = new Padding(5);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1067, 651);
            panelPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1047, 645);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            ControlBox = false;
            Controls.Add(panelPrincipal);
            Controls.Add(menuStripPrincipal);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripPrincipal;
            Margin = new Padding(5);
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
        private System.Windows.Forms.ToolStripMenuItem hACKATHONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQUIPEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SeDeconnecterToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ToolStripMenuItem QUITTERToolStripMenuItem;
        private ToolStripMenuItem archivageToolStripMenuItem;
        private ToolStripMenuItem listeMembreToolStripMenuItem;
        private ToolStripMenuItem listeEquipesToolStripMenuItem;
    }
}