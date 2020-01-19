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
            this.PanelSuperior.SuspendLayout();
            this.PanelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(171, 21);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(67, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "NOTEBOOK";
            // 
            // SignUpButton
            // 
            this.SignUpButton.Location = new System.Drawing.Point(79, 19);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(80, 23);
            this.SignUpButton.TabIndex = 1;
            this.SignUpButton.Text = "Registrarse";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SignInButton.Enabled = false;
            this.SignInButton.ForeColor = System.Drawing.Color.Black;
            this.SignInButton.Location = new System.Drawing.Point(244, 19);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(80, 23);
            this.SignInButton.TabIndex = 2;
            this.SignInButton.Text = "Iniciar Sesión";
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
            this.PanelInferior.Controls.Add(this.SignUpButton);
            this.PanelInferior.Controls.Add(this.SignInButton);
            this.PanelInferior.Location = new System.Drawing.Point(0, 224);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(396, 55);
            this.PanelInferior.TabIndex = 1;
            // 
            // Texto1Label
            // 
            this.Texto1Label.AutoSize = true;
            this.Texto1Label.Location = new System.Drawing.Point(139, 85);
            this.Texto1Label.Name = "Texto1Label";
            this.Texto1Label.Size = new System.Drawing.Size(120, 13);
            this.Texto1Label.TabIndex = 4;
            this.Texto1Label.Text = "Bienvenido a NoteBook";
            // 
            // NoteBookWelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 278);
            this.ControlBox = false;
            this.Controls.Add(this.Texto1Label);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookWelcomeForm";
            this.Text = "NoteBookWelcomeForm";
            this.PanelSuperior.ResumeLayout(false);
            this.PanelSuperior.PerformLayout();
            this.PanelInferior.ResumeLayout(false);
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
    }
}