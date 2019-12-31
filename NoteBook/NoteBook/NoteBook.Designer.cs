namespace NoteBook
{
    partial class NoteBookForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookForm));
            this.vistaSuperiorPanel = new System.Windows.Forms.Panel();
            this.userSingInLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.vistaLateralPanel = new System.Windows.Forms.Panel();
            this.signOutButton = new System.Windows.Forms.Button();
            this.logActivitiesButton = new System.Windows.Forms.Button();
            this.sortCategoriesButton = new System.Windows.Forms.Button();
            this.createBookButton = new System.Windows.Forms.Button();
            this.libraryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.informationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vistaSuperiorPanel.SuspendLayout();
            this.vistaLateralPanel.SuspendLayout();
            this.libraryTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vistaSuperiorPanel
            // 
            this.vistaSuperiorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.vistaSuperiorPanel.Controls.Add(this.userSingInLabel);
            this.vistaSuperiorPanel.Controls.Add(this.timeLabel);
            this.vistaSuperiorPanel.Controls.Add(this.logInButton);
            this.vistaSuperiorPanel.Controls.Add(this.signUpButton);
            this.vistaSuperiorPanel.Location = new System.Drawing.Point(0, 1);
            this.vistaSuperiorPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vistaSuperiorPanel.Name = "vistaSuperiorPanel";
            this.vistaSuperiorPanel.Size = new System.Drawing.Size(816, 110);
            this.vistaSuperiorPanel.TabIndex = 0;
            // 
            // userSingInLabel
            // 
            this.userSingInLabel.AutoSize = true;
            this.userSingInLabel.Location = new System.Drawing.Point(13, 21);
            this.userSingInLabel.Name = "userSingInLabel";
            this.userSingInLabel.Size = new System.Drawing.Size(98, 13);
            this.userSingInLabel.TabIndex = 3;
            this.userSingInLabel.Text = "<No Autentificado>";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(13, 4);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 2;
            // 
            // logInButton
            // 
            this.logInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logInButton.BackgroundImage")));
            this.logInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logInButton.Location = new System.Drawing.Point(484, 20);
            this.logInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(50, 50);
            this.logInButton.TabIndex = 1;
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signUpButton.BackgroundImage")));
            this.signUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpButton.Location = new System.Drawing.Point(275, 20);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(50, 50);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // vistaLateralPanel
            // 
            this.vistaLateralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.vistaLateralPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.vistaLateralPanel.Controls.Add(this.signOutButton);
            this.vistaLateralPanel.Controls.Add(this.logActivitiesButton);
            this.vistaLateralPanel.Controls.Add(this.sortCategoriesButton);
            this.vistaLateralPanel.Controls.Add(this.createBookButton);
            this.vistaLateralPanel.Location = new System.Drawing.Point(0, 110);
            this.vistaLateralPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.vistaLateralPanel.Name = "vistaLateralPanel";
            this.vistaLateralPanel.Size = new System.Drawing.Size(169, 395);
            this.vistaLateralPanel.TabIndex = 1;
            // 
            // signOutButton
            // 
            this.signOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signOutButton.BackgroundImage")));
            this.signOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.signOutButton.Enabled = false;
            this.signOutButton.Location = new System.Drawing.Point(58, 305);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(50, 50);
            this.signOutButton.TabIndex = 3;
            this.signOutButton.UseVisualStyleBackColor = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
            // 
            // logActivitiesButton
            // 
            this.logActivitiesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logActivitiesButton.BackgroundImage")));
            this.logActivitiesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logActivitiesButton.Location = new System.Drawing.Point(58, 210);
            this.logActivitiesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logActivitiesButton.Name = "logActivitiesButton";
            this.logActivitiesButton.Size = new System.Drawing.Size(50, 50);
            this.logActivitiesButton.TabIndex = 2;
            this.logActivitiesButton.UseVisualStyleBackColor = true;
            // 
            // sortCategoriesButton
            // 
            this.sortCategoriesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sortCategoriesButton.BackgroundImage")));
            this.sortCategoriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sortCategoriesButton.Location = new System.Drawing.Point(58, 117);
            this.sortCategoriesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sortCategoriesButton.Name = "sortCategoriesButton";
            this.sortCategoriesButton.Size = new System.Drawing.Size(50, 50);
            this.sortCategoriesButton.TabIndex = 1;
            this.sortCategoriesButton.UseVisualStyleBackColor = true;
            // 
            // createBookButton
            // 
            this.createBookButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createBookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createBookButton.BackgroundImage")));
            this.createBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.createBookButton.Location = new System.Drawing.Point(58, 26);
            this.createBookButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createBookButton.Name = "createBookButton";
            this.createBookButton.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.createBookButton.Size = new System.Drawing.Size(50, 50);
            this.createBookButton.TabIndex = 0;
            this.createBookButton.UseVisualStyleBackColor = true;
            this.createBookButton.Click += new System.EventHandler(this.createBookButton_Click);
            // 
            // libraryTableLayoutPanel
            // 
            this.libraryTableLayoutPanel.BackColor = System.Drawing.Color.DarkGray;
            this.libraryTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.libraryTableLayoutPanel.CausesValidation = false;
            this.libraryTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;

            this.libraryTableLayoutPanel.ColumnCount = 2;
            this.libraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.libraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.libraryTableLayoutPanel.Controls.Add(this.pictureBox1, 0, 0);

            this.libraryTableLayoutPanel.ColumnCount = 5;
            this.libraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.libraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.libraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.libraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.libraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));

            this.libraryTableLayoutPanel.Location = new System.Drawing.Point(186, 125);
            this.libraryTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.libraryTableLayoutPanel.Name = "libraryTableLayoutPanel";
            this.libraryTableLayoutPanel.RowCount = 2;
            this.libraryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.libraryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.libraryTableLayoutPanel.Size = new System.Drawing.Size(619, 367);
            this.libraryTableLayoutPanel.TabIndex = 2;
            // 
            // informationToolTip
            // 
            this.informationToolTip.IsBalloon = true;
            this.informationToolTip.OwnerDraw = true;
            this.informationToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // timeTimer
            // 
            this.timeTimer.Enabled = true;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(132, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NoteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(817, 505);
            this.Controls.Add(this.libraryTableLayoutPanel);
            this.Controls.Add(this.vistaLateralPanel);
            this.Controls.Add(this.vistaSuperiorPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookForm";
            this.Text = "NoteBook";
            this.vistaSuperiorPanel.ResumeLayout(false);
            this.vistaSuperiorPanel.PerformLayout();
            this.vistaLateralPanel.ResumeLayout(false);
            this.libraryTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel vistaSuperiorPanel;
        private System.Windows.Forms.Panel vistaLateralPanel;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button logActivitiesButton;
        private System.Windows.Forms.Button sortCategoriesButton;
        private System.Windows.Forms.Button createBookButton;
        private System.Windows.Forms.TableLayoutPanel libraryTableLayoutPanel;
        private System.Windows.Forms.Button signOutButton;
        private System.Windows.Forms.ToolTip informationToolTip;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Label userSingInLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

