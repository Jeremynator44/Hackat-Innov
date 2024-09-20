namespace ApplicationC
{
    partial class Authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            txtIdentifiant = new TextBox();
            txtPassword = new TextBox();
            btnAuthentification = new Button();
            lblAuthentification = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.Location = new Point(78, 205);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.PlaceholderText = "Identifiant";
            txtIdentifiant.Size = new Size(212, 23);
            txtIdentifiant.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(78, 254);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Mot de Passe";
            txtPassword.Size = new Size(212, 23);
            txtPassword.TabIndex = 4;
            txtPassword.TabStop = false;
            // 
            // btnAuthentification
            // 
            btnAuthentification.Location = new Point(149, 300);
            btnAuthentification.Name = "btnAuthentification";
            btnAuthentification.Size = new Size(75, 23);
            btnAuthentification.TabIndex = 5;
            btnAuthentification.TabStop = false;
            btnAuthentification.Text = "Valider";
            btnAuthentification.UseVisualStyleBackColor = true;
            btnAuthentification.Click += btnAuthentification_Click;
            // 
            // lblAuthentification
            // 
            lblAuthentification.AutoSize = true;
            lblAuthentification.BackColor = Color.Silver;
            lblAuthentification.Font = new Font("Segoe UI", 30F);
            lblAuthentification.ForeColor = Color.Black;
            lblAuthentification.Location = new Point(78, 115);
            lblAuthentification.Name = "lblAuthentification";
            lblAuthentification.Size = new Size(212, 54);
            lblAuthentification.TabIndex = 6;
            lblAuthentification.Text = "Connexion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(149, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Authentification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(369, 363);
            Controls.Add(lblAuthentification);
            Controls.Add(btnAuthentification);
            Controls.Add(txtPassword);
            Controls.Add(txtIdentifiant);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Authentification";
            Text = "Authentification";
            Load += Authentification_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdentifiant;
        private TextBox txtPassword;
        private Button btnAuthentification;
        private Label lblAuthentification;
        private PictureBox pictureBox1;
    }
}