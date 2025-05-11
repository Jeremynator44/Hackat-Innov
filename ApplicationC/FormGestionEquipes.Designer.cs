namespace ApplicationC
{
    partial class FormGestionEquipes
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
            label1 = new Label();
            BtnFermer = new Button();
            lblNomEquipe = new Label();
            lblEmail = new Label();
            lblLienPrototype = new Label();
            tbNom = new TextBox();
            tbLienPrototype = new TextBox();
            BtnAction = new Button();
            gbInfo = new GroupBox();
            lblIdE = new Label();
            dgvMembres = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            AjouterMembreDansEquipeToolStripMenuItem = new ToolStripMenuItem();
            lblMembre = new Label();
            tbLogin = new TextBox();
            cbListe = new ComboBox();
            BSListeM = new BindingSource(components);
            BSListeE = new BindingSource(components);
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembres).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSListeM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSListeE).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 19);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(230, 29);
            label1.TabIndex = 3;
            label1.Text = "Ajout d'un Membre";
            // 
            // BtnFermer
            // 
            BtnFermer.BackColor = Color.Black;
            BtnFermer.FlatStyle = FlatStyle.Popup;
            BtnFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFermer.ForeColor = SystemColors.ControlLightLight;
            BtnFermer.Location = new Point(817, 535);
            BtnFermer.Margin = new Padding(5, 4, 5, 4);
            BtnFermer.Name = "BtnFermer";
            BtnFermer.Size = new Size(127, 52);
            BtnFermer.TabIndex = 4;
            BtnFermer.Text = "FERMER";
            BtnFermer.UseVisualStyleBackColor = false;
            BtnFermer.Click += BtnFermer_Click;
            // 
            // lblNomEquipe
            // 
            lblNomEquipe.AutoSize = true;
            lblNomEquipe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNomEquipe.Location = new Point(133, 81);
            lblNomEquipe.Margin = new Padding(5, 0, 5, 0);
            lblNomEquipe.Name = "lblNomEquipe";
            lblNomEquipe.Size = new Size(113, 20);
            lblNomEquipe.TabIndex = 10;
            lblNomEquipe.Text = "Nom d'Equipe";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(133, 172);
            lblEmail.Margin = new Padding(5, 0, 5, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // lblLienPrototype
            // 
            lblLienPrototype.AutoSize = true;
            lblLienPrototype.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLienPrototype.Location = new Point(133, 265);
            lblLienPrototype.Margin = new Padding(5, 0, 5, 0);
            lblLienPrototype.Name = "lblLienPrototype";
            lblLienPrototype.Size = new Size(117, 20);
            lblLienPrototype.TabIndex = 14;
            lblLienPrototype.Text = "Lien Prototype";
            // 
            // tbNom
            // 
            tbNom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNom.Location = new Point(133, 113);
            tbNom.Margin = new Padding(5, 4, 5, 4);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(263, 26);
            tbNom.TabIndex = 15;
            // 
            // tbLienPrototype
            // 
            tbLienPrototype.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLienPrototype.Location = new Point(133, 295);
            tbLienPrototype.Margin = new Padding(5, 4, 5, 4);
            tbLienPrototype.Name = "tbLienPrototype";
            tbLienPrototype.Size = new Size(263, 26);
            tbLienPrototype.TabIndex = 17;
            // 
            // BtnAction
            // 
            BtnAction.BackColor = Color.Black;
            BtnAction.FlatStyle = FlatStyle.Popup;
            BtnAction.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAction.ForeColor = SystemColors.ControlLightLight;
            BtnAction.Location = new Point(726, 352);
            BtnAction.Margin = new Padding(5, 4, 5, 4);
            BtnAction.Name = "BtnAction";
            BtnAction.Size = new Size(127, 55);
            BtnAction.TabIndex = 24;
            BtnAction.Text = "AJOUTER";
            BtnAction.UseVisualStyleBackColor = false;
            BtnAction.Click += BtnAction_Click;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lblIdE);
            gbInfo.Controls.Add(dgvMembres);
            gbInfo.Controls.Add(lblMembre);
            gbInfo.Controls.Add(tbLogin);
            gbInfo.Controls.Add(BtnAction);
            gbInfo.Controls.Add(lblEmail);
            gbInfo.Controls.Add(lblLienPrototype);
            gbInfo.Controls.Add(tbLienPrototype);
            gbInfo.Controls.Add(lblNomEquipe);
            gbInfo.Controls.Add(tbNom);
            gbInfo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbInfo.ForeColor = SystemColors.ActiveCaptionText;
            gbInfo.Location = new Point(91, 91);
            gbInfo.Margin = new Padding(5, 4, 5, 4);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(5, 4, 5, 4);
            gbInfo.Size = new Size(872, 415);
            gbInfo.TabIndex = 26;
            gbInfo.TabStop = false;
            gbInfo.Text = "Informations du membre";
            // 
            // lblIdE
            // 
            lblIdE.AutoSize = true;
            lblIdE.Location = new Point(129, 352);
            lblIdE.Name = "lblIdE";
            lblIdE.Size = new Size(143, 20);
            lblIdE.TabIndex = 35;
            lblIdE.Text = "label_CodeEquipe";
            lblIdE.Visible = false;
            // 
            // dgvMembres
            // 
            dgvMembres.AllowUserToAddRows = false;
            dgvMembres.AllowUserToDeleteRows = false;
            dgvMembres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembres.ContextMenuStrip = contextMenuStrip1;
            dgvMembres.Location = new Point(502, 113);
            dgvMembres.Margin = new Padding(5, 5, 5, 5);
            dgvMembres.Name = "dgvMembres";
            dgvMembres.ReadOnly = true;
            dgvMembres.RowHeadersWidth = 51;
            dgvMembres.Size = new Size(267, 211);
            dgvMembres.TabIndex = 34;
            dgvMembres.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { AjouterMembreDansEquipeToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(197, 28);
            // 
            // AjouterMembreDansEquipeToolStripMenuItem
            // 
            AjouterMembreDansEquipeToolStripMenuItem.Name = "AjouterMembreDansEquipeToolStripMenuItem";
            AjouterMembreDansEquipeToolStripMenuItem.Size = new Size(196, 24);
            AjouterMembreDansEquipeToolStripMenuItem.Text = "Ajouter à l'équipe";
            AjouterMembreDansEquipeToolStripMenuItem.Click += AjouterMembreDansEquipeToolStripMenuItem_Click;
            // 
            // lblMembre
            // 
            lblMembre.AutoSize = true;
            lblMembre.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMembre.Location = new Point(502, 81);
            lblMembre.Margin = new Padding(5, 0, 5, 0);
            lblMembre.Name = "lblMembre";
            lblMembre.Size = new Size(70, 20);
            lblMembre.TabIndex = 28;
            lblMembre.Text = "Membre";
            // 
            // tbLogin
            // 
            tbLogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLogin.Location = new Point(133, 204);
            tbLogin.Margin = new Padding(5, 4, 5, 4);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(263, 26);
            tbLogin.TabIndex = 32;
            // 
            // cbListe
            // 
            cbListe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbListe.FormattingEnabled = true;
            cbListe.Location = new Point(401, 23);
            cbListe.Margin = new Padding(5, 4, 5, 4);
            cbListe.Name = "cbListe";
            cbListe.Size = new Size(605, 28);
            cbListe.TabIndex = 27;
            cbListe.SelectedIndexChanged += CbListe_SelectedIndexChanged;
            // 
            // BSListeE
            // 
            BSListeE.CurrentChanged += BSListeE_CurrentChanged;
            // 
            // FormGestionEquipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1034, 603);
            Controls.Add(cbListe);
            Controls.Add(gbInfo);
            Controls.Add(label1);
            Controls.Add(BtnFermer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "FormGestionEquipes";
            Text = " ";
            Load += FormGestionEquipes_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembres).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BSListeM).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSListeE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label lblNomEquipe;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTéléphone;
        private System.Windows.Forms.Label lblLienPrototype;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbTéléphone;
        private System.Windows.Forms.TextBox tbLienPrototype;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.ComboBox cbListe;
        private DateTimePicker dtDateNaissance;
        private TextBox tbLogin;
        private Label lblPrénom;
        private TextBox tbPrénom;
        private ComboBox cbEquipe;
        private BindingSource BSListeE;
        private BindingSource BSListeM;
        private Label lblMembre;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem AjouterMembreDansEquipeToolStripMenuItem;
        private DataGridView dgvMembres;
        private Label lblIdE;
    }
}