namespace NoteBook
{
    partial class NoteBookSignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookSignInForm));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmationButton = new System.Windows.Forms.Button();
            this.NameUserLabel = new System.Windows.Forms.Label();
            this.PasswordUserLabel = new System.Windows.Forms.Label();
            this.NameUserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordUserTextBox = new System.Windows.Forms.TextBox();
            this.verificationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verificationErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelSuperior.Controls.Add(this.AvatarPictureBox);
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(295, 90);
            this.PanelSuperior.TabIndex = 2;
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
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelInferior.Controls.Add(this.CancelButton);
            this.panelInferior.Controls.Add(this.ConfirmationButton);
            this.panelInferior.Location = new System.Drawing.Point(0, 335);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(295, 77);
            this.panelInferior.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelButton.BackgroundImage")));
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton.Location = new System.Drawing.Point(169, 14);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(50, 50);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            // NameUserLabel
            // 
            this.NameUserLabel.AutoSize = true;
            this.NameUserLabel.Location = new System.Drawing.Point(128, 124);
            this.NameUserLabel.Name = "NameUserLabel";
            this.NameUserLabel.Size = new System.Drawing.Size(43, 13);
            this.NameUserLabel.TabIndex = 4;
            this.NameUserLabel.Text = "Usuario";
            this.NameUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordUserLabel
            // 
            this.PasswordUserLabel.AutoSize = true;
            this.PasswordUserLabel.Location = new System.Drawing.Point(117, 209);
            this.PasswordUserLabel.Name = "PasswordUserLabel";
            this.PasswordUserLabel.Size = new System.Drawing.Size(61, 13);
            this.PasswordUserLabel.TabIndex = 5;
            this.PasswordUserLabel.Text = "Contraseña";
            // 
            // NameUserTextBox
            // 
            this.NameUserTextBox.Location = new System.Drawing.Point(88, 140);
            this.NameUserTextBox.Name = "NameUserTextBox";
            this.NameUserTextBox.Size = new System.Drawing.Size(131, 20);
            this.NameUserTextBox.TabIndex = 0;
            this.NameUserTextBox.Leave += new System.EventHandler(this.NameUserTextBox_Leave);
            // 
            // PasswordUserTextBox
            // 
            this.PasswordUserTextBox.Location = new System.Drawing.Point(88, 225);
            this.PasswordUserTextBox.Name = "PasswordUserTextBox";
            this.PasswordUserTextBox.PasswordChar = '*';
            this.PasswordUserTextBox.Size = new System.Drawing.Size(131, 20);
            this.PasswordUserTextBox.TabIndex = 1;
            this.PasswordUserTextBox.Leave += new System.EventHandler(this.PasswordUserTextBox_Leave);
            // 
            // verificationErrorProvider
            // 
            this.verificationErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.verificationErrorProvider.ContainerControl = this;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(110, 288);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 8;
            // 
            // NoteBookSignInForm
            // 
            this.AcceptButton = this.ConfirmationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.ControlBox = false;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.PasswordUserTextBox);
            this.Controls.Add(this.NameUserTextBox);
            this.Controls.Add(this.PasswordUserLabel);
            this.Controls.Add(this.NameUserLabel);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookSignInForm";
            this.Text = "Inicio Sesion";
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verificationErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmationButton;
        private System.Windows.Forms.Label NameUserLabel;
        private System.Windows.Forms.Label PasswordUserLabel;
        private System.Windows.Forms.TextBox NameUserTextBox;
        private System.Windows.Forms.TextBox PasswordUserTextBox;
        private System.Windows.Forms.ErrorProvider verificationErrorProvider;
        private System.Windows.Forms.Label errorLabel;
    }
}