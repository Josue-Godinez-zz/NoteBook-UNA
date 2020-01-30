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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNoteForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.CategoriaLlabel = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.PrivacidadCheckBox = new System.Windows.Forms.CheckBox();
            this.ContenidoTextBox = new System.Windows.Forms.TextBox();
            this.ColorNota = new System.Windows.Forms.ColorDialog();
            this.Fuente = new System.Windows.Forms.FontDialog();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AvisoErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FondoButton = new System.Windows.Forms.Button();
            this.FuenteButton = new System.Windows.Forms.Button();
            this.LetraButton = new System.Windows.Forms.Button();
            this.FondoLabel = new System.Windows.Forms.Label();
            this.LetraLabel = new System.Windows.Forms.Label();
            this.FuenteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvisoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(126, 24);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(48, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Titulo:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(228, 19);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(142, 20);
            this.TitleTextBox.TabIndex = 0;
            // 
            // CategoriaLlabel
            // 
            this.CategoriaLlabel.AutoSize = true;
            this.CategoriaLlabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoriaLlabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLlabel.Location = new System.Drawing.Point(126, 50);
            this.CategoriaLlabel.Name = "CategoriaLlabel";
            this.CategoriaLlabel.Size = new System.Drawing.Size(74, 15);
            this.CategoriaLlabel.TabIndex = 4;
            this.CategoriaLlabel.Text = "Categoria:";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(228, 44);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(142, 21);
            this.CategoriaComboBox.TabIndex = 1;
            // 
            // PrivacidadCheckBox
            // 
            this.PrivacidadCheckBox.AutoSize = true;
            this.PrivacidadCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.PrivacidadCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivacidadCheckBox.Location = new System.Drawing.Point(6, 250);
            this.PrivacidadCheckBox.Name = "PrivacidadCheckBox";
            this.PrivacidadCheckBox.Size = new System.Drawing.Size(98, 19);
            this.PrivacidadCheckBox.TabIndex = 3;
            this.PrivacidadCheckBox.Text = "Privacidad";
            this.PrivacidadCheckBox.UseVisualStyleBackColor = false;
            // 
            // ContenidoTextBox
            // 
            this.ContenidoTextBox.Location = new System.Drawing.Point(129, 77);
            this.ContenidoTextBox.Multiline = true;
            this.ContenidoTextBox.Name = "ContenidoTextBox";
            this.ContenidoTextBox.Size = new System.Drawing.Size(241, 243);
            this.ContenidoTextBox.TabIndex = 2;
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
            this.GuardarButton.TabIndex = 4;
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
            this.CancelarButton.TabIndex = 5;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AvisoErrorProvider
            // 
            this.AvisoErrorProvider.BlinkRate = 0;
            this.AvisoErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AvisoErrorProvider.ContainerControl = this;
            // 
            // FondoButton
            // 
            this.FondoButton.Location = new System.Drawing.Point(100, 80);
            this.FondoButton.Name = "FondoButton";
            this.FondoButton.Size = new System.Drawing.Size(23, 23);
            this.FondoButton.TabIndex = 6;
            this.FondoButton.UseVisualStyleBackColor = true;
            this.FondoButton.Click += new System.EventHandler(this.FondoButton_Click);
            // 
            // FuenteButton
            // 
            this.FuenteButton.Location = new System.Drawing.Point(68, 184);
            this.FuenteButton.Name = "FuenteButton";
            this.FuenteButton.Size = new System.Drawing.Size(56, 23);
            this.FuenteButton.TabIndex = 7;
            this.FuenteButton.Text = "AaBb";
            this.FuenteButton.UseVisualStyleBackColor = true;
            this.FuenteButton.Click += new System.EventHandler(this.FuenteButton_Click);
            // 
            // LetraButton
            // 
            this.LetraButton.Location = new System.Drawing.Point(100, 134);
            this.LetraButton.Name = "LetraButton";
            this.LetraButton.Size = new System.Drawing.Size(23, 23);
            this.LetraButton.TabIndex = 8;
            this.LetraButton.UseVisualStyleBackColor = true;
            this.LetraButton.Click += new System.EventHandler(this.LetraButton_Click);
            // 
            // FondoLabel
            // 
            this.FondoLabel.AutoSize = true;
            this.FondoLabel.BackColor = System.Drawing.Color.Transparent;
            this.FondoLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FondoLabel.Location = new System.Drawing.Point(3, 85);
            this.FondoLabel.Name = "FondoLabel";
            this.FondoLabel.Size = new System.Drawing.Size(86, 15);
            this.FondoLabel.TabIndex = 9;
            this.FondoLabel.Text = "Color Fondo:";
            // 
            // LetraLabel
            // 
            this.LetraLabel.AutoSize = true;
            this.LetraLabel.BackColor = System.Drawing.Color.Transparent;
            this.LetraLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetraLabel.Location = new System.Drawing.Point(3, 134);
            this.LetraLabel.Name = "LetraLabel";
            this.LetraLabel.Size = new System.Drawing.Size(80, 15);
            this.LetraLabel.TabIndex = 10;
            this.LetraLabel.Text = "Color Letra:";
            // 
            // FuenteLabel
            // 
            this.FuenteLabel.AutoSize = true;
            this.FuenteLabel.BackColor = System.Drawing.Color.Transparent;
            this.FuenteLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuenteLabel.Location = new System.Drawing.Point(3, 192);
            this.FuenteLabel.Name = "FuenteLabel";
            this.FuenteLabel.Size = new System.Drawing.Size(53, 15);
            this.FuenteLabel.TabIndex = 11;
            this.FuenteLabel.Text = "Fuente:";
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(393, 379);
            this.ControlBox = false;
            this.Controls.Add(this.FuenteLabel);
            this.Controls.Add(this.LetraLabel);
            this.Controls.Add(this.FondoLabel);
            this.Controls.Add(this.LetraButton);
            this.Controls.Add(this.FuenteButton);
            this.Controls.Add(this.FondoButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ContenidoTextBox);
            this.Controls.Add(this.PrivacidadCheckBox);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.CategoriaLlabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditNoteForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AvisoErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label CategoriaLlabel;
        private System.Windows.Forms.ComboBox CategoriaComboBox;
        private System.Windows.Forms.CheckBox PrivacidadCheckBox;
        private System.Windows.Forms.TextBox ContenidoTextBox;
        private System.Windows.Forms.ColorDialog ColorNota;
        private System.Windows.Forms.FontDialog Fuente;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ErrorProvider AvisoErrorProvider;
        private System.Windows.Forms.Button FondoButton;
        private System.Windows.Forms.Button FuenteButton;
        private System.Windows.Forms.Button LetraButton;
        private System.Windows.Forms.Label FuenteLabel;
        private System.Windows.Forms.Label LetraLabel;
        private System.Windows.Forms.Label FondoLabel;
    }
}