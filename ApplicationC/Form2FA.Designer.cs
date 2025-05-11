namespace ApplicationC
{
    partial class Form2FA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2FA));
            lbl2Authentification = new Label();
            btn2Authentification = new Button();
            txtCode = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl2Authentification
            // 
            lbl2Authentification.AutoSize = true;
            lbl2Authentification.BackColor = Color.Silver;
            lbl2Authentification.Font = new Font("Segoe UI", 20F);
            lbl2Authentification.ForeColor = Color.Black;
            lbl2Authentification.Location = new Point(32, 203);
            lbl2Authentification.Name = "lbl2Authentification";
            lbl2Authentification.Size = new Size(378, 46);
            lbl2Authentification.TabIndex = 12;
            lbl2Authentification.Text = "Double Authentification";
            // 
            // btn2Authentification
            // 
            btn2Authentification.Location = new Point(166, 368);
            btn2Authentification.Margin = new Padding(3, 4, 3, 4);
            btn2Authentification.Name = "btn2Authentification";
            btn2Authentification.Size = new Size(86, 31);
            btn2Authentification.TabIndex = 11;
            btn2Authentification.TabStop = false;
            btn2Authentification.Text = "Valider";
            btn2Authentification.UseVisualStyleBackColor = true;
            btn2Authentification.Click += btn2Authentification_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(114, 299);
            txtCode.Margin = new Padding(3, 4, 3, 4);
            txtCode.Name = "txtCode";
            txtCode.PlaceholderText = "Code Google Authenticator";
            txtCode.Size = new Size(192, 27);
            txtCode.TabIndex = 10;
            txtCode.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(166, 90);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form2FA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(422, 484);
            Controls.Add(lbl2Authentification);
            Controls.Add(btn2Authentification);
            Controls.Add(txtCode);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2FA";
            Text = "Double Authentification";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoirMasquer;
        private Label lbl2Authentification;
        private Button btn2Authentification;
        private TextBox txtCode;
        private PictureBox pictureBox1;
    }
}