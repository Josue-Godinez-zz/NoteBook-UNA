namespace NoteBook
{
    partial class NotebookProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotebookProfileForm));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.helpDeleteToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.helpEditToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.nameUserLabel = new System.Windows.Forms.Label();
            this.passwordUserLabel = new System.Windows.Forms.Label();
            this.nameUserTextBox = new System.Windows.Forms.TextBox();
            this.passwordUserTextBox = new System.Windows.Forms.TextBox();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(294, 90);
            this.panelSuperior.TabIndex = 3;
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
            this.panelInferior.Controls.Add(this.deleteButton);
            this.panelInferior.Controls.Add(this.cancelButton);
            this.panelInferior.Controls.Add(this.editButton);
            this.panelInferior.Location = new System.Drawing.Point(0, 334);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(294, 77);
            this.panelInferior.TabIndex = 4;
            // 
            // deleteButton
            // 
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Location = new System.Drawing.Point(123, 15);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(50, 50);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelButton.BackgroundImage")));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.Location = new System.Drawing.Point(219, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(50, 50);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editButton.BackgroundImage")));
            this.editButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editButton.Location = new System.Drawing.Point(28, 14);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(50, 50);
            this.editButton.TabIndex = 5;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
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
            // nameUserLabel
            // 
            this.nameUserLabel.AutoSize = true;
            this.nameUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nameUserLabel.Location = new System.Drawing.Point(12, 142);
            this.nameUserLabel.Name = "nameUserLabel";
            this.nameUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameUserLabel.Size = new System.Drawing.Size(43, 13);
            this.nameUserLabel.TabIndex = 5;
            this.nameUserLabel.Text = "Usuario";
            // 
            // passwordUserLabel
            // 
            this.passwordUserLabel.AutoSize = true;
            this.passwordUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.passwordUserLabel.Location = new System.Drawing.Point(12, 213);
            this.passwordUserLabel.Name = "passwordUserLabel";
            this.passwordUserLabel.Size = new System.Drawing.Size(61, 13);
            this.passwordUserLabel.TabIndex = 6;
            this.passwordUserLabel.Text = "Contraseña";
            // 
            // nameUserTextBox
            // 
            this.nameUserTextBox.Enabled = false;
            this.nameUserTextBox.Location = new System.Drawing.Point(99, 139);
            this.nameUserTextBox.Name = "nameUserTextBox";
            this.nameUserTextBox.Size = new System.Drawing.Size(115, 20);
            this.nameUserTextBox.TabIndex = 7;
            // 
            // passwordUserTextBox
            // 
            this.passwordUserTextBox.Enabled = false;
            this.passwordUserTextBox.Location = new System.Drawing.Point(99, 206);
            this.passwordUserTextBox.Name = "passwordUserTextBox";
            this.passwordUserTextBox.PasswordChar = '*';
            this.passwordUserTextBox.Size = new System.Drawing.Size(115, 20);
            this.passwordUserTextBox.TabIndex = 8;
            this.passwordUserTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.passwordUserTextBox_MouseDoubleClick);
            // 
            // NotebookProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(294, 411);
            this.ControlBox = false;
            this.Controls.Add(this.passwordUserTextBox);
            this.Controls.Add(this.nameUserTextBox);
            this.Controls.Add(this.passwordUserLabel);
            this.Controls.Add(this.nameUserLabel);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelSuperior);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NotebookProfileForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Notebook - Profile";
            this.panelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelInferior.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ToolTip helpDeleteToolTip;
        private System.Windows.Forms.ToolTip helpEditToolTip;
        private System.Windows.Forms.Label nameUserLabel;
        private System.Windows.Forms.Label passwordUserLabel;
        private System.Windows.Forms.TextBox nameUserTextBox;
        private System.Windows.Forms.TextBox passwordUserTextBox;
    }
}