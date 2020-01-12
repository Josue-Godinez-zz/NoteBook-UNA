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
            ((System.ComponentModel.ISupportInitialize)(this.AvisoErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(89, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(48, 15);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Titulo:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(39, 27);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(142, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // CategoriaLlabel
            // 
            this.CategoriaLlabel.AutoSize = true;
            this.CategoriaLlabel.BackColor = System.Drawing.Color.Transparent;
            this.CategoriaLlabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLlabel.Location = new System.Drawing.Point(242, 9);
            this.CategoriaLlabel.Name = "CategoriaLlabel";
            this.CategoriaLlabel.Size = new System.Drawing.Size(74, 15);
            this.CategoriaLlabel.TabIndex = 4;
            this.CategoriaLlabel.Text = "Categoria:";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(209, 27);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(142, 21);
            this.CategoriaComboBox.TabIndex = 5;
            // 
            // PrivacidadCheckBox
            // 
            this.PrivacidadCheckBox.AutoSize = true;
            this.PrivacidadCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.PrivacidadCheckBox.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivacidadCheckBox.Location = new System.Drawing.Point(39, 306);
            this.PrivacidadCheckBox.Name = "PrivacidadCheckBox";
            this.PrivacidadCheckBox.Size = new System.Drawing.Size(98, 19);
            this.PrivacidadCheckBox.TabIndex = 6;
            this.PrivacidadCheckBox.Text = "Privacidad";
            this.PrivacidadCheckBox.UseVisualStyleBackColor = false;
            // 
            // ContenidoTextBox
            // 
            this.ContenidoTextBox.Location = new System.Drawing.Point(39, 63);
            this.ContenidoTextBox.Multiline = true;
            this.ContenidoTextBox.Name = "ContenidoTextBox";
            this.ContenidoTextBox.Size = new System.Drawing.Size(312, 237);
            this.ContenidoTextBox.TabIndex = 11;
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
            // AvisoErrorProvider
            // 
            this.AvisoErrorProvider.BlinkRate = 0;
            this.AvisoErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.AvisoErrorProvider.ContainerControl = this;
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
    }
}