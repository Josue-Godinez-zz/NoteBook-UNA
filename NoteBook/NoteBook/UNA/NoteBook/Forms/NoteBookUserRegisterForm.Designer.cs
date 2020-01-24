namespace NoteBook
{
    partial class NoteBookUserRegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookUserRegisterForm));
            this.IconRegisterPictureBox = new System.Windows.Forms.PictureBox();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.NameUserLabel = new System.Windows.Forms.Label();
            this.NameUserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordUserLabel = new System.Windows.Forms.Label();
            this.PasswordUserTextBox = new System.Windows.Forms.TextBox();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.NullButton = new System.Windows.Forms.Button();
            this.ConfirmationButton = new System.Windows.Forms.Button();
            this.ConfirmationPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmationPasswordTextBox = new System.Windows.Forms.TextBox();
            this.VerificationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconRegisterPictureBox)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            this.PanelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VerificationErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IconRegisterPictureBox
            // 
            this.IconRegisterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IconRegisterPictureBox.Image")));
            this.IconRegisterPictureBox.Location = new System.Drawing.Point(113, 12);
            this.IconRegisterPictureBox.Name = "IconRegisterPictureBox";
            this.IconRegisterPictureBox.Size = new System.Drawing.Size(65, 65);
            this.IconRegisterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconRegisterPictureBox.TabIndex = 0;
            this.IconRegisterPictureBox.TabStop = false;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelSuperior.Controls.Add(this.IconRegisterPictureBox);
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(295, 90);
            this.PanelSuperior.TabIndex = 1;
            // 
            // NameUserLabel
            // 
            this.NameUserLabel.AutoSize = true;
            this.NameUserLabel.Location = new System.Drawing.Point(94, 152);
            this.NameUserLabel.Name = "NameUserLabel";
            this.NameUserLabel.Size = new System.Drawing.Size(106, 13);
            this.NameUserLabel.TabIndex = 2;
            this.NameUserLabel.Text = "Nombre De Usuaraio";
            this.NameUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameUserTextBox
            // 
            this.NameUserTextBox.Location = new System.Drawing.Point(81, 168);
            this.NameUserTextBox.MaxLength = 15;
            this.NameUserTextBox.Name = "NameUserTextBox";
            this.NameUserTextBox.Size = new System.Drawing.Size(138, 20);
            this.NameUserTextBox.TabIndex = 2;
            this.NameUserTextBox.Leave += new System.EventHandler(this.NameUserTextBox_Leave);
            // 
            // PasswordUserLabel
            // 
            this.PasswordUserLabel.AutoSize = true;
            this.PasswordUserLabel.Location = new System.Drawing.Point(92, 203);
            this.PasswordUserLabel.Name = "PasswordUserLabel";
            this.PasswordUserLabel.Size = new System.Drawing.Size(117, 13);
            this.PasswordUserLabel.TabIndex = 4;
            this.PasswordUserLabel.Text = "Contraseña De Usuario";
            // 
            // PasswordUserTextBox
            // 
            this.PasswordUserTextBox.Location = new System.Drawing.Point(81, 219);
            this.PasswordUserTextBox.MaxLength = 10;
            this.PasswordUserTextBox.Name = "PasswordUserTextBox";
            this.PasswordUserTextBox.PasswordChar = '*';
            this.PasswordUserTextBox.Size = new System.Drawing.Size(138, 20);
            this.PasswordUserTextBox.TabIndex = 3;
            this.PasswordUserTextBox.Leave += new System.EventHandler(this.PasswordUserTextBox_Leave);
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelInferior.Controls.Add(this.NullButton);
            this.PanelInferior.Controls.Add(this.ConfirmationButton);
            this.PanelInferior.Location = new System.Drawing.Point(0, 335);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(295, 77);
            this.PanelInferior.TabIndex = 2;
            // 
            // NullButton
            // 
            this.NullButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NullButton.BackgroundImage")));
            this.NullButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NullButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NullButton.Location = new System.Drawing.Point(169, 14);
            this.NullButton.Name = "NullButton";
            this.NullButton.Size = new System.Drawing.Size(50, 50);
            this.NullButton.TabIndex = 1;
            this.NullButton.UseVisualStyleBackColor = true;
            this.NullButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            // ConfirmationPasswordLabel
            // 
            this.ConfirmationPasswordLabel.AutoSize = true;
            this.ConfirmationPasswordLabel.Location = new System.Drawing.Point(92, 252);
            this.ConfirmationPasswordLabel.Name = "ConfirmationPasswordLabel";
            this.ConfirmationPasswordLabel.Size = new System.Drawing.Size(108, 13);
            this.ConfirmationPasswordLabel.TabIndex = 6;
            this.ConfirmationPasswordLabel.Text = "Confirmar Contraseña";
            // 
            // ConfirmationPasswordTextBox
            // 
            this.ConfirmationPasswordTextBox.Location = new System.Drawing.Point(81, 268);
            this.ConfirmationPasswordTextBox.MaxLength = 10;
            this.ConfirmationPasswordTextBox.Name = "ConfirmationPasswordTextBox";
            this.ConfirmationPasswordTextBox.PasswordChar = '*';
            this.ConfirmationPasswordTextBox.Size = new System.Drawing.Size(138, 20);
            this.ConfirmationPasswordTextBox.TabIndex = 4;
            this.ConfirmationPasswordTextBox.Leave += new System.EventHandler(this.ConfirmationPasswordTextBox_Leave);
            // 
            // VerificationErrorProvider
            // 
            this.VerificationErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.VerificationErrorProvider.ContainerControl = this;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(110, 310);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ErrorLabel.TabIndex = 8;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(21, 109);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(105, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(48, 93);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 13);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Nombre";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(205, 93);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(44, 13);
            this.LastNameLabel.TabIndex = 11;
            this.LastNameLabel.Text = "Apellido";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(169, 109);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(105, 20);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // NoteBookUserRegisterForm
            // 
            this.AcceptButton = this.ConfirmationButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.CancelButton = this.NullButton;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.ControlBox = false;
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ConfirmationPasswordTextBox);
            this.Controls.Add(this.ConfirmationPasswordLabel);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.PasswordUserTextBox);
            this.Controls.Add(this.PasswordUserLabel);
            this.Controls.Add(this.NameUserTextBox);
            this.Controls.Add(this.NameUserLabel);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookUserRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.IconRegisterPictureBox)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            this.PanelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VerificationErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox IconRegisterPictureBox;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.Label NameUserLabel;
        private System.Windows.Forms.TextBox NameUserTextBox;
        private System.Windows.Forms.Label PasswordUserLabel;
        private System.Windows.Forms.TextBox PasswordUserTextBox;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Button NullButton;
        private System.Windows.Forms.Button ConfirmationButton;
        private System.Windows.Forms.Label ConfirmationPasswordLabel;
        private System.Windows.Forms.TextBox ConfirmationPasswordTextBox;
        private System.Windows.Forms.ErrorProvider VerificationErrorProvider;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}