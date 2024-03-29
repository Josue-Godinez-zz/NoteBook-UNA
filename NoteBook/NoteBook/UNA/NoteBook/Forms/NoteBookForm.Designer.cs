﻿namespace NoteBook
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
            this.VistaSuperiorPanel = new System.Windows.Forms.Panel();
            this.BuscarNotasButton = new System.Windows.Forms.Button();
            this.BuscarNotasLabel = new System.Windows.Forms.Label();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.SearchBookButton = new System.Windows.Forms.Button();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserSingInLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.BuscarNotaButton = new System.Windows.Forms.Button();
            this.VistaLateralPanel = new System.Windows.Forms.Panel();
            this.SignOutLabel = new System.Windows.Forms.Label();
            this.RegisterLabel = new System.Windows.Forms.Label();
            this.BookOrderLabel = new System.Windows.Forms.Label();
            this.NewBookLabel = new System.Windows.Forms.Label();
            this.SignOutButton = new System.Windows.Forms.Button();
            this.LogActivitiesButton = new System.Windows.Forms.Button();
            this.OrderBookButton = new System.Windows.Forms.Button();
            this.CreateBookButton = new System.Windows.Forms.Button();
            this.LibraryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InformationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TimeTimer = new System.Windows.Forms.Timer(this.components);
            this.VistaSuperiorPanel.SuspendLayout();
            this.VistaLateralPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // VistaSuperiorPanel
            // 
            this.VistaSuperiorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.VistaSuperiorPanel.Controls.Add(this.BuscarNotasButton);
            this.VistaSuperiorPanel.Controls.Add(this.BuscarNotasLabel);
            this.VistaSuperiorPanel.Controls.Add(this.SearchLabel);
            this.VistaSuperiorPanel.Controls.Add(this.SearchBookButton);
            this.VistaSuperiorPanel.Controls.Add(this.UserLabel);
            this.VistaSuperiorPanel.Controls.Add(this.UserSingInLabel);
            this.VistaSuperiorPanel.Controls.Add(this.TimeLabel);
            this.VistaSuperiorPanel.Controls.Add(this.LogInButton);
            this.VistaSuperiorPanel.Location = new System.Drawing.Point(0, 1);
            this.VistaSuperiorPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VistaSuperiorPanel.Name = "VistaSuperiorPanel";
            this.VistaSuperiorPanel.Size = new System.Drawing.Size(828, 110);
            this.VistaSuperiorPanel.TabIndex = 0;
            // 
            // BuscarNotasButton
            // 
            this.BuscarNotasButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarNotasButton.BackgroundImage")));
            this.BuscarNotasButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BuscarNotasButton.Location = new System.Drawing.Point(588, 20);
            this.BuscarNotasButton.Name = "BuscarNotasButton";
            this.BuscarNotasButton.Size = new System.Drawing.Size(50, 50);
            this.BuscarNotasButton.TabIndex = 7;
            this.BuscarNotasButton.UseVisualStyleBackColor = true;
            this.BuscarNotasButton.Click += new System.EventHandler(this.BuscarNotasButton_Click);
            // 
            // BuscarNotasLabel
            // 
            this.BuscarNotasLabel.AutoSize = true;
            this.BuscarNotasLabel.Location = new System.Drawing.Point(579, 74);
            this.BuscarNotasLabel.Name = "BuscarNotasLabel";
            this.BuscarNotasLabel.Size = new System.Drawing.Size(71, 13);
            this.BuscarNotasLabel.TabIndex = 6;
            this.BuscarNotasLabel.Text = "Buscar Notas";
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(421, 74);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(98, 13);
            this.SearchLabel.TabIndex = 3;
            this.SearchLabel.Text = "Busqueda De Libro";
            // 
            // SearchBookButton
            // 
            this.SearchBookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBookButton.BackgroundImage")));
            this.SearchBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchBookButton.Location = new System.Drawing.Point(441, 21);
            this.SearchBookButton.Name = "SearchBookButton";
            this.SearchBookButton.Size = new System.Drawing.Size(50, 50);
            this.SearchBookButton.TabIndex = 3;
            this.SearchBookButton.UseVisualStyleBackColor = true;
            this.SearchBookButton.Click += new System.EventHandler(this.SearchBookButton_Click);
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(285, 74);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(43, 13);
            this.UserLabel.TabIndex = 5;
            this.UserLabel.Text = "Usuario";
            // 
            // UserSingInLabel
            // 
            this.UserSingInLabel.AutoSize = true;
            this.UserSingInLabel.Location = new System.Drawing.Point(13, 21);
            this.UserSingInLabel.Name = "UserSingInLabel";
            this.UserSingInLabel.Size = new System.Drawing.Size(98, 13);
            this.UserSingInLabel.TabIndex = 3;
            this.UserSingInLabel.Text = "<No Autentificado>";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(13, 4);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 13);
            this.TimeLabel.TabIndex = 2;
            // 
            // LogInButton
            // 
            this.LogInButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogInButton.BackgroundImage")));
            this.LogInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogInButton.Location = new System.Drawing.Point(282, 20);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(50, 50);
            this.LogInButton.TabIndex = 1;
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // BuscarNotaButton
            // 
            this.BuscarNotaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarNotaButton.BackgroundImage")));
            this.BuscarNotaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BuscarNotaButton.Location = new System.Drawing.Point(588, 21);
            this.BuscarNotaButton.Name = "BuscarNotaButton";
            this.BuscarNotaButton.Size = new System.Drawing.Size(50, 50);
            this.BuscarNotaButton.TabIndex = 0;
            this.BuscarNotaButton.UseVisualStyleBackColor = true;
            this.BuscarNotaButton.Click += new System.EventHandler(this.BuscarNotaButton_Click);
            // 
            // VistaLateralPanel
            // 
            this.VistaLateralPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VistaLateralPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.VistaLateralPanel.Controls.Add(this.BuscarNotaButton);
            this.VistaLateralPanel.Controls.Add(this.SignOutLabel);
            this.VistaLateralPanel.Controls.Add(this.RegisterLabel);
            this.VistaLateralPanel.Controls.Add(this.BookOrderLabel);
            this.VistaLateralPanel.Controls.Add(this.NewBookLabel);
            this.VistaLateralPanel.Controls.Add(this.SignOutButton);
            this.VistaLateralPanel.Controls.Add(this.LogActivitiesButton);
            this.VistaLateralPanel.Controls.Add(this.OrderBookButton);
            this.VistaLateralPanel.Controls.Add(this.CreateBookButton);
            this.VistaLateralPanel.Location = new System.Drawing.Point(0, 110);
            this.VistaLateralPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VistaLateralPanel.Name = "VistaLateralPanel";
            this.VistaLateralPanel.Size = new System.Drawing.Size(179, 405);
            this.VistaLateralPanel.TabIndex = 1;
            // 
            // SignOutLabel
            // 
            this.SignOutLabel.AutoSize = true;
            this.SignOutLabel.Location = new System.Drawing.Point(72, 344);
            this.SignOutLabel.Name = "SignOutLabel";
            this.SignOutLabel.Size = new System.Drawing.Size(70, 13);
            this.SignOutLabel.TabIndex = 7;
            this.SignOutLabel.Text = "Cerrar Sesión";
            // 
            // RegisterLabel
            // 
            this.RegisterLabel.AutoSize = true;
            this.RegisterLabel.Location = new System.Drawing.Point(72, 245);
            this.RegisterLabel.Name = "RegisterLabel";
            this.RegisterLabel.Size = new System.Drawing.Size(104, 13);
            this.RegisterLabel.TabIndex = 6;
            this.RegisterLabel.Text = "Registro Actividades";
            // 
            // BookOrderLabel
            // 
            this.BookOrderLabel.AutoSize = true;
            this.BookOrderLabel.Location = new System.Drawing.Point(72, 145);
            this.BookOrderLabel.Name = "BookOrderLabel";
            this.BookOrderLabel.Size = new System.Drawing.Size(76, 13);
            this.BookOrderLabel.TabIndex = 5;
            this.BookOrderLabel.Text = "Ordenar Libros";
            // 
            // NewBookLabel
            // 
            this.NewBookLabel.AutoSize = true;
            this.NewBookLabel.ForeColor = System.Drawing.Color.Black;
            this.NewBookLabel.Location = new System.Drawing.Point(72, 50);
            this.NewBookLabel.Name = "NewBookLabel";
            this.NewBookLabel.Size = new System.Drawing.Size(65, 13);
            this.NewBookLabel.TabIndex = 4;
            this.NewBookLabel.Text = "Nuevo Libro";
            // 
            // SignOutButton
            // 
            this.SignOutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignOutButton.BackgroundImage")));
            this.SignOutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignOutButton.Enabled = false;
            this.SignOutButton.Location = new System.Drawing.Point(16, 325);
            this.SignOutButton.Name = "SignOutButton";
            this.SignOutButton.Size = new System.Drawing.Size(50, 50);
            this.SignOutButton.TabIndex = 3;
            this.SignOutButton.UseVisualStyleBackColor = true;
            this.SignOutButton.Click += new System.EventHandler(this.SignOutButton_Click);
            // 
            // LogActivitiesButton
            // 
            this.LogActivitiesButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogActivitiesButton.BackgroundImage")));
            this.LogActivitiesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogActivitiesButton.Location = new System.Drawing.Point(16, 226);
            this.LogActivitiesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogActivitiesButton.Name = "LogActivitiesButton";
            this.LogActivitiesButton.Size = new System.Drawing.Size(50, 50);
            this.LogActivitiesButton.TabIndex = 2;
            this.LogActivitiesButton.UseVisualStyleBackColor = true;
            this.LogActivitiesButton.Click += new System.EventHandler(this.LogActivitiesButton_Click);
            // 
            // OrderBookButton
            // 
            this.OrderBookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OrderBookButton.BackgroundImage")));
            this.OrderBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OrderBookButton.Location = new System.Drawing.Point(16, 127);
            this.OrderBookButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OrderBookButton.Name = "OrderBookButton";
            this.OrderBookButton.Size = new System.Drawing.Size(50, 50);
            this.OrderBookButton.TabIndex = 1;
            this.OrderBookButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.OrderBookButton.UseVisualStyleBackColor = true;
            this.OrderBookButton.Click += new System.EventHandler(this.OrderBookButton_Click);
            // 
            // CreateBookButton
            // 
            this.CreateBookButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CreateBookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateBookButton.BackgroundImage")));
            this.CreateBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CreateBookButton.ForeColor = System.Drawing.Color.Red;
            this.CreateBookButton.Location = new System.Drawing.Point(16, 31);
            this.CreateBookButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreateBookButton.Name = "CreateBookButton";
            this.CreateBookButton.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.CreateBookButton.Size = new System.Drawing.Size(50, 50);
            this.CreateBookButton.TabIndex = 0;
            this.CreateBookButton.Text = "HOLA";
            this.CreateBookButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateBookButton.UseVisualStyleBackColor = true;
            this.CreateBookButton.Click += new System.EventHandler(this.CreateBookButton_Click);
            // 
            // LibraryTableLayoutPanel
            // 
            this.LibraryTableLayoutPanel.AutoScroll = true;
            this.LibraryTableLayoutPanel.BackColor = System.Drawing.Color.DarkGray;
            this.LibraryTableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LibraryTableLayoutPanel.CausesValidation = false;
            this.LibraryTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.LibraryTableLayoutPanel.ColumnCount = 5;
            this.LibraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.LibraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.LibraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.LibraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.LibraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.LibraryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.LibraryTableLayoutPanel.Location = new System.Drawing.Point(195, 119);
            this.LibraryTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LibraryTableLayoutPanel.Name = "LibraryTableLayoutPanel";
            this.LibraryTableLayoutPanel.RowCount = 3;
            this.LibraryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.LibraryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.LibraryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.LibraryTableLayoutPanel.Size = new System.Drawing.Size(620, 383);
            this.LibraryTableLayoutPanel.TabIndex = 2;
            // 
            // InformationToolTip
            // 
            this.InformationToolTip.IsBalloon = true;
            this.InformationToolTip.OwnerDraw = true;
            this.InformationToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // TimeTimer
            // 
            this.TimeTimer.Enabled = true;
            this.TimeTimer.Tick += new System.EventHandler(this.TimeTimer_Tick);
            // 
            // NoteBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(827, 515);
            this.Controls.Add(this.LibraryTableLayoutPanel);
            this.Controls.Add(this.VistaLateralPanel);
            this.Controls.Add(this.VistaSuperiorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookForm";
            this.Text = "NoteBook";
            this.Load += new System.EventHandler(this.NoteBookForm_Load);
            this.VistaSuperiorPanel.ResumeLayout(false);
            this.VistaSuperiorPanel.PerformLayout();
            this.VistaLateralPanel.ResumeLayout(false);
            this.VistaLateralPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VistaSuperiorPanel;
        private System.Windows.Forms.Panel VistaLateralPanel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button LogActivitiesButton;
        private System.Windows.Forms.Button OrderBookButton;
        private System.Windows.Forms.Button CreateBookButton;
        private System.Windows.Forms.TableLayoutPanel LibraryTableLayoutPanel;
        private System.Windows.Forms.Button SignOutButton;
        private System.Windows.Forms.ToolTip InformationToolTip;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer TimeTimer;
        private System.Windows.Forms.Label UserSingInLabel;
        private System.Windows.Forms.Label NewBookLabel;
        private System.Windows.Forms.Label BookOrderLabel;
        private System.Windows.Forms.Label RegisterLabel;
        private System.Windows.Forms.Label SignOutLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button SearchBookButton;
        private System.Windows.Forms.Button BuscarNotaButton;

        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label BuscarNotasLabel;
        private System.Windows.Forms.Button BuscarNotasButton;
    }
}
