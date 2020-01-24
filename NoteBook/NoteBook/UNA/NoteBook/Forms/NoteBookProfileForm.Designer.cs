namespace NoteBook
{
    partial class NoteBookProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookProfileForm));
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.NullButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.helpDeleteToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpEditToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.NameUserLabel = new System.Windows.Forms.Label();
            this.PasswordUserLabel = new System.Windows.Forms.Label();
            this.NameUserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordUserTextBox = new System.Windows.Forms.TextBox();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.PanelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelSuperior.Controls.Add(this.AvatarPictureBox);
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(294, 90);
            this.PanelSuperior.TabIndex = 3;
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
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelInferior.Controls.Add(this.DeleteButton);
            this.PanelInferior.Controls.Add(this.NullButton);
            this.PanelInferior.Controls.Add(this.EditButton);
            this.PanelInferior.Location = new System.Drawing.Point(0, 334);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(294, 77);
            this.PanelInferior.TabIndex = 4;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteButton.BackgroundImage")));
            this.DeleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DeleteButton.Location = new System.Drawing.Point(123, 15);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 50);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NullButton
            // 
            this.NullButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NullButton.BackgroundImage")));
            this.NullButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NullButton.Location = new System.Drawing.Point(219, 15);
            this.NullButton.Name = "NullButton";
            this.NullButton.Size = new System.Drawing.Size(50, 50);
            this.NullButton.TabIndex = 2;
            this.NullButton.UseVisualStyleBackColor = true;
            this.NullButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditButton.BackgroundImage")));
            this.EditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditButton.Location = new System.Drawing.Point(28, 14);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(50, 50);
            this.EditButton.TabIndex = 0;
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // helpDeleteToolTip
            // 
            this.helpDeleteToolTip.AutoPopDelay = 5000;
            this.helpDeleteToolTip.InitialDelay = 500;
            this.helpDeleteToolTip.IsBalloon = true;
            this.helpDeleteToolTip.ReshowDelay = 100;
            this.helpDeleteToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // helpEditToolTip
            // 
            this.helpEditToolTip.IsBalloon = true;
            this.helpEditToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // NameUserLabel
            // 
            this.NameUserLabel.AutoSize = true;
            this.NameUserLabel.ForeColor = System.Drawing.Color.Black;
            this.NameUserLabel.Location = new System.Drawing.Point(12, 142);
            this.NameUserLabel.Name = "NameUserLabel";
            this.NameUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameUserLabel.Size = new System.Drawing.Size(43, 13);
            this.NameUserLabel.TabIndex = 5;
            this.NameUserLabel.Text = "Usuario";
            // 
            // PasswordUserLabel
            // 
            this.PasswordUserLabel.AutoSize = true;
            this.PasswordUserLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordUserLabel.Location = new System.Drawing.Point(12, 213);
            this.PasswordUserLabel.Name = "PasswordUserLabel";
            this.PasswordUserLabel.Size = new System.Drawing.Size(61, 13);
            this.PasswordUserLabel.TabIndex = 6;
            this.PasswordUserLabel.Text = "Contraseña";
            // 
            // NameUserTextBox
            // 
            this.NameUserTextBox.Enabled = false;
            this.NameUserTextBox.Location = new System.Drawing.Point(99, 139);
            this.NameUserTextBox.Name = "NameUserTextBox";
            this.NameUserTextBox.Size = new System.Drawing.Size(115, 20);
            this.NameUserTextBox.TabIndex = 0;
            // 
            // PasswordUserTextBox
            // 
            this.PasswordUserTextBox.Enabled = false;
            this.PasswordUserTextBox.Location = new System.Drawing.Point(99, 206);
            this.PasswordUserTextBox.Name = "PasswordUserTextBox";
            this.PasswordUserTextBox.PasswordChar = '*';
            this.PasswordUserTextBox.Size = new System.Drawing.Size(115, 20);
            this.PasswordUserTextBox.TabIndex = 1;
            this.PasswordUserTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PasswordUserTextBox_MouseDoubleClick);
            // 
            // NoteBookProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.ControlBox = false;
            this.Controls.Add(this.PasswordUserTextBox);
            this.Controls.Add(this.NameUserTextBox);
            this.Controls.Add(this.PasswordUserLabel);
            this.Controls.Add(this.NameUserLabel);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookProfileForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Notebook - Profile";
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.PanelInferior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Button NullButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ToolTip helpDeleteToolTip;
        private System.Windows.Forms.ToolTip helpEditToolTip;
        private System.Windows.Forms.Label NameUserLabel;
        private System.Windows.Forms.Label PasswordUserLabel;
        private System.Windows.Forms.TextBox NameUserTextBox;
        private System.Windows.Forms.TextBox PasswordUserTextBox;
    }
}