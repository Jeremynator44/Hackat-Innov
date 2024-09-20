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
            eQUIPEToolStripMenuItem = new ToolStripMenuItem();
            qUITTERToolStripMenuItem = new ToolStripMenuItem();
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
            menuStripPrincipal.Items.AddRange(new ToolStripItem[] { hACKATHONToolStripMenuItem, eQUIPEToolStripMenuItem, qUITTERToolStripMenuItem });
            menuStripPrincipal.Location = new Point(0, 0);
            menuStripPrincipal.Name = "menuStripPrincipal";
            menuStripPrincipal.Padding = new Padding(7, 2, 0, 2);
            menuStripPrincipal.Size = new Size(934, 24);
            menuStripPrincipal.TabIndex = 0;
            menuStripPrincipal.Text = "menuStrip1";
            menuStripPrincipal.ItemClicked += menuStripPrincipal_ItemClicked;
            // 
            // hACKATHONToolStripMenuItem
            // 
            hACKATHONToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeDesHackathonsToolStripMenuItem, gestionDesHackathonsToolStripMenuItem, modificationToolStripMenuItem });
            hACKATHONToolStripMenuItem.Name = "hACKATHONToolStripMenuItem";
            hACKATHONToolStripMenuItem.Size = new Size(91, 20);
            hACKATHONToolStripMenuItem.Text = "HACKATHON";
            // 
            // listeDesHackathonsToolStripMenuItem
            // 
            listeDesHackathonsToolStripMenuItem.Name = "listeDesHackathonsToolStripMenuItem";
            listeDesHackathonsToolStripMenuItem.Size = new Size(189, 22);
            listeDesHackathonsToolStripMenuItem.Text = "Liste des hackathons";
            listeDesHackathonsToolStripMenuItem.Click += ListeDesHackathonsToolStripMenuItem_Click;
            // 
            // gestionDesHackathonsToolStripMenuItem
            // 
            gestionDesHackathonsToolStripMenuItem.Name = "gestionDesHackathonsToolStripMenuItem";
            gestionDesHackathonsToolStripMenuItem.Size = new Size(189, 22);
            gestionDesHackathonsToolStripMenuItem.Text = "Ajout d'un hackathon";
            gestionDesHackathonsToolStripMenuItem.Click += GestionDesHackathonsToolStripMenuItem_Click;
            // 
            // modificationToolStripMenuItem
            // 
            modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            modificationToolStripMenuItem.Size = new Size(189, 22);
            modificationToolStripMenuItem.Text = "Modification";
            modificationToolStripMenuItem.Click += ModificationToolStripMenuItem_Click;
            // 
            // eQUIPEToolStripMenuItem
            // 
            eQUIPEToolStripMenuItem.Name = "eQUIPEToolStripMenuItem";
            eQUIPEToolStripMenuItem.Size = new Size(58, 20);
            eQUIPEToolStripMenuItem.Text = "EQUIPE";
            // 
            // qUITTERToolStripMenuItem
            // 
            qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            qUITTERToolStripMenuItem.Size = new Size(64, 20);
            qUITTERToolStripMenuItem.Text = "QUITTER";
            qUITTERToolStripMenuItem.Click += QUITTERToolStripMenuItem_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FloralWhite;
            panelPrincipal.BackgroundImageLayout = ImageLayout.Center;
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Location = new Point(0, 32);
            panelPrincipal.Margin = new Padding(4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(934, 488);
            panelPrincipal.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(916, 484);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 519);
            ControlBox = false;
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
        private System.Windows.Forms.ToolStripMenuItem hACKATHONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesHackathonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eQUIPEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUITTERToolStripMenuItem;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.ToolStripMenuItem modificationToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}