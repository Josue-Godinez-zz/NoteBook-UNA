namespace NoteBook
{
    partial class EditNoteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNoteForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.PrincipalPanel = new System.Windows.Forms.Panel();
            this.InferiorPanel = new System.Windows.Forms.Panel();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CategoriaLlabel = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.PrivacidadCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ContenidoLabel = new System.Windows.Forms.Label();
            this.ContenidoTextBox = new System.Windows.Forms.TextBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ColorNota = new System.Windows.Forms.ColorDialog();
            this.ColorLetraabel = new System.Windows.Forms.Label();
            this.ColorLetraButton = new System.Windows.Forms.Button();
            this.Fuente = new System.Windows.Forms.FontDialog();
            this.FuenteButton = new System.Windows.Forms.Button();
            this.InferiorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(61, 69);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(36, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Titulo:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(133, 69);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(124, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // PrincipalPanel
            // 
            this.PrincipalPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(232)))), ((int)(((byte)(200)))));
            this.PrincipalPanel.Location = new System.Drawing.Point(0, 0);
            this.PrincipalPanel.Name = "PrincipalPanel";
            this.PrincipalPanel.Size = new System.Drawing.Size(419, 44);
            this.PrincipalPanel.TabIndex = 2;
            // 
            // InferiorPanel
            // 
            this.InferiorPanel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.InferiorPanel.Controls.Add(this.CancelarButton);
            this.InferiorPanel.Controls.Add(this.GuardarButton);
            this.InferiorPanel.Location = new System.Drawing.Point(0, 358);
            this.InferiorPanel.Name = "InferiorPanel";
            this.InferiorPanel.Size = new System.Drawing.Size(419, 53);
            this.InferiorPanel.TabIndex = 3;
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelarButton.BackgroundImage")));
            this.CancelarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelarButton.Location = new System.Drawing.Point(298, 6);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(40, 40);
            this.CancelarButton.TabIndex = 1;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GuardarButton.BackgroundImage")));
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.GuardarButton.Location = new System.Drawing.Point(76, 6);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(40, 40);
            this.GuardarButton.TabIndex = 0;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CategoriaLlabel
            // 
            this.CategoriaLlabel.AutoSize = true;
            this.CategoriaLlabel.Location = new System.Drawing.Point(61, 105);
            this.CategoriaLlabel.Name = "CategoriaLlabel";
            this.CategoriaLlabel.Size = new System.Drawing.Size(55, 13);
            this.CategoriaLlabel.TabIndex = 4;
            this.CategoriaLlabel.Text = "Categoria:";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(133, 105);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(124, 21);
            this.CategoriaComboBox.TabIndex = 5;
            // 
            // PrivacidadCheckBox
            // 
            this.PrivacidadCheckBox.AutoSize = true;
            this.PrivacidadCheckBox.Location = new System.Drawing.Point(64, 326);
            this.PrivacidadCheckBox.Name = "PrivacidadCheckBox";
            this.PrivacidadCheckBox.Size = new System.Drawing.Size(76, 17);
            this.PrivacidadCheckBox.TabIndex = 6;
            this.PrivacidadCheckBox.Text = "Privacidad";
            this.PrivacidadCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(64, 144);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(67, 13);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color Fondo:";
            // 
            // ContenidoLabel
            // 
            this.ContenidoLabel.AutoSize = true;
            this.ContenidoLabel.Location = new System.Drawing.Point(64, 186);
            this.ContenidoLabel.Name = "ContenidoLabel";
            this.ContenidoLabel.Size = new System.Drawing.Size(98, 13);
            this.ContenidoLabel.TabIndex = 10;
            this.ContenidoLabel.Text = "Agregar Contenido:";
            // 
            // ContenidoTextBox
            // 
            this.ContenidoTextBox.Location = new System.Drawing.Point(64, 213);
            this.ContenidoTextBox.Multiline = true;
            this.ContenidoTextBox.Name = "ContenidoTextBox";
            this.ContenidoTextBox.Size = new System.Drawing.Size(193, 99);
            this.ContenidoTextBox.TabIndex = 11;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(133, 139);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(23, 23);
            this.ColorButton.TabIndex = 12;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ColorLetraabel
            // 
            this.ColorLetraabel.AutoSize = true;
            this.ColorLetraabel.Location = new System.Drawing.Point(167, 144);
            this.ColorLetraabel.Name = "ColorLetraabel";
            this.ColorLetraabel.Size = new System.Drawing.Size(61, 13);
            this.ColorLetraabel.TabIndex = 13;
            this.ColorLetraabel.Text = "Color Letra:";
            // 
            // ColorLetraButton
            // 
            this.ColorLetraButton.Location = new System.Drawing.Point(234, 139);
            this.ColorLetraButton.Name = "ColorLetraButton";
            this.ColorLetraButton.Size = new System.Drawing.Size(23, 23);
            this.ColorLetraButton.TabIndex = 14;
            this.ColorLetraButton.UseVisualStyleBackColor = true;
            this.ColorLetraButton.Click += new System.EventHandler(this.ColorLetraButton_Click);
            // 
            // FuenteButton
            // 
            this.FuenteButton.Location = new System.Drawing.Point(334, 138);
            this.FuenteButton.Name = "FuenteButton";
            this.FuenteButton.Size = new System.Drawing.Size(75, 23);
            this.FuenteButton.TabIndex = 15;
            this.FuenteButton.Text = "AaBb";
            this.FuenteButton.UseVisualStyleBackColor = true;
            this.FuenteButton.Click += new System.EventHandler(this.FuenteButton_Click);
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(419, 410);
            this.Controls.Add(this.FuenteButton);
            this.Controls.Add(this.ColorLetraButton);
            this.Controls.Add(this.ColorLetraabel);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.ContenidoTextBox);
            this.Controls.Add(this.ContenidoLabel);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.PrivacidadCheckBox);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.CategoriaLlabel);
            this.Controls.Add(this.InferiorPanel);
            this.Controls.Add(this.PrincipalPanel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditNoteForm";
            this.Text = "Form1";
            this.InferiorPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Panel PrincipalPanel;
        private System.Windows.Forms.Panel InferiorPanel;
        private System.Windows.Forms.Label CategoriaLlabel;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.CheckBox PrivacidadCheckBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label ContenidoLabel;
        private System.Windows.Forms.TextBox ContenidoTextBox;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog ColorNota;
        private System.Windows.Forms.Label ColorLetraabel;
        private System.Windows.Forms.Button ColorLetraButton;
        private System.Windows.Forms.FontDialog Fuente;
        private System.Windows.Forms.Button FuenteButton;
    }
}