namespace ApplicationC
{
    partial class FormDesactiver2FA
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDesactiver2FA));
            lbl_Désactivation_Double_Authentification = new Label();
            lbl_Description = new Label();
            lbl_Code1ere = new Label();
            btn_Valider = new Button();
            txtCodeRecup = new TextBox();
            SuspendLayout();
            // 
            // lbl_Désactivation_Double_Authentification
            // 
            lbl_Désactivation_Double_Authentification.AutoSize = true;
            lbl_Désactivation_Double_Authentification.Font = new Font("Segoe UI", 16.8F, FontStyle.Bold);
            lbl_Désactivation_Double_Authentification.Location = new Point(215, 61);
            lbl_Désactivation_Double_Authentification.Name = "lbl_Désactivation_Double_Authentification";
            lbl_Désactivation_Double_Authentification.Size = new Size(428, 31);
            lbl_Désactivation_Double_Authentification.TabIndex = 15;
            lbl_Désactivation_Double_Authentification.Text = "Désactivation Double Authentification";
            lbl_Désactivation_Double_Authentification.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize = true;
            lbl_Description.Font = new Font("Segoe UI", 9.8F, FontStyle.Bold);
            lbl_Description.Location = new Point(124, 130);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new Size(621, 57);
            lbl_Description.TabIndex = 19;
            lbl_Description.Text = resources.GetString("lbl_Description.Text");
            lbl_Description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Code1ere
            // 
            lbl_Code1ere.AutoSize = true;
            lbl_Code1ere.Font = new Font("Segoe UI", 9.8F, FontStyle.Bold);
            lbl_Code1ere.Location = new Point(158, 233);
            lbl_Code1ere.Name = "lbl_Code1ere";
            lbl_Code1ere.Size = new Size(541, 38);
            lbl_Code1ere.TabIndex = 18;
            lbl_Code1ere.Text = "Pour désactiver la double authentification, veuillez saisir \r\nle code de récupération fourni lors de l'activation de la double authentification.";
            lbl_Code1ere.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_Valider
            // 
            btn_Valider.Location = new Point(346, 349);
            btn_Valider.Margin = new Padding(3, 2, 3, 2);
            btn_Valider.Name = "btn_Valider";
            btn_Valider.Size = new Size(180, 22);
            btn_Valider.TabIndex = 17;
            btn_Valider.Text = "Valider";
            btn_Valider.UseVisualStyleBackColor = true;
            btn_Valider.Click += btn_Valider_Click;
            // 
            // txtCodeRecup
            // 
            txtCodeRecup.Location = new Point(383, 305);
            txtCodeRecup.Margin = new Padding(3, 2, 3, 2);
            txtCodeRecup.Name = "txtCodeRecup";
            txtCodeRecup.Size = new Size(107, 23);
            txtCodeRecup.TabIndex = 16;
            // 
            // FormDesactiver2FA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(905, 452);
            Controls.Add(lbl_Description);
            Controls.Add(lbl_Code1ere);
            Controls.Add(btn_Valider);
            Controls.Add(txtCodeRecup);
            Controls.Add(lbl_Désactivation_Double_Authentification);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormDesactiver2FA";
            Text = "Désactivation 2FA";
            Load += FormDesactiver2FA_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_Désactivation_Double_Authentification;
        private Label lbl_Description;
        private Label lbl_Code1ere;
        private Button btn_Valider;
        private TextBox txtCodeRecup;
    }
}
