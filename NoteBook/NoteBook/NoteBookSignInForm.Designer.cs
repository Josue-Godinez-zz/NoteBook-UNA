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
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmationButton = new System.Windows.Forms.Button();
            this.nameUserLabel = new System.Windows.Forms.Label();
            this.passwordUserLabel = new System.Windows.Forms.Label();
            this.nameUserTextBox = new System.Windows.Forms.TextBox();
            this.passwordUserTextBox = new System.Windows.Forms.TextBox();
            this.verificationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorLabel = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verificationErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(295, 90);
            this.panelSuperior.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelInferior.Controls.Add(this.cancelButton);
            this.panelInferior.Controls.Add(this.confirmationButton);
            this.panelInferior.Location = new System.Drawing.Point(0, 335);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(295, 77);
            this.panelInferior.TabIndex = 3;
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
            // nameUserLabel
            // 
            this.nameUserLabel.AutoSize = true;
            this.nameUserLabel.Location = new System.Drawing.Point(128, 124);
            this.nameUserLabel.Name = "nameUserLabel";
            this.nameUserLabel.Size = new System.Drawing.Size(43, 13);
            this.nameUserLabel.TabIndex = 4;
            this.nameUserLabel.Text = "Usuario";
            this.nameUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordUserLabel
            // 
            this.passwordUserLabel.AutoSize = true;
            this.passwordUserLabel.Location = new System.Drawing.Point(117, 209);
            this.passwordUserLabel.Name = "passwordUserLabel";
            this.passwordUserLabel.Size = new System.Drawing.Size(61, 13);
            this.passwordUserLabel.TabIndex = 5;
            this.passwordUserLabel.Text = "Contraseña";
            // 
            // nameUserTextBox
            // 
            this.nameUserTextBox.Location = new System.Drawing.Point(88, 140);
            this.nameUserTextBox.Name = "nameUserTextBox";
            this.nameUserTextBox.Size = new System.Drawing.Size(131, 20);
            this.nameUserTextBox.TabIndex = 6;
            this.nameUserTextBox.Leave += new System.EventHandler(this.nameUserTextBox_Leave);
            // 
            // passwordUserTextBox
            // 
            this.passwordUserTextBox.Location = new System.Drawing.Point(88, 225);
            this.passwordUserTextBox.Name = "passwordUserTextBox";
            this.passwordUserTextBox.PasswordChar = '*';
            this.passwordUserTextBox.Size = new System.Drawing.Size(131, 20);
            this.passwordUserTextBox.TabIndex = 7;
            this.passwordUserTextBox.Leave += new System.EventHandler(this.passwordUserTextBox_Leave);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.ControlBox = false;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.passwordUserTextBox);
            this.Controls.Add(this.nameUserTextBox);
            this.Controls.Add(this.passwordUserLabel);
            this.Controls.Add(this.nameUserLabel);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookSignInForm";
            this.Text = "Inicio Sesion";
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.verificationErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmationButton;
        private System.Windows.Forms.Label nameUserLabel;
        private System.Windows.Forms.Label passwordUserLabel;
        private System.Windows.Forms.TextBox nameUserTextBox;
        private System.Windows.Forms.TextBox passwordUserTextBox;
        private System.Windows.Forms.ErrorProvider verificationErrorProvider;
        private System.Windows.Forms.Label errorLabel;
    }
}