namespace ApplicationC
{
    partial class FormMembres
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
            dgvMembre = new DataGridView();
            bsMembre = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvMembre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsMembre).BeginInit();
            SuspendLayout();
            // 
            // dgvMembre
            // 
            dgvMembre.AllowUserToAddRows = false;
            dgvMembre.AllowUserToDeleteRows = false;
            dgvMembre.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMembre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembre.Location = new Point(53, 59);
            dgvMembre.Margin = new Padding(4, 5, 4, 5);
            dgvMembre.MultiSelect = false;
            dgvMembre.Name = "dgvMembre";
            dgvMembre.ReadOnly = true;
            dgvMembre.RowHeadersWidth = 51;
            dgvMembre.Size = new Size(941, 473);
            dgvMembre.TabIndex = 1;
            // 
            // FormMembres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1045, 591);
            Controls.Add(dgvMembre);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMembres";
            Text = "FormMembres";
            Load += FormMembres_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembre).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsMembre).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMembre;
        private BindingSource bsMembre;
    }
}