namespace NoteBook
{
    partial class ModifyBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyBook));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmationButton = new System.Windows.Forms.Button();
            this.NameBookTextBox = new System.Windows.Forms.TextBox();
            this.CategorieComboBox = new System.Windows.Forms.ComboBox();
            this.CategorieLabel = new System.Windows.Forms.Label();
            this.NameBookLabel = new System.Windows.Forms.Label();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelSuperior.Controls.Add(this.avatarPictureBox);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(294, 90);
            this.panelSuperior.TabIndex = 5;
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("avatarPictureBox.Image")));
            this.avatarPictureBox.Location = new System.Drawing.Point(113, 12);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(65, 65);
            this.avatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPictureBox.TabIndex = 0;
            this.avatarPictureBox.TabStop = false;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelInferior.Controls.Add(this.DeleteButton);
            this.panelInferior.Controls.Add(this.cancelButton);
            this.panelInferior.Controls.Add(this.confirmationButton);
            this.panelInferior.Location = new System.Drawing.Point(0, 334);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(295, 77);
            this.panelInferior.TabIndex = 6;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(218, 14);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(50, 50);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmationButton
            // 
            this.confirmationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmationButton.BackgroundImage")));
            this.confirmationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmationButton.Location = new System.Drawing.Point(31, 14);
            this.confirmationButton.Name = "confirmationButton";
            this.confirmationButton.Size = new System.Drawing.Size(50, 50);
            this.confirmationButton.TabIndex = 0;
            this.confirmationButton.UseVisualStyleBackColor = true;
            // 
            // NameBookTextBox
            // 
            this.NameBookTextBox.Location = new System.Drawing.Point(113, 131);
            this.NameBookTextBox.Name = "NameBookTextBox";
            this.NameBookTextBox.Size = new System.Drawing.Size(135, 20);
            this.NameBookTextBox.TabIndex = 7;
            // 
            // CategorieComboBox
            // 
            this.CategorieComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategorieComboBox.Items.AddRange(new object[] {
            "Deportes",
            "Peliculas",
            "Juegos",
            "Musica",
            "Libros",
            "Artes",
            "<Nuevo>"});
            this.CategorieComboBox.Location = new System.Drawing.Point(113, 196);
            this.CategorieComboBox.Name = "CategorieComboBox";
            this.CategorieComboBox.Size = new System.Drawing.Size(135, 21);
            this.CategorieComboBox.TabIndex = 8;
            // 
            // CategorieLabel
            // 
            this.CategorieLabel.AutoSize = true;
            this.CategorieLabel.Location = new System.Drawing.Point(28, 199);
            this.CategorieLabel.Name = "CategorieLabel";
            this.CategorieLabel.Size = new System.Drawing.Size(52, 13);
            this.CategorieLabel.TabIndex = 9;
            this.CategorieLabel.Text = "Categoria";
            // 
            // NameBookLabel
            // 
            this.NameBookLabel.AutoSize = true;
            this.NameBookLabel.Location = new System.Drawing.Point(12, 134);
            this.NameBookLabel.Name = "NameBookLabel";
            this.NameBookLabel.Size = new System.Drawing.Size(89, 13);
            this.NameBookLabel.TabIndex = 10;
            this.NameBookLabel.Text = "Nombre Del Libro";
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Location = new System.Drawing.Point(123, 246);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(45, 45);
            this.IconPictureBox.TabIndex = 11;
            this.IconPictureBox.TabStop = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.Location = new System.Drawing.Point(128, 15);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteButton.TabIndex = 12;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ModifyBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.NameBookLabel);
            this.Controls.Add(this.CategorieLabel);
            this.Controls.Add(this.CategorieComboBox);
            this.Controls.Add(this.NameBookTextBox);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyBook";
            this.Text = "Modificar Libro";
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmationButton;
        private System.Windows.Forms.TextBox NameBookTextBox;
        private System.Windows.Forms.ComboBox CategorieComboBox;
        private System.Windows.Forms.Label CategorieLabel;
        private System.Windows.Forms.Label NameBookLabel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}