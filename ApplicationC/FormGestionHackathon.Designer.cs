namespace ApplicationC
{
    partial class FormGestionHackathon
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
            dtDebut = new DateTimePicker();
            dtFin = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbObjectifs = new TextBox();
            label6 = new Label();
            label7 = new Label();
            tbThematique = new TextBox();
            tbLieu = new TextBox();
            tbVille = new TextBox();
            label8 = new Label();
            tbConditions = new TextBox();
            label9 = new Label();
            cbOrganisateur = new ComboBox();
            label10 = new Label();
            tbAffiche = new TextBox();
            BtnAction = new Button();
            BtnAjoutOrganisateur = new Button();
            BSOrganisateur = new BindingSource(components);
            gbInfo = new GroupBox();
            numPlaceMax = new NumericUpDown();
            label12 = new Label();
            label11 = new Label();
            dtButoir = new DateTimePicker();
            cbListe = new ComboBox();
            BSListeH = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)BSOrganisateur).BeginInit();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPlaceMax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BSListeH).BeginInit();
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
            label1.Size = new Size(210, 24);
            label1.TabIndex = 3;
            label1.Text = "Ajout d'un Hackathon";
            // 
            // BtnFermer
            // 
            BtnFermer.BackColor = Color.Black;
            BtnFermer.FlatStyle = FlatStyle.Popup;
            BtnFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFermer.ForeColor = SystemColors.ControlLightLight;
            BtnFermer.Location = new Point(752, 397);
            BtnFermer.Margin = new Padding(4, 3, 4, 3);
            BtnFermer.Name = "BtnFermer";
            BtnFermer.Size = new Size(111, 39);
            BtnFermer.TabIndex = 4;
            BtnFermer.Text = "FERMER";
            BtnFermer.UseVisualStyleBackColor = false;
            BtnFermer.Click += BtnFermer_Click;
            // 
            // dtDebut
            // 
            dtDebut.CalendarFont = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtDebut.CustomFormat = "dd/MM/yyyy HH:mm";
            dtDebut.Format = DateTimePickerFormat.Custom;
            dtDebut.Location = new Point(23, 106);
            dtDebut.Margin = new Padding(4, 3, 4, 3);
            dtDebut.Name = "dtDebut";
            dtDebut.Size = new Size(233, 22);
            dtDebut.TabIndex = 5;
            // 
            // dtFin
            // 
            dtFin.CustomFormat = "dd/MM/yyyy HH:mm";
            dtFin.Format = DateTimePickerFormat.Custom;
            dtFin.Location = new Point(23, 159);
            dtFin.Margin = new Padding(4, 3, 4, 3);
            dtFin.Name = "dtFin";
            dtFin.Size = new Size(233, 22);
            dtFin.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 16);
            label2.TabIndex = 8;
            label2.Text = "Date Heure de début";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 137);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(111, 16);
            label3.TabIndex = 9;
            label3.Text = "Date Heure de fin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 21);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 16);
            label4.TabIndex = 10;
            label4.Text = "Thématique";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(301, 85);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 16);
            label5.TabIndex = 11;
            label5.Text = "Objectifs";
            // 
            // tbObjectifs
            // 
            tbObjectifs.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbObjectifs.Location = new Point(304, 107);
            tbObjectifs.Margin = new Padding(4, 3, 4, 3);
            tbObjectifs.Multiline = true;
            tbObjectifs.Name = "tbObjectifs";
            tbObjectifs.Size = new Size(231, 72);
            tbObjectifs.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 191);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(32, 16);
            label6.TabIndex = 13;
            label6.Text = "Lieu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 251);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(33, 16);
            label7.TabIndex = 14;
            label7.Text = "Ville";
            // 
            // tbThematique
            // 
            tbThematique.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbThematique.Location = new Point(304, 45);
            tbThematique.Margin = new Padding(4, 3, 4, 3);
            tbThematique.Name = "tbThematique";
            tbThematique.Size = new Size(231, 22);
            tbThematique.TabIndex = 15;
            // 
            // tbLieu
            // 
            tbLieu.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLieu.Location = new Point(26, 213);
            tbLieu.Margin = new Padding(4, 3, 4, 3);
            tbLieu.Name = "tbLieu";
            tbLieu.Size = new Size(231, 22);
            tbLieu.TabIndex = 16;
            // 
            // tbVille
            // 
            tbVille.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbVille.Location = new Point(24, 273);
            tbVille.Margin = new Padding(4, 3, 4, 3);
            tbVille.Name = "tbVille";
            tbVille.Size = new Size(231, 22);
            tbVille.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(301, 201);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 16);
            label8.TabIndex = 18;
            label8.Text = "Conditions";
            // 
            // tbConditions
            // 
            tbConditions.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbConditions.Location = new Point(304, 223);
            tbConditions.Margin = new Padding(4, 3, 4, 3);
            tbConditions.Multiline = true;
            tbConditions.Name = "tbConditions";
            tbConditions.Size = new Size(231, 72);
            tbConditions.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(558, 21);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 16);
            label9.TabIndex = 20;
            label9.Text = "Organisateur";
            // 
            // cbOrganisateur
            // 
            cbOrganisateur.DropDownStyle = ComboBoxStyle.DropDownList;
            cbOrganisateur.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbOrganisateur.FormattingEnabled = true;
            cbOrganisateur.Location = new Point(564, 43);
            cbOrganisateur.Margin = new Padding(4, 3, 4, 3);
            cbOrganisateur.Name = "cbOrganisateur";
            cbOrganisateur.Size = new Size(229, 24);
            cbOrganisateur.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(558, 85);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(47, 16);
            label10.TabIndex = 22;
            label10.Text = "Affiche";
            // 
            // tbAffiche
            // 
            tbAffiche.Location = new Point(564, 107);
            tbAffiche.Margin = new Padding(4, 3, 4, 3);
            tbAffiche.Multiline = true;
            tbAffiche.Name = "tbAffiche";
            tbAffiche.Size = new Size(231, 54);
            tbAffiche.TabIndex = 23;
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
            // BtnAjoutOrganisateur
            // 
            BtnAjoutOrganisateur.BackColor = Color.Black;
            BtnAjoutOrganisateur.FlatStyle = FlatStyle.Popup;
            BtnAjoutOrganisateur.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAjoutOrganisateur.ForeColor = Color.White;
            BtnAjoutOrganisateur.Location = new Point(800, 42);
            BtnAjoutOrganisateur.Margin = new Padding(4, 3, 4, 3);
            BtnAjoutOrganisateur.Name = "BtnAjoutOrganisateur";
            BtnAjoutOrganisateur.Size = new Size(30, 27);
            BtnAjoutOrganisateur.TabIndex = 25;
            BtnAjoutOrganisateur.Text = "+";
            BtnAjoutOrganisateur.UseVisualStyleBackColor = false;
            BtnAjoutOrganisateur.Click += BtnAjoutOrganisateur_Click;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(numPlaceMax);
            gbInfo.Controls.Add(label12);
            gbInfo.Controls.Add(label11);
            gbInfo.Controls.Add(dtButoir);
            gbInfo.Controls.Add(dtDebut);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(BtnAction);
            gbInfo.Controls.Add(BtnAjoutOrganisateur);
            gbInfo.Controls.Add(tbConditions);
            gbInfo.Controls.Add(tbObjectifs);
            gbInfo.Controls.Add(label6);
            gbInfo.Controls.Add(dtFin);
            gbInfo.Controls.Add(label9);
            gbInfo.Controls.Add(label8);
            gbInfo.Controls.Add(label5);
            gbInfo.Controls.Add(tbAffiche);
            gbInfo.Controls.Add(label7);
            gbInfo.Controls.Add(cbOrganisateur);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(tbVille);
            gbInfo.Controls.Add(tbLieu);
            gbInfo.Controls.Add(label4);
            gbInfo.Controls.Add(label10);
            gbInfo.Controls.Add(tbThematique);
            gbInfo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbInfo.ForeColor = SystemColors.ActiveCaptionText;
            gbInfo.Location = new Point(33, 67);
            gbInfo.Margin = new Padding(4, 3, 4, 3);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(4, 3, 4, 3);
            gbInfo.Size = new Size(849, 317);
            gbInfo.TabIndex = 26;
            gbInfo.TabStop = false;
            gbInfo.Text = "Informations de l'hackathon";
            // 
            // numPlaceMax
            // 
            numPlaceMax.Location = new Point(564, 213);
            numPlaceMax.Margin = new Padding(3, 5, 3, 5);
            numPlaceMax.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numPlaceMax.Name = "numPlaceMax";
            numPlaceMax.Size = new Size(84, 22);
            numPlaceMax.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(558, 182);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(172, 16);
            label12.TabIndex = 28;
            label12.Text = "Nombre de place Maximum";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(23, 27);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(135, 16);
            label11.TabIndex = 27;
            label11.Text = "Date butoir Inscription";
            // 
            // dtButoir
            // 
            dtButoir.CustomFormat = "dd/MM/yyyy HH:mm";
            dtButoir.Format = DateTimePickerFormat.Custom;
            dtButoir.Location = new Point(25, 46);
            dtButoir.Margin = new Padding(4, 3, 4, 3);
            dtButoir.Name = "dtButoir";
            dtButoir.Size = new Size(231, 22);
            dtButoir.TabIndex = 26;
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
            // BSListeH
            // 
            BSListeH.CurrentChanged += BSListeH_CurrentChanged;
            // 
            // FormGestionHackathon
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
            Name = "FormGestionHackathon";
            Text = "FormGestionHackathon";
            Load += FormGestionHackathon_Load;
            ((System.ComponentModel.ISupportInitialize)BSOrganisateur).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPlaceMax).EndInit();
            ((System.ComponentModel.ISupportInitialize)BSListeH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.DateTimePicker dtDebut;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbObjectifs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbThematique;
        private System.Windows.Forms.TextBox tbLieu;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbConditions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbOrganisateur;
        private System.Windows.Forms.BindingSource BSOrganisateur;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAffiche;
        private System.Windows.Forms.Button BtnAction;
        private System.Windows.Forms.Button BtnAjoutOrganisateur;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.ComboBox cbListe;
        private System.Windows.Forms.BindingSource BSListeH;
        private Label label11;
        private DateTimePicker dtButoir;
        private NumericUpDown numPlaceMax;
        private Label label12;
    }
}