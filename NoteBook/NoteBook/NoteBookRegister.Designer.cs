namespace NoteBook
{
    partial class NoteBookRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookRegister));
            this.iconRegisterPictureBox = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.nameUserLabel = new System.Windows.Forms.Label();
            this.nameUserTextBox = new System.Windows.Forms.TextBox();
            this.passwordUserLabel = new System.Windows.Forms.Label();
            this.passwordUserTextBox = new System.Windows.Forms.TextBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmationButton = new System.Windows.Forms.Button();
            this.confirmationPasswordLabel = new System.Windows.Forms.Label();
            this.confirmationPasswordTextBox = new System.Windows.Forms.TextBox();
            this.verificationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconRegisterPictureBox)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verificationErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // iconRegisterPictureBox
            // 
            this.iconRegisterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("iconRegisterPictureBox.Image")));
            this.iconRegisterPictureBox.Location = new System.Drawing.Point(113, 12);
            this.iconRegisterPictureBox.Name = "iconRegisterPictureBox";
            this.iconRegisterPictureBox.Size = new System.Drawing.Size(65, 65);
            this.iconRegisterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconRegisterPictureBox.TabIndex = 0;
            this.iconRegisterPictureBox.TabStop = false;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelSuperior.Controls.Add(this.iconRegisterPictureBox);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(295, 90);
            this.panelSuperior.TabIndex = 1;
            // 
            // nameUserLabel
            // 
            this.nameUserLabel.AutoSize = true;
            this.nameUserLabel.Location = new System.Drawing.Point(92, 105);
            this.nameUserLabel.Name = "nameUserLabel";
            this.nameUserLabel.Size = new System.Drawing.Size(106, 13);
            this.nameUserLabel.TabIndex = 2;
            this.nameUserLabel.Text = "Nombre De Usuaraio";
            this.nameUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameUserTextBox
            // 
            this.nameUserTextBox.Location = new System.Drawing.Point(73, 121);
            this.nameUserTextBox.MaxLength = 15;
            this.nameUserTextBox.Name = "nameUserTextBox";
            this.nameUserTextBox.Size = new System.Drawing.Size(138, 20);
            this.nameUserTextBox.TabIndex = 3;
            this.nameUserTextBox.Leave += new System.EventHandler(this.nameUserTextBox_Leave);
            // 
            // passwordUserLabel
            // 
            this.passwordUserLabel.AutoSize = true;
            this.passwordUserLabel.Location = new System.Drawing.Point(81, 171);
            this.passwordUserLabel.Name = "passwordUserLabel";
            this.passwordUserLabel.Size = new System.Drawing.Size(117, 13);
            this.passwordUserLabel.TabIndex = 4;
            this.passwordUserLabel.Text = "Contraseña De Usuario";
            // 
            // passwordUserTextBox
            // 
            this.passwordUserTextBox.Location = new System.Drawing.Point(73, 187);
            this.passwordUserTextBox.MaxLength = 10;
            this.passwordUserTextBox.Name = "passwordUserTextBox";
            this.passwordUserTextBox.PasswordChar = '*';
            this.passwordUserTextBox.Size = new System.Drawing.Size(138, 20);
            this.passwordUserTextBox.TabIndex = 5;
            this.passwordUserTextBox.Leave += new System.EventHandler(this.passwordUserTextBox_Leave);
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelInferior.Controls.Add(this.cancelButton);
            this.panelInferior.Controls.Add(this.confirmationButton);
            this.panelInferior.Location = new System.Drawing.Point(0, 335);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(295, 77);
            this.panelInferior.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Location = new System.Drawing.Point(169, 14);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(50, 50);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // confirmationButton
            // 
            this.confirmationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmationButton.BackgroundImage")));
            this.confirmationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmationButton.Location = new System.Drawing.Point(60, 14);
            this.confirmationButton.Name = "confirmationButton";
            this.confirmationButton.Size = new System.Drawing.Size(50, 50);
            this.confirmationButton.TabIndex = 0;
            this.confirmationButton.UseVisualStyleBackColor = true;
            this.confirmationButton.Click += new System.EventHandler(this.confirmationButton_Click);
            // 
            // confirmationPasswordLabel
            // 
            this.confirmationPasswordLabel.AutoSize = true;
            this.confirmationPasswordLabel.Location = new System.Drawing.Point(81, 233);
            this.confirmationPasswordLabel.Name = "confirmationPasswordLabel";
            this.confirmationPasswordLabel.Size = new System.Drawing.Size(108, 13);
            this.confirmationPasswordLabel.TabIndex = 6;
            this.confirmationPasswordLabel.Text = "Confirmar Contraseña";
            // 
            // confirmationPasswordTextBox
            // 
            this.confirmationPasswordTextBox.Location = new System.Drawing.Point(73, 249);
            this.confirmationPasswordTextBox.MaxLength = 10;
            this.confirmationPasswordTextBox.Name = "confirmationPasswordTextBox";
            this.confirmationPasswordTextBox.PasswordChar = '*';
            this.confirmationPasswordTextBox.Size = new System.Drawing.Size(138, 20);
            this.confirmationPasswordTextBox.TabIndex = 7;
            this.confirmationPasswordTextBox.Leave += new System.EventHandler(this.confirmationPasswordTextBox_Leave);
            // 
            // verificationErrorProvider
            // 
            this.verificationErrorProvider.ContainerControl = this;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(92, 295);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 8;
            // 
            // NoteBookRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.confirmationPasswordTextBox);
            this.Controls.Add(this.confirmationPasswordLabel);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.passwordUserTextBox);
            this.Controls.Add(this.passwordUserLabel);
            this.Controls.Add(this.nameUserTextBox);
            this.Controls.Add(this.nameUserLabel);
            this.Controls.Add(this.panelSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoteBookRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NoteBook-Registro";
            ((System.ComponentModel.ISupportInitialize)(this.iconRegisterPictureBox)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verificationErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox iconRegisterPictureBox;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label nameUserLabel;
        private System.Windows.Forms.TextBox nameUserTextBox;
        private System.Windows.Forms.Label passwordUserLabel;
        private System.Windows.Forms.TextBox passwordUserTextBox;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmationButton;
        private System.Windows.Forms.Label confirmationPasswordLabel;
        private System.Windows.Forms.TextBox confirmationPasswordTextBox;
        private System.Windows.Forms.ErrorProvider verificationErrorProvider;
        private System.Windows.Forms.Label errorLabel;
    }
}