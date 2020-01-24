namespace NoteBook
{
    partial class NoteBookModifyBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookModifyBookForm));
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.NameNewCategorieTextBox = new System.Windows.Forms.TextBox();
            this.NewAvatarCategorieButton = new System.Windows.Forms.Button();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.NameBookLabel = new System.Windows.Forms.Label();
            this.CategorieLabel = new System.Windows.Forms.Label();
            this.CategorieComboBox = new System.Windows.Forms.ComboBox();
            this.NameBookTextBox = new System.Windows.Forms.TextBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NullButton = new System.Windows.Forms.Button();
            this.ConfirmationButton = new System.Windows.Forms.Button();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.AvisoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AccessCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            this.PanelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvisoErrorProvider)).BeginInit();
            this.SuspendLayout();
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
            // NameNewCategorieTextBox
            // 
            this.NameNewCategorieTextBox.Location = new System.Drawing.Point(15, 225);
            this.NameNewCategorieTextBox.MaxLength = 10;
            this.NameNewCategorieTextBox.Name = "NameNewCategorieTextBox";
            this.NameNewCategorieTextBox.Size = new System.Drawing.Size(104, 20);
            this.NameNewCategorieTextBox.TabIndex = 2;
            this.NameNewCategorieTextBox.Visible = false;
            // 
            // NewAvatarCategorieButton
            // 
            this.NewAvatarCategorieButton.Location = new System.Drawing.Point(15, 259);
            this.NewAvatarCategorieButton.Name = "NewAvatarCategorieButton";
            this.NewAvatarCategorieButton.Size = new System.Drawing.Size(86, 23);
            this.NewAvatarCategorieButton.TabIndex = 3;
            this.NewAvatarCategorieButton.Text = "Nuevo Avatar";
            this.NewAvatarCategorieButton.UseVisualStyleBackColor = true;
            this.NewAvatarCategorieButton.Visible = false;
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IconPictureBox.Location = new System.Drawing.Point(185, 225);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(45, 45);
            this.IconPictureBox.TabIndex = 20;
            this.IconPictureBox.TabStop = false;
            // 
            // NameBookLabel
            // 
            this.NameBookLabel.AutoSize = true;
            this.NameBookLabel.Location = new System.Drawing.Point(12, 134);
            this.NameBookLabel.Name = "NameBookLabel";
            this.NameBookLabel.Size = new System.Drawing.Size(89, 13);
            this.NameBookLabel.TabIndex = 19;
            this.NameBookLabel.Text = "Nombre Del Libro";
            // 
            // CategorieLabel
            // 
            this.CategorieLabel.AutoSize = true;
            this.CategorieLabel.Location = new System.Drawing.Point(28, 181);
            this.CategorieLabel.Name = "CategorieLabel";
            this.CategorieLabel.Size = new System.Drawing.Size(52, 13);
            this.CategorieLabel.TabIndex = 18;
            this.CategorieLabel.Text = "Categoria";
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
            this.CategorieComboBox.Location = new System.Drawing.Point(113, 178);
            this.CategorieComboBox.Name = "CategorieComboBox";
            this.CategorieComboBox.Size = new System.Drawing.Size(135, 21);
            this.CategorieComboBox.TabIndex = 1;
            this.CategorieComboBox.SelectedIndexChanged += new System.EventHandler(this.CategorieComboBox_SelectedIndexChanged);
            // 
            // NameBookTextBox
            // 
            this.NameBookTextBox.Location = new System.Drawing.Point(113, 131);
            this.NameBookTextBox.MaxLength = 13;
            this.NameBookTextBox.Name = "NameBookTextBox";
            this.NameBookTextBox.Size = new System.Drawing.Size(135, 20);
            this.NameBookTextBox.TabIndex = 0;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelSuperior.Controls.Add(this.AvatarPictureBox);
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(294, 90);
            this.PanelSuperior.TabIndex = 14;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.Location = new System.Drawing.Point(128, 15);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // NullButton
            // 
            this.NullButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NullButton.BackgroundImage")));
            this.NullButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NullButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NullButton.Location = new System.Drawing.Point(218, 14);
            this.NullButton.Name = "NullButton";
            this.NullButton.Size = new System.Drawing.Size(50, 50);
            this.NullButton.TabIndex = 2;
            this.NullButton.UseVisualStyleBackColor = true;
            // 
            // ConfirmationButton
            // 
            this.ConfirmationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ConfirmationButton.BackgroundImage")));
            this.ConfirmationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ConfirmationButton.Location = new System.Drawing.Point(31, 14);
            this.ConfirmationButton.Name = "ConfirmationButton";
            this.ConfirmationButton.Size = new System.Drawing.Size(50, 50);
            this.ConfirmationButton.TabIndex = 0;
            this.ConfirmationButton.UseVisualStyleBackColor = true;
            this.ConfirmationButton.Click += new System.EventHandler(this.ConfirmationButton_Click);
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelInferior.Controls.Add(this.DeleteButton);
            this.PanelInferior.Controls.Add(this.NullButton);
            this.PanelInferior.Controls.Add(this.ConfirmationButton);
            this.PanelInferior.Location = new System.Drawing.Point(0, 334);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(295, 77);
            this.PanelInferior.TabIndex = 15;
            // 
            // AvisoErrorProvider
            // 
            this.AvisoErrorProvider.ContainerControl = this;
            // 
            // AccessCheckBox
            // 
            this.AccessCheckBox.AutoSize = true;
            this.AccessCheckBox.Location = new System.Drawing.Point(113, 299);
            this.AccessCheckBox.Name = "AccessCheckBox";
            this.AccessCheckBox.Size = new System.Drawing.Size(88, 17);
            this.AccessCheckBox.TabIndex = 4;
            this.AccessCheckBox.Text = "Acceso Libre";
            this.AccessCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoteBookModifyBookForm
            // 
            this.AcceptButton = this.ConfirmationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NullButton;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.Controls.Add(this.AccessCheckBox);
            this.Controls.Add(this.NameNewCategorieTextBox);
            this.Controls.Add(this.NewAvatarCategorieButton);
            this.Controls.Add(this.IconPictureBox);
            this.Controls.Add(this.NameBookLabel);
            this.Controls.Add(this.CategorieLabel);
            this.Controls.Add(this.CategorieComboBox);
            this.Controls.Add(this.NameBookTextBox);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.PanelInferior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteBookModifyBookForm";
            this.Text = "Modificar Libro";
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvisoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.TextBox NameNewCategorieTextBox;
        private System.Windows.Forms.Button NewAvatarCategorieButton;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Label NameBookLabel;
        private System.Windows.Forms.Label CategorieLabel;
        private System.Windows.Forms.ComboBox CategorieComboBox;
        private System.Windows.Forms.TextBox NameBookTextBox;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button NullButton;
        private System.Windows.Forms.Button ConfirmationButton;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.ErrorProvider AvisoErrorProvider;
        private System.Windows.Forms.CheckBox AccessCheckBox;
    }
}