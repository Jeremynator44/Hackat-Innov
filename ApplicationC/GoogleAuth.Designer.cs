namespace ApplicationC
{
    partial class GoogleAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleAuth));
            txtCode = new TextBox();
            btn_Valider = new Button();
            lbl_Code1ere = new Label();
            lbl_Double_Authentification = new Label();
            lbl_Description = new Label();
            lbl_TextCodeRécup = new Label();
            totpPictureBox = new PictureBox();
            txt_CodeRécup = new TextBox();
            ((System.ComponentModel.ISupportInitialize)totpPictureBox).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(622, 316);
            txtCode.Margin = new Padding(3, 2, 3, 2);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(107, 23);
            txtCode.TabIndex = 2;
            // 
            // btn_Valider
            // 
            btn_Valider.Location = new Point(574, 359);
            btn_Valider.Margin = new Padding(3, 2, 3, 2);
            btn_Valider.Name = "btn_Valider";
            btn_Valider.Size = new Size(206, 22);
            btn_Valider.TabIndex = 3;
            btn_Valider.Text = "Valider";
            btn_Valider.UseVisualStyleBackColor = true;
            btn_Valider.Click += btn_Valider_Click;
            // 
            // lbl_Code1ere
            // 
            lbl_Code1ere.AutoSize = true;
            lbl_Code1ere.Font = new Font("Segoe UI", 9.8F, FontStyle.Bold);
            lbl_Code1ere.Location = new Point(512, 251);
            lbl_Code1ere.Name = "lbl_Code1ere";
            lbl_Code1ere.Size = new Size(324, 38);
            lbl_Code1ere.TabIndex = 4;
            lbl_Code1ere.Text = "Code présent sur Google Authenticator à saisir \r\npour activer la double authentification";
            lbl_Code1ere.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Double_Authentification
            // 
            lbl_Double_Authentification.AutoSize = true;
            lbl_Double_Authentification.Font = new Font("Segoe UI", 16.8F, FontStyle.Bold);
            lbl_Double_Authentification.Location = new Point(287, 47);
            lbl_Double_Authentification.Name = "lbl_Double_Authentification";
            lbl_Double_Authentification.Size = new Size(276, 31);
            lbl_Double_Authentification.TabIndex = 7;
            lbl_Double_Authentification.Text = "Double Authentification";
            lbl_Double_Authentification.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Description
            // 
            lbl_Description.AutoSize = true;
            lbl_Description.Font = new Font("Segoe UI", 9.8F, FontStyle.Bold);
            lbl_Description.Location = new Point(63, 116);
            lbl_Description.Name = "lbl_Description";
            lbl_Description.Size = new Size(757, 57);
            lbl_Description.TabIndex = 8;
            lbl_Description.Text = resources.GetString("lbl_Description.Text");
            lbl_Description.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_TextCodeRécup
            // 
            lbl_TextCodeRécup.AutoSize = true;
            lbl_TextCodeRécup.Font = new Font("Segoe UI", 9.8F, FontStyle.Bold);
            lbl_TextCodeRécup.Location = new Point(63, 251);
            lbl_TextCodeRécup.Name = "lbl_TextCodeRécup";
            lbl_TextCodeRécup.Size = new Size(171, 38);
            lbl_TextCodeRécup.TabIndex = 9;
            lbl_TextCodeRécup.Text = "Code de récupération à \r\nconserver :";
            lbl_TextCodeRécup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totpPictureBox
            // 
            totpPictureBox.Location = new Point(286, 233);
            totpPictureBox.Margin = new Padding(3, 2, 3, 2);
            totpPictureBox.Name = "totpPictureBox";
            totpPictureBox.Size = new Size(197, 160);
            totpPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            totpPictureBox.TabIndex = 1;
            totpPictureBox.TabStop = false;
            // 
            // txt_CodeRécup
            // 
            txt_CodeRécup.Location = new Point(57, 316);
            txt_CodeRécup.Margin = new Padding(3, 2, 3, 2);
            txt_CodeRécup.Name = "txt_CodeRécup";
            txt_CodeRécup.ReadOnly = true;
            txt_CodeRécup.Size = new Size(177, 23);
            txt_CodeRécup.TabIndex = 11;
            // 
            // GoogleAuth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(905, 452);
            Controls.Add(txt_CodeRécup);
            Controls.Add(lbl_TextCodeRécup);
            Controls.Add(lbl_Description);
            Controls.Add(lbl_Double_Authentification);
            Controls.Add(lbl_Code1ere);
            Controls.Add(btn_Valider);
            Controls.Add(txtCode);
            Controls.Add(totpPictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GoogleAuth";
            Text = "GoogleAuth";
            Load += GoogleAuth_Load;
            ((System.ComponentModel.ISupportInitialize)totpPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox totpPictureBox;
        private TextBox txtCode;
        private Button btn_Valider;
        private Label lbl_Code1ere;
        private Label lbl_Description;
        private Label lbl_TextCodeRécup;
        private Label lbl_Double_Authentification;
        private TextBox txt_CodeRécup;
    }
}