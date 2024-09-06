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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.dtDebut = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbObjectifs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbThematique = new System.Windows.Forms.TextBox();
            this.tbLieu = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbConditions = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbOrganisateur = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAffiche = new System.Windows.Forms.TextBox();
            this.BtnAction = new System.Windows.Forms.Button();
            this.BtnAjoutOrganisateur = new System.Windows.Forms.Button();
            this.BSOrganisateur = new System.Windows.Forms.BindingSource(this.components);
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.cbListe = new System.Windows.Forms.ComboBox();
            this.BSListeH = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BSOrganisateur)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSListeH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ajout d\'un Hackathon";
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Black;
            this.BtnFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnFermer.Location = new System.Drawing.Point(645, 338);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(95, 51);
            this.BtnFermer.TabIndex = 4;
            this.BtnFermer.Text = "FERMER";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // dtDebut
            // 
            this.dtDebut.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDebut.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDebut.Location = new System.Drawing.Point(23, 37);
            this.dtDebut.Name = "dtDebut";
            this.dtDebut.Size = new System.Drawing.Size(200, 22);
            this.dtDebut.TabIndex = 5;
            // 
            // dtFin
            // 
            this.dtFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFin.Location = new System.Drawing.Point(23, 93);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(200, 22);
            this.dtFin.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date Heure de début";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Date Heure de fin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Thématique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(258, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Objectifs";
            // 
            // tbObjectifs
            // 
            this.tbObjectifs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObjectifs.Location = new System.Drawing.Point(261, 93);
            this.tbObjectifs.Multiline = true;
            this.tbObjectifs.Name = "tbObjectifs";
            this.tbObjectifs.Size = new System.Drawing.Size(199, 63);
            this.tbObjectifs.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Lieu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ville";
            // 
            // tbThematique
            // 
            this.tbThematique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbThematique.Location = new System.Drawing.Point(261, 39);
            this.tbThematique.Name = "tbThematique";
            this.tbThematique.Size = new System.Drawing.Size(199, 22);
            this.tbThematique.TabIndex = 15;
            // 
            // tbLieu
            // 
            this.tbLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLieu.Location = new System.Drawing.Point(23, 150);
            this.tbLieu.Name = "tbLieu";
            this.tbLieu.Size = new System.Drawing.Size(199, 22);
            this.tbLieu.TabIndex = 16;
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(24, 212);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(199, 22);
            this.tbVille.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(258, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Conditions";
            // 
            // tbConditions
            // 
            this.tbConditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConditions.Location = new System.Drawing.Point(261, 193);
            this.tbConditions.Multiline = true;
            this.tbConditions.Name = "tbConditions";
            this.tbConditions.Size = new System.Drawing.Size(199, 63);
            this.tbConditions.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Organisateur";
            // 
            // cbOrganisateur
            // 
            this.cbOrganisateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrganisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOrganisateur.FormattingEnabled = true;
            this.cbOrganisateur.Location = new System.Drawing.Point(483, 37);
            this.cbOrganisateur.Name = "cbOrganisateur";
            this.cbOrganisateur.Size = new System.Drawing.Size(197, 24);
            this.cbOrganisateur.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(478, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Affiche";
            // 
            // tbAffiche
            // 
            this.tbAffiche.Location = new System.Drawing.Point(483, 93);
            this.tbAffiche.Multiline = true;
            this.tbAffiche.Name = "tbAffiche";
            this.tbAffiche.Size = new System.Drawing.Size(199, 47);
            this.tbAffiche.TabIndex = 23;
            // 
            // BtnAction
            // 
            this.BtnAction.BackColor = System.Drawing.Color.Black;
            this.BtnAction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAction.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAction.Location = new System.Drawing.Point(617, 205);
            this.BtnAction.Name = "BtnAction";
            this.BtnAction.Size = new System.Drawing.Size(95, 51);
            this.BtnAction.TabIndex = 24;
            this.BtnAction.Text = "AJOUTER";
            this.BtnAction.UseVisualStyleBackColor = false;
            this.BtnAction.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BtnAjoutOrganisateur
            // 
            this.BtnAjoutOrganisateur.BackColor = System.Drawing.Color.Black;
            this.BtnAjoutOrganisateur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAjoutOrganisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjoutOrganisateur.ForeColor = System.Drawing.Color.White;
            this.BtnAjoutOrganisateur.Location = new System.Drawing.Point(686, 36);
            this.BtnAjoutOrganisateur.Name = "BtnAjoutOrganisateur";
            this.BtnAjoutOrganisateur.Size = new System.Drawing.Size(26, 23);
            this.BtnAjoutOrganisateur.TabIndex = 25;
            this.BtnAjoutOrganisateur.Text = "+";
            this.BtnAjoutOrganisateur.UseVisualStyleBackColor = false;
            this.BtnAjoutOrganisateur.Click += new System.EventHandler(this.BtnAjoutOrganisateur_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dtDebut);
            this.gbInfo.Controls.Add(this.BtnAjoutOrganisateur);
            this.gbInfo.Controls.Add(this.label2);
            this.gbInfo.Controls.Add(this.tbConditions);
            this.gbInfo.Controls.Add(this.BtnAction);
            this.gbInfo.Controls.Add(this.tbObjectifs);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.dtFin);
            this.gbInfo.Controls.Add(this.label9);
            this.gbInfo.Controls.Add(this.label8);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.tbAffiche);
            this.gbInfo.Controls.Add(this.label7);
            this.gbInfo.Controls.Add(this.cbOrganisateur);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.tbVille);
            this.gbInfo.Controls.Add(this.tbLieu);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label10);
            this.gbInfo.Controls.Add(this.tbThematique);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.White;
            this.gbInfo.Location = new System.Drawing.Point(28, 57);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(728, 275);
            this.gbInfo.TabIndex = 26;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Informations de l\'hackathon";
            // 
            // cbListe
            // 
            this.cbListe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListe.FormattingEnabled = true;
            this.cbListe.Location = new System.Drawing.Point(301, 15);
            this.cbListe.Name = "cbListe";
            this.cbListe.Size = new System.Drawing.Size(455, 24);
            this.cbListe.TabIndex = 27;
            this.cbListe.SelectedIndexChanged += new System.EventHandler(this.CbListe_SelectedIndexChanged);
            // 
            // BSListeH
            // 
            this.BSListeH.CurrentChanged += new System.EventHandler(this.BSListeH_CurrentChanged);
            // 
            // FormGestionHackathon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(776, 392);
            this.Controls.Add(this.cbListe);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnFermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGestionHackathon";
            this.Text = "FormGestionHackathon";
            this.Load += new System.EventHandler(this.FormGestionHackathon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BSOrganisateur)).EndInit();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BSListeH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}