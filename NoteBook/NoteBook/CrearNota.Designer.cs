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
            this.CategoriaLlabel = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.PrivacidadCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ContenidoTextBox = new System.Windows.Forms.TextBox();
            this.ColorButton = new System.Windows.Forms.Button();
            this.ColorNota = new System.Windows.Forms.ColorDialog();
            this.ColorLetraabel = new System.Windows.Forms.Label();
            this.ColorLetraButton = new System.Windows.Forms.Button();
            this.Fuente = new System.Windows.Forms.FontDialog();
            this.FuenteButton = new System.Windows.Forms.Button();
            this.FuenteLabel = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(150, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(48, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Titulo:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(239, 6);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(142, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // CategoriaLlabel
            // 
            this.CategoriaLlabel.AutoSize = true;
            this.CategoriaLlabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoriaLlabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLlabel.Location = new System.Drawing.Point(150, 47);
            this.CategoriaLlabel.Name = "CategoriaLlabel";
            this.CategoriaLlabel.Size = new System.Drawing.Size(74, 15);
            this.CategoriaLlabel.TabIndex = 4;
            this.CategoriaLlabel.Text = "Categoria:";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(239, 41);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(142, 21);
            this.CategoriaComboBox.TabIndex = 5;
            // 
            // PrivacidadCheckBox
            // 
            this.PrivacidadCheckBox.AutoSize = true;
            this.PrivacidadCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.PrivacidadCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivacidadCheckBox.Location = new System.Drawing.Point(12, 210);
            this.PrivacidadCheckBox.Name = "PrivacidadCheckBox";
            this.PrivacidadCheckBox.Size = new System.Drawing.Size(98, 19);
            this.PrivacidadCheckBox.TabIndex = 6;
            this.PrivacidadCheckBox.Text = "Privacidad";
            this.PrivacidadCheckBox.UseVisualStyleBackColor = false;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.BackColor = System.Drawing.Color.Transparent;
            this.ColorLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLabel.Location = new System.Drawing.Point(6, 104);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(86, 15);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color Fondo:";
            // 
            // ContenidoTextBox
            // 
            this.ContenidoTextBox.Location = new System.Drawing.Point(153, 82);
            this.ContenidoTextBox.Multiline = true;
            this.ContenidoTextBox.Name = "ContenidoTextBox";
            this.ContenidoTextBox.Size = new System.Drawing.Size(228, 237);
            this.ContenidoTextBox.TabIndex = 11;
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(98, 99);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(23, 23);
            this.ColorButton.TabIndex = 12;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // ColorLetraabel
            // 
            this.ColorLetraabel.AutoSize = true;
            this.ColorLetraabel.BackColor = System.Drawing.Color.Transparent;
            this.ColorLetraabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorLetraabel.Location = new System.Drawing.Point(6, 159);
            this.ColorLetraabel.Name = "ColorLetraabel";
            this.ColorLetraabel.Size = new System.Drawing.Size(80, 15);
            this.ColorLetraabel.TabIndex = 13;
            this.ColorLetraabel.Text = "Color Letra:";
            // 
            // ColorLetraButton
            // 
            this.ColorLetraButton.Location = new System.Drawing.Point(98, 159);
            this.ColorLetraButton.Name = "ColorLetraButton";
            this.ColorLetraButton.Size = new System.Drawing.Size(23, 23);
            this.ColorLetraButton.TabIndex = 14;
            this.ColorLetraButton.UseVisualStyleBackColor = true;
            this.ColorLetraButton.Click += new System.EventHandler(this.ColorLetraButton_Click);
            // 
            // FuenteButton
            // 
            this.FuenteButton.BackColor = System.Drawing.Color.Transparent;
            this.FuenteButton.Location = new System.Drawing.Point(71, 260);
            this.FuenteButton.Name = "FuenteButton";
            this.FuenteButton.Size = new System.Drawing.Size(50, 23);
            this.FuenteButton.TabIndex = 15;
            this.FuenteButton.Text = "AaBb";
            this.FuenteButton.UseVisualStyleBackColor = false;
            this.FuenteButton.Click += new System.EventHandler(this.FuenteButton_Click);
            // 
            // FuenteLabel
            // 
            this.FuenteLabel.AutoSize = true;
            this.FuenteLabel.BackColor = System.Drawing.Color.Transparent;
            this.FuenteLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuenteLabel.Location = new System.Drawing.Point(9, 265);
            this.FuenteLabel.Name = "FuenteLabel";
            this.FuenteLabel.Size = new System.Drawing.Size(53, 15);
            this.FuenteLabel.TabIndex = 16;
            this.FuenteLabel.Text = "Fuente:";
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(15, 345);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 0;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButton.Image")));
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.Location = new System.Drawing.Point(303, 345);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(78, 23);
            this.CancelarButton.TabIndex = 1;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 379);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.FuenteLabel);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.FuenteButton);
            this.Controls.Add(this.ColorLetraButton);
            this.Controls.Add(this.ColorLetraabel);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.ContenidoTextBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.PrivacidadCheckBox);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.CategoriaLlabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditNoteForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CategoriaLlabel;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.CheckBox PrivacidadCheckBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ContenidoTextBox;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog ColorNota;
        private System.Windows.Forms.Label ColorLetraabel;
        private System.Windows.Forms.Button ColorLetraButton;
        private System.Windows.Forms.FontDialog Fuente;
        private System.Windows.Forms.Button FuenteButton;
        private System.Windows.Forms.Label FuenteLabel;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
    }
}