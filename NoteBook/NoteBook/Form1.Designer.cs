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
            this.CategoriaLlabel = new System.Windows.Forms.Label();
            this.CategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.PrivacidadCheckBox = new System.Windows.Forms.CheckBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.InferiorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(61, 98);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(36, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Titulo:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(133, 98);
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
            // CategoriaLlabel
            // 
            this.CategoriaLlabel.AutoSize = true;
            this.CategoriaLlabel.Location = new System.Drawing.Point(61, 150);
            this.CategoriaLlabel.Name = "CategoriaLlabel";
            this.CategoriaLlabel.Size = new System.Drawing.Size(55, 13);
            this.CategoriaLlabel.TabIndex = 4;
            this.CategoriaLlabel.Text = "Categoria:";
            // 
            // CategoriaComboBox
            // 
            this.CategoriaComboBox.FormattingEnabled = true;
            this.CategoriaComboBox.Location = new System.Drawing.Point(133, 147);
            this.CategoriaComboBox.Name = "CategoriaComboBox";
            this.CategoriaComboBox.Size = new System.Drawing.Size(124, 21);
            this.CategoriaComboBox.TabIndex = 5;
            // 
            // PrivacidadCheckBox
            // 
            this.PrivacidadCheckBox.AutoSize = true;
            this.PrivacidadCheckBox.Location = new System.Drawing.Point(64, 252);
            this.PrivacidadCheckBox.Name = "PrivacidadCheckBox";
            this.PrivacidadCheckBox.Size = new System.Drawing.Size(76, 17);
            this.PrivacidadCheckBox.TabIndex = 6;
            this.PrivacidadCheckBox.Text = "Privacidad";
            this.PrivacidadCheckBox.UseVisualStyleBackColor = true;
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(64, 197);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 7;
            this.ColorLabel.Text = "Color:";
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Location = new System.Drawing.Point(133, 197);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(124, 21);
            this.ColorComboBox.TabIndex = 8;
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
            // 
            // EditNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(419, 410);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.PrivacidadCheckBox);
            this.Controls.Add(this.CategoriaComboBox);
            this.Controls.Add(this.CategoriaLlabel);
            this.Controls.Add(this.InferiorPanel);
            this.Controls.Add(this.PrincipalPanel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
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
        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
    }
}