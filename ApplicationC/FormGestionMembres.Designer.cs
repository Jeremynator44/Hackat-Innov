namespace ApplicationC
{
    partial class FormGestionMembres
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
            lblNom = new Label();
            lblEmail = new Label();
            lblTéléphone = new Label();
            lblPortfolio = new Label();
            tbNom = new TextBox();
            tbTéléphone = new TextBox();
            tbPortfolio = new TextBox();
            lblNaissance = new Label();
            BtnAction = new Button();
            gbInfo = new GroupBox();
            lblEquipe = new Label();
            dtDateNaissance = new DateTimePicker();
            cbEquipe = new ComboBox();
            tbEmail = new TextBox();
            lblPrénom = new Label();
            tbPrénom = new TextBox();
            cbListe = new ComboBox();
            BSListeM = new BindingSource(components);
            BSListeE = new BindingSource(components);
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BSListeM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSListeE).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(28, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(188, 24);
            label1.TabIndex = 3;
            label1.Text = "Ajout d'un Membre";
            // 
            // BtnFermer
            // 
            BtnFermer.BackColor = Color.Black;
            BtnFermer.FlatStyle = FlatStyle.Popup;
            BtnFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFermer.ForeColor = SystemColors.ControlLightLight;
            BtnFermer.Location = new Point(751, 401);
            BtnFermer.Margin = new Padding(4, 3, 4, 3);
            BtnFermer.Name = "BtnFermer";
            BtnFermer.Size = new Size(111, 39);
            BtnFermer.TabIndex = 4;
            BtnFermer.Text = "FERMER";
            BtnFermer.UseVisualStyleBackColor = false;
            BtnFermer.Click += BtnFermer_Click;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(19, 43);
            lblNom.Margin = new Padding(4, 0, 4, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(36, 16);
            lblNom.TabIndex = 10;
            lblNom.Text = "Nom";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(19, 111);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 16);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // lblTéléphone
            // 
            lblTéléphone.AutoSize = true;
            lblTéléphone.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTéléphone.Location = new Point(345, 111);
            lblTéléphone.Margin = new Padding(4, 0, 4, 0);
            lblTéléphone.Name = "lblTéléphone";
            lblTéléphone.Size = new Size(90, 16);
            lblTéléphone.TabIndex = 13;
            lblTéléphone.Text = "N° Téléphone";
            // 
            // lblPortfolio
            // 
            lblPortfolio.AutoSize = true;
            lblPortfolio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPortfolio.Location = new Point(19, 181);
            lblPortfolio.Margin = new Padding(4, 0, 4, 0);
            lblPortfolio.Name = "lblPortfolio";
            lblPortfolio.Size = new Size(84, 16);
            lblPortfolio.TabIndex = 14;
            lblPortfolio.Text = "Lien Portfolio";
            // 
            // tbNom
            // 
            tbNom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNom.Location = new Point(19, 67);
            tbNom.Margin = new Padding(4, 3, 4, 3);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(231, 22);
            tbNom.TabIndex = 15;
            // 
            // tbTéléphone
            // 
            tbTéléphone.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTéléphone.Location = new Point(345, 133);
            tbTéléphone.Margin = new Padding(4, 3, 4, 3);
            tbTéléphone.MaxLength = 10;
            tbTéléphone.Name = "tbTéléphone";
            tbTéléphone.Size = new Size(231, 22);
            tbTéléphone.TabIndex = 16;
            // 
            // tbPortfolio
            // 
            tbPortfolio.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPortfolio.Location = new Point(19, 203);
            tbPortfolio.Margin = new Padding(4, 3, 4, 3);
            tbPortfolio.Name = "tbPortfolio";
            tbPortfolio.Size = new Size(231, 22);
            tbPortfolio.TabIndex = 17;
            // 
            // lblNaissance
            // 
            lblNaissance.AutoSize = true;
            lblNaissance.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNaissance.Location = new Point(342, 181);
            lblNaissance.Margin = new Padding(4, 0, 4, 0);
            lblNaissance.Name = "lblNaissance";
            lblNaissance.Size = new Size(123, 16);
            lblNaissance.TabIndex = 20;
            lblNaissance.Text = "Date de Naissance";
            // 
            // BtnAction
            // 
            BtnAction.BackColor = Color.Black;
            BtnAction.FlatStyle = FlatStyle.Popup;
            BtnAction.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAction.ForeColor = SystemColors.ControlLightLight;
            BtnAction.Location = new Point(718, 262);
            BtnAction.Margin = new Padding(4, 3, 4, 3);
            BtnAction.Name = "BtnAction";
            BtnAction.Size = new Size(111, 41);
            BtnAction.TabIndex = 24;
            BtnAction.Text = "AJOUTER";
            BtnAction.UseVisualStyleBackColor = false;
            BtnAction.Click += BtnAction_Click;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(lblEquipe);
            gbInfo.Controls.Add(dtDateNaissance);
            gbInfo.Controls.Add(cbEquipe);
            gbInfo.Controls.Add(tbEmail);
            gbInfo.Controls.Add(lblPrénom);
            gbInfo.Controls.Add(tbPrénom);
            gbInfo.Controls.Add(BtnAction);
            gbInfo.Controls.Add(lblTéléphone);
            gbInfo.Controls.Add(lblNaissance);
            gbInfo.Controls.Add(lblEmail);
            gbInfo.Controls.Add(lblPortfolio);
            gbInfo.Controls.Add(tbPortfolio);
            gbInfo.Controls.Add(tbTéléphone);
            gbInfo.Controls.Add(lblNom);
            gbInfo.Controls.Add(tbNom);
            gbInfo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbInfo.ForeColor = SystemColors.ActiveCaptionText;
            gbInfo.Location = new Point(33, 67);
            gbInfo.Margin = new Padding(4, 3, 4, 3);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(4, 3, 4, 3);
            gbInfo.Size = new Size(849, 311);
            gbInfo.TabIndex = 26;
            gbInfo.TabStop = false;
            gbInfo.Text = "Informations du membre";
            // 
            // lblEquipe
            // 
            lblEquipe.AutoSize = true;
            lblEquipe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEquipe.Location = new Point(624, 111);
            lblEquipe.Margin = new Padding(4, 0, 4, 0);
            lblEquipe.Name = "lblEquipe";
            lblEquipe.Size = new Size(50, 16);
            lblEquipe.TabIndex = 28;
            lblEquipe.Text = "Equipe";
            // 
            // dtDateNaissance
            // 
            dtDateNaissance.CustomFormat = "";
            dtDateNaissance.Format = DateTimePickerFormat.Short;
            dtDateNaissance.Location = new Point(342, 203);
            dtDateNaissance.Name = "dtDateNaissance";
            dtDateNaissance.Size = new Size(234, 22);
            dtDateNaissance.TabIndex = 33;
            // 
            // cbEquipe
            // 
            cbEquipe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEquipe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbEquipe.FormattingEnabled = true;
            cbEquipe.Location = new Point(624, 133);
            cbEquipe.Margin = new Padding(4, 3, 4, 3);
            cbEquipe.Name = "cbEquipe";
            cbEquipe.Size = new Size(217, 24);
            cbEquipe.TabIndex = 29;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(19, 135);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(231, 22);
            tbEmail.TabIndex = 32;
            // 
            // lblPrénom
            // 
            lblPrénom.AutoSize = true;
            lblPrénom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrénom.Location = new Point(345, 43);
            lblPrénom.Margin = new Padding(4, 0, 4, 0);
            lblPrénom.Name = "lblPrénom";
            lblPrénom.Size = new Size(54, 16);
            lblPrénom.TabIndex = 30;
            lblPrénom.Text = "Prénom";
            // 
            // tbPrénom
            // 
            tbPrénom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrénom.Location = new Point(345, 67);
            tbPrénom.Margin = new Padding(4, 3, 4, 3);
            tbPrénom.Name = "tbPrénom";
            tbPrénom.Size = new Size(231, 22);
            tbPrénom.TabIndex = 31;
            // 
            // cbListe
            // 
            cbListe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbListe.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbListe.FormattingEnabled = true;
            cbListe.Location = new Point(351, 17);
            cbListe.Margin = new Padding(4, 3, 4, 3);
            cbListe.Name = "cbListe";
            cbListe.Size = new Size(530, 24);
            cbListe.TabIndex = 27;
            cbListe.SelectedIndexChanged += CbListe_SelectedIndexChanged;
            // 
            // BSListeM
            // 
            BSListeM.CurrentChanged += BSListeM_CurrentChanged;
            // 
            // FormGestionMembres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(905, 452);
            Controls.Add(cbListe);
            Controls.Add(gbInfo);
            Controls.Add(label1);
            Controls.Add(BtnFermer);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormGestionMembres";
            Text = "FormGestionMembres";
            Load += FormGestionMembres_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BSListeM).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSListeE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTéléphone;
        private System.Windows.Forms.Label lblPortfolio;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbTéléphone;
        private System.Windows.Forms.TextBox tbPortfolio;
        private System.Windows.Forms.Label lblNaissance;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.ComboBox cbListe;
        private DateTimePicker dtDateNaissance;
        private TextBox tbEmail;
        private Label lblPrénom;
        private TextBox tbPrénom;
        private Label lblEquipe;
        private ComboBox cbEquipe;
        private BindingSource BSListeE;
        private BindingSource BSListeM;
    }
}