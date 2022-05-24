namespace NoteBook
{
    partial class NoteBookWelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookWelcomeForm));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.Texto1Label = new System.Windows.Forms.Label();
            this.Texto2Label = new System.Windows.Forms.Label();
            this.Texto4Label = new System.Windows.Forms.Label();
            this.Texto3Label = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.SignInLabel = new System.Windows.Forms.Label();
            this.PanelSuperior.SuspendLayout();
            this.PanelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(161, 18);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(91, 16);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "NOTEBOOK";
            // 
            // SignUpButton
            // 
            this.SignUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpButton.BackgroundImage")));
            this.SignUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignUpButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUpButton.Location = new System.Drawing.Point(102, 17);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(45, 45);
            this.SignUpButton.TabIndex = 0;
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SignInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignInButton.BackgroundImage")));
            this.SignInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignInButton.ForeColor = System.Drawing.Color.Black;
            this.SignInButton.Location = new System.Drawing.Point(254, 17);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(45, 49);
            this.SignInButton.TabIndex = 1;
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelSuperior.Controls.Add(this.TitleLabel);
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(396, 51);
            this.PanelSuperior.TabIndex = 3;
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelInferior.Controls.Add(this.SignInLabel);
            this.PanelInferior.Controls.Add(this.RegisterLabel);
            this.PanelInferior.Controls.Add(this.SignUpButton);
            this.PanelInferior.Controls.Add(this.SignInButton);
            this.PanelInferior.Location = new System.Drawing.Point(0, 215);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(396, 69);
            this.PanelInferior.TabIndex = 1;
            // 
            // Texto1Label
            // 
            this.Texto1Label.AutoSize = true;
            this.Texto1Label.Location = new System.Drawing.Point(142, 70);
            this.Texto1Label.Name = "Texto1Label";
            this.Texto1Label.Size = new System.Drawing.Size(120, 13);
            this.Texto1Label.TabIndex = 4;
            this.Texto1Label.Text = "Bienvenido a NoteBook";
            // 
            // Texto2Label
            // 
            this.Texto2Label.AutoSize = true;
            this.Texto2Label.Location = new System.Drawing.Point(94, 98);
            this.Texto2Label.Name = "Texto2Label";
            this.Texto2Label.Size = new System.Drawing.Size(230, 13);
            this.Texto2Label.TabIndex = 5;
            this.Texto2Label.Text = "Registrate para comenzar a utilizar \"NoteBook\"";
            // 
            // Texto4Label
            // 
            this.Texto4Label.AutoSize = true;
            this.Texto4Label.Location = new System.Drawing.Point(86, 147);
            this.Texto4Label.Name = "Texto4Label";
            this.Texto4Label.Size = new System.Drawing.Size(238, 13);
            this.Texto4Label.TabIndex = 6;
            this.Texto4Label.Text = "Inicie Sesion para acceder  a contenido personal";
            // 
            // Texto3Label
            // 
            this.Texto3Label.AutoSize = true;
            this.Texto3Label.Location = new System.Drawing.Point(191, 123);
            this.Texto3Label.Name = "Texto3Label";
            this.Texto3Label.Size = new System.Drawing.Size(13, 13);
            this.Texto3Label.TabIndex = 7;
            this.Texto3Label.Text = "o";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(95, 5);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(60, 13);
            this.RegisterLabel.TabIndex = 2;
            this.RegisterLabel.Text = "Registrarse";
            // 
            // SignInLabel
            // 
            this.SignInLabel.AutoSize = true;
            this.SignInLabel.Location = new System.Drawing.Point(244, 5);
            this.SignInLabel.Name = "SignInLabel";
            this.SignInLabel.Size = new System.Drawing.Size(67, 13);
            this.SignInLabel.TabIndex = 3;
            this.SignInLabel.Text = "Inicio Sesión";
            // 
            // NoteBookWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 284);
            this.Controls.Add(this.Texto3Label);
            this.Controls.Add(this.Texto4Label);
            this.Controls.Add(this.Texto2Label);
            this.Controls.Add(this.Texto1Label);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookWelcomeForm";
            this.Text = "Bienvenido a NoteBook";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.PanelInferior.ResumeLayout(false);
            this.PanelInferior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Label Texto1Label;
        private System.Windows.Forms.Label Texto2Label;
        private System.Windows.Forms.Label Texto4Label;
        private System.Windows.Forms.Label Texto3Label;
        private System.Windows.Forms.Label SignInLabel;
        private System.Windows.Forms.Label RegisterLabel;
    }
}