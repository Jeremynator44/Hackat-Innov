namespace ApplicationC
{
    partial class FormEquipes
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
            dgvEquipe = new DataGridView();
            bsEquipe = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvEquipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEquipe).BeginInit();
            SuspendLayout();
            // 
            // dgvEquipe
            // 
            dgvEquipe.AllowUserToAddRows = false;
            dgvEquipe.AllowUserToDeleteRows = false;
            dgvEquipe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEquipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipe.Location = new Point(52, 59);
            dgvEquipe.Margin = new Padding(4, 5, 4, 5);
            dgvEquipe.MultiSelect = false;
            dgvEquipe.Name = "dgvEquipe";
            dgvEquipe.ReadOnly = true;
            dgvEquipe.RowHeadersWidth = 51;
            dgvEquipe.Size = new Size(941, 473);
            dgvEquipe.TabIndex = 2;
            // 
            // FormEquipes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1045, 591);
            Controls.Add(dgvEquipe);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEquipes";
            Text = "FormEquipes";
            ((System.ComponentModel.ISupportInitialize)dgvEquipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEquipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEquipe;
        private BindingSource bsEquipe;
    }
}