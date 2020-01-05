namespace NoteBook
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookNewBookForm));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.NullButton = new System.Windows.Forms.Button();
            this.ConfirmationButton = new System.Windows.Forms.Button();
            this.NameBookLabel = new System.Windows.Forms.Label();
            this.CategorieBookLabel = new System.Windows.Forms.Label();
            this.NameBookTextBox = new System.Windows.Forms.TextBox();
            this.CategoriesComboBox = new System.Windows.Forms.ComboBox();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.NameCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.NewImageCategorieButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AvisoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.PanelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvisoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelSuperior.Controls.Add(this.AvatarPictureBox);
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(294, 90);
            this.PanelSuperior.TabIndex = 4;
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AvatarPictureBox.Image")));
            this.AvatarPictureBox.Location = new System.Drawing.Point(113, 12);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(65, 65);
            this.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarPictureBox.TabIndex = 0;
            this.AvatarPictureBox.TabStop = false;
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelInferior.Controls.Add(this.NullButton);
            this.PanelInferior.Controls.Add(this.ConfirmationButton);
            this.PanelInferior.Location = new System.Drawing.Point(0, 333);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(295, 77);
            this.PanelInferior.TabIndex = 5;
            // 
            // NullButton
            // 
            this.NullButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NullButton.BackgroundImage")));
            this.NullButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NullButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NullButton.Location = new System.Drawing.Point(169, 14);
            this.NullButton.Name = "NullButton";
            this.NullButton.Size = new System.Drawing.Size(50, 50);
            this.NullButton.TabIndex = 1;
            this.NullButton.UseVisualStyleBackColor = true;
            this.NullButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmationButton
            // 
            this.ConfirmationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmationButton.BackgroundImage")));
            this.ConfirmationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmationButton.Location = new System.Drawing.Point(60, 14);
            this.ConfirmationButton.Name = "ConfirmationButton";
            this.ConfirmationButton.Size = new System.Drawing.Size(50, 50);
            this.ConfirmationButton.TabIndex = 0;
            this.ConfirmationButton.UseVisualStyleBackColor = true;
            this.ConfirmationButton.Click += new System.EventHandler(this.ConfirmationButton_Click);
            // 
            // NameBookLabel
            // 
            this.NameBookLabel.AutoSize = true;
            this.NameBookLabel.Location = new System.Drawing.Point(13, 113);
            this.NameBookLabel.Name = "NameBookLabel";
            this.NameBookLabel.Size = new System.Drawing.Size(89, 13);
            this.NameBookLabel.TabIndex = 6;
            this.NameBookLabel.Text = "Nombre Del Libro";
            // 
            // CategorieBookLabel
            // 
            this.CategorieBookLabel.AutoSize = true;
            this.CategorieBookLabel.Location = new System.Drawing.Point(13, 159);
            this.CategorieBookLabel.Name = "CategorieBookLabel";
            this.CategorieBookLabel.Size = new System.Drawing.Size(52, 13);
            this.CategorieBookLabel.TabIndex = 7;
            this.CategorieBookLabel.Text = "Categoria";
            // 
            // NameBookTextBox
            // 
            this.NameBookTextBox.Location = new System.Drawing.Point(132, 110);
            this.NameBookTextBox.MaxLength = 13;
            this.NameBookTextBox.Name = "NameBookTextBox";
            this.NameBookTextBox.Size = new System.Drawing.Size(126, 20);
            this.NameBookTextBox.TabIndex = 8;
            this.NameBookTextBox.Leave += new System.EventHandler(this.NameBookTextBox_Leave);
            // 
            // CategoriesComboBox
            // 
            this.CategoriesComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Deportes",
            "Peliculas",
            "Juegos",
            "Musica",
            "Libros",
            "Artes"});
            this.CategoriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriesComboBox.Items.AddRange(new object[] {
            "Deportes",
            "Peliculas",
            "Juegos",
            "Musica",
            "Libros",
            "Artes",
            "<Nuevo>"});
            this.CategoriesComboBox.Location = new System.Drawing.Point(132, 159);
            this.CategoriesComboBox.MaxDropDownItems = 4;
            this.CategoriesComboBox.Name = "CategoriesComboBox";
            this.CategoriesComboBox.Size = new System.Drawing.Size(126, 21);
            this.CategoriesComboBox.TabIndex = 9;
            this.CategoriesComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoriesComboBox_SelectedIndexChanged);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconPictureBox.Location = new System.Drawing.Point(169, 196);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(45, 45);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 10;
            this.IconPictureBox.TabStop = false;
            // 
            // NameCategoriaTextBox
            // 
            this.NameCategoriaTextBox.Location = new System.Drawing.Point(16, 208);
            this.NameCategoriaTextBox.MaxLength = 10;
            this.NameCategoriaTextBox.Name = "NameCategoriaTextBox";
            this.NameCategoriaTextBox.Size = new System.Drawing.Size(113, 20);
            this.NameCategoriaTextBox.TabIndex = 11;
            this.NameCategoriaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameCategoriaTextBox.Visible = false;
            this.NameCategoriaTextBox.Leave += new System.EventHandler(this.NameCategoriaTextBox_Leave);
            // 
            // NewImageCategorieButton
            // 
            this.NewImageCategorieButton.Location = new System.Drawing.Point(31, 234);
            this.NewImageCategorieButton.Name = "NewImageCategorieButton";
            this.NewImageCategorieButton.Size = new System.Drawing.Size(89, 23);
            this.NewImageCategorieButton.TabIndex = 12;
            this.NewImageCategorieButton.Text = "Nueva Avatar";
            this.NewImageCategorieButton.UseVisualStyleBackColor = true;
            this.NewImageCategorieButton.Visible = false;
            this.NewImageCategorieButton.Click += new System.EventHandler(this.NewImageCategorieButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(86, 289);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 13;
            // 
            // AvisoErrorProvider
            // 
            this.AvisoErrorProvider.BlinkRate = 0;
            this.AvisoErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AvisoErrorProvider.ContainerControl = this;
            // 
            // NoteBookNewBookForm
            // 
            this.AcceptButton = this.ConfirmationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NullButton;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.NewImageCategorieButton);
            this.Controls.Add(this.NameCategoriaTextBox);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.CategoriesComboBox);
            this.Controls.Add(this.NameBookTextBox);
            this.Controls.Add(this.CategorieBookLabel);
            this.Controls.Add(this.NameBookLabel);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.PanelSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookNewBookForm";
            this.Text = "Libro Nuevo";
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.PanelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvisoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Button NullButton;
        private System.Windows.Forms.Button ConfirmationButton;
        private System.Windows.Forms.Label NameBookLabel;
        private System.Windows.Forms.Label CategorieBookLabel;
        private System.Windows.Forms.TextBox NameBookTextBox;
        private System.Windows.Forms.ComboBox CategoriesComboBox;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.TextBox NameCategoriaTextBox;
        private System.Windows.Forms.Button NewImageCategorieButton;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.ErrorProvider AvisoErrorProvider;
    }
}