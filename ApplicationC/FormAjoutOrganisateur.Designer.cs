namespace ApplicationC
{
    partial class FormAjoutOrganisateur
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
            label1 = new Label();
            label6 = new Label();
            tbNom = new TextBox();
            label2 = new Label();
            tbPrenom = new TextBox();
            tbemail = new TextBox();
            label3 = new Label();
            button1 = new Button();
            BtnFermer = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(280, 29);
            label1.TabIndex = 3;
            label1.Text = "Ajout d'un organisateur";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 108);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 14;
            label6.Text = "Nom";
            // 
            // tbNom
            // 
            tbNom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNom.Location = new Point(51, 137);
            tbNom.Margin = new Padding(4, 5, 4, 5);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(296, 26);
            tbNom.TabIndex = 16;
            tbNom.KeyPress += TbNom_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 208);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 17;
            label2.Text = "Prénom";
            // 
            // tbPrenom
            // 
            tbPrenom.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPrenom.Location = new Point(51, 237);
            tbPrenom.Margin = new Padding(4, 5, 4, 5);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(296, 26);
            tbPrenom.TabIndex = 18;
            tbPrenom.KeyPress += TbPrenom_KeyPress;
            // 
            // tbemail
            // 
            tbemail.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbemail.Location = new Point(51, 332);
            tbemail.Margin = new Padding(4, 5, 4, 5);
            tbemail.Name = "tbemail";
            tbemail.Size = new Size(296, 26);
            tbemail.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 303);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 20;
            label3.Text = "Email";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(51, 400);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(127, 57);
            button1.TabIndex = 25;
            button1.Text = "AJOUTER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // BtnFermer
            // 
            BtnFermer.BackColor = Color.Black;
            BtnFermer.FlatStyle = FlatStyle.Popup;
            BtnFermer.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnFermer.ForeColor = SystemColors.ControlLightLight;
            BtnFermer.Location = new Point(220, 400);
            BtnFermer.Margin = new Padding(4, 5, 4, 5);
            BtnFermer.Name = "BtnFermer";
            BtnFermer.Size = new Size(127, 57);
            BtnFermer.TabIndex = 26;
            BtnFermer.Text = "FERMER";
            BtnFermer.UseVisualStyleBackColor = false;
            BtnFermer.Click += BtnFermer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 366);
            label4.Name = "label4";
            label4.Size = new Size(265, 20);
            label4.TabIndex = 27;
            label4.Text = "Un email lui sera envoyé suite à l'ajout.";
            // 
            // FormAjoutOrganisateur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkKhaki;
            ClientSize = new Size(389, 471);
            Controls.Add(label4);
            Controls.Add(BtnFermer);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(tbemail);
            Controls.Add(tbPrenom);
            Controls.Add(label2);
            Controls.Add(tbNom);
            Controls.Add(label6);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormAjoutOrganisateur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ajout d'un Organisateur";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnFermer;
        private Label label4;
    }
}