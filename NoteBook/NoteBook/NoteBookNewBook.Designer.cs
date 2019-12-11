﻿namespace NoteBook
{
    partial class NoteBookNewBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookNewBookForm));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmationButton = new System.Windows.Forms.Button();
            this.nameBookLabel = new System.Windows.Forms.Label();
            this.categorieBookLabel = new System.Windows.Forms.Label();
            this.nameBookTextBox = new System.Windows.Forms.TextBox();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelSuperior.Controls.Add(this.avatarPictureBox);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(294, 90);
            this.panelSuperior.TabIndex = 4;
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
            this.panelInferior.Controls.Add(this.cancelButton);
            this.panelInferior.Controls.Add(this.confirmationButton);
            this.panelInferior.Location = new System.Drawing.Point(0, 333);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(295, 77);
            this.panelInferior.TabIndex = 5;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Location = new System.Drawing.Point(169, 14);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(50, 50);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmationButton
            // 
            this.confirmationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmationButton.BackgroundImage")));
            this.confirmationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmationButton.Location = new System.Drawing.Point(60, 14);
            this.confirmationButton.Name = "confirmationButton";
            this.confirmationButton.Size = new System.Drawing.Size(50, 50);
            this.confirmationButton.TabIndex = 0;
            this.confirmationButton.UseVisualStyleBackColor = true;
            // 
            // nameBookLabel
            // 
            this.nameBookLabel.AutoSize = true;
            this.nameBookLabel.Location = new System.Drawing.Point(13, 113);
            this.nameBookLabel.Name = "nameBookLabel";
            this.nameBookLabel.Size = new System.Drawing.Size(89, 13);
            this.nameBookLabel.TabIndex = 6;
            this.nameBookLabel.Text = "Nombre Del Libro";
            // 
            // categorieBookLabel
            // 
            this.categorieBookLabel.AutoSize = true;
            this.categorieBookLabel.Location = new System.Drawing.Point(13, 159);
            this.categorieBookLabel.Name = "categorieBookLabel";
            this.categorieBookLabel.Size = new System.Drawing.Size(52, 13);
            this.categorieBookLabel.TabIndex = 7;
            this.categorieBookLabel.Text = "Categoria";
            // 
            // nameBookTextBox
            // 
            this.nameBookTextBox.Location = new System.Drawing.Point(132, 110);
            this.nameBookTextBox.MaxLength = 13;
            this.nameBookTextBox.Name = "nameBookTextBox";
            this.nameBookTextBox.Size = new System.Drawing.Size(126, 20);
            this.nameBookTextBox.TabIndex = 8;
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Deportes",
            "Peliculas",
            "Juegos",
            "Musica",
            "Libros",
            "Artes"});
            this.categoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriesComboBox.Items.AddRange(new object[] {
            "Deportes",
            "Peliculas",
            "Juegos",
            "Musica",
            "Libros",
            "Artes"});
            this.categoriesComboBox.Location = new System.Drawing.Point(132, 159);
            this.categoriesComboBox.MaxDropDownItems = 4;
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(126, 21);
            this.categoriesComboBox.TabIndex = 9;
            this.categoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriesComboBox_SelectedIndexChanged);
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Location = new System.Drawing.Point(169, 196);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(45, 45);
            this.iconPictureBox.TabIndex = 10;
            this.iconPictureBox.TabStop = false;
            // 
            // NoteBookNewBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.ControlBox = false;
            this.Controls.Add(this.iconPictureBox);
            this.Controls.Add(this.categoriesComboBox);
            this.Controls.Add(this.nameBookTextBox);
            this.Controls.Add(this.categorieBookLabel);
            this.Controls.Add(this.nameBookLabel);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookNewBookForm";
            this.Text = "NoteBookNewBook";
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmationButton;
        private System.Windows.Forms.Label nameBookLabel;
        private System.Windows.Forms.Label categorieBookLabel;
        private System.Windows.Forms.TextBox nameBookTextBox;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.PictureBox iconPictureBox;
    }
}