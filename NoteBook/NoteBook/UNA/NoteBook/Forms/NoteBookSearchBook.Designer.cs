namespace NoteBook.UNA.NoteBook.Forms
{
    partial class NoteBookSearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBookSearchBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.OpenBookButton = new System.Windows.Forms.Button();
            this.BooksResultDataGridView = new System.Windows.Forms.DataGridView();
            this.NameBookTextBox = new System.Windows.Forms.TextBox();
            this.Categorie2ComboBox = new System.Windows.Forms.ComboBox();
            this.Categorie1ComboBox = new System.Windows.Forms.ComboBox();
            this.Categorie3ComboBox = new System.Windows.Forms.ComboBox();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.PanelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelSuperior.Controls.Add(this.AvatarPictureBox);
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(644, 83);
            this.PanelSuperior.TabIndex = 0;
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AvatarPictureBox.Image")));
            this.AvatarPictureBox.Location = new System.Drawing.Point(290, 9);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(65, 65);
            this.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarPictureBox.TabIndex = 1;
            this.AvatarPictureBox.TabStop = false;
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelInferior.Controls.Add(this.ExitButton);
            this.PanelInferior.Controls.Add(this.OpenBookButton);
            this.PanelInferior.Location = new System.Drawing.Point(0, 385);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(644, 79);
            this.PanelInferior.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitButton.Location = new System.Drawing.Point(438, 14);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(50, 50);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // OpenBookButton
            // 
            this.OpenBookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OpenBookButton.BackgroundImage")));
            this.OpenBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenBookButton.Location = new System.Drawing.Point(143, 14);
            this.OpenBookButton.Name = "OpenBookButton";
            this.OpenBookButton.Size = new System.Drawing.Size(50, 50);
            this.OpenBookButton.TabIndex = 0;
            this.OpenBookButton.UseVisualStyleBackColor = true;
            this.OpenBookButton.Click += new System.EventHandler(this.OpenBookButton_Click);
            // 
            // BooksResultDataGridView
            // 
            this.BooksResultDataGridView.AllowUserToAddRows = false;
            this.BooksResultDataGridView.AllowUserToDeleteRows = false;
            this.BooksResultDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BooksResultDataGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            this.BooksResultDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksResultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BooksResultDataGridView.ColumnHeadersHeight = 30;
            this.BooksResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BooksResultDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.BooksResultDataGridView.EnableHeadersVisualStyles = false;
            this.BooksResultDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BooksResultDataGridView.Location = new System.Drawing.Point(12, 143);
            this.BooksResultDataGridView.MultiSelect = false;
            this.BooksResultDataGridView.Name = "BooksResultDataGridView";
            this.BooksResultDataGridView.RowHeadersVisible = false;
            this.BooksResultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BooksResultDataGridView.Size = new System.Drawing.Size(620, 236);
            this.BooksResultDataGridView.TabIndex = 2;
            // 
            // NameBookTextBox
            // 
            this.NameBookTextBox.Location = new System.Drawing.Point(22, 104);
            this.NameBookTextBox.Name = "NameBookTextBox";
            this.NameBookTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameBookTextBox.TabIndex = 3;
            this.NameBookTextBox.TextChanged += new System.EventHandler(this.NameBookTextBox_TextChanged);
            // 
            // Categorie2ComboBox
            // 
            this.Categorie2ComboBox.FormattingEnabled = true;
            this.Categorie2ComboBox.Location = new System.Drawing.Point(324, 103);
            this.Categorie2ComboBox.Name = "Categorie2ComboBox";
            this.Categorie2ComboBox.Size = new System.Drawing.Size(100, 21);
            this.Categorie2ComboBox.TabIndex = 4;
            this.Categorie2ComboBox.SelectedIndexChanged += new System.EventHandler(this.Categorie2ComboBox_SelectedIndexChanged);
            // 
            // Categorie1ComboBox
            // 
            this.Categorie1ComboBox.FormattingEnabled = true;
            this.Categorie1ComboBox.Location = new System.Drawing.Point(174, 104);
            this.Categorie1ComboBox.Name = "Categorie1ComboBox";
            this.Categorie1ComboBox.Size = new System.Drawing.Size(100, 21);
            this.Categorie1ComboBox.TabIndex = 5;
            this.Categorie1ComboBox.SelectedIndexChanged += new System.EventHandler(this.Categorie1ComboBox_SelectedIndexChanged);
            // 
            // Categorie3ComboBox
            // 
            this.Categorie3ComboBox.FormattingEnabled = true;
            this.Categorie3ComboBox.Location = new System.Drawing.Point(476, 104);
            this.Categorie3ComboBox.Name = "Categorie3ComboBox";
            this.Categorie3ComboBox.Size = new System.Drawing.Size(100, 21);
            this.Categorie3ComboBox.TabIndex = 6;
            this.Categorie3ComboBox.SelectedIndexChanged += new System.EventHandler(this.Categorie3ComboBox_SelectedIndexChanged);
            // 
            // NoteBookSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(644, 463);
            this.Controls.Add(this.Categorie3ComboBox);
            this.Controls.Add(this.Categorie1ComboBox);
            this.Controls.Add(this.Categorie2ComboBox);
            this.Controls.Add(this.NameBookTextBox);
            this.Controls.Add(this.BooksResultDataGridView);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.PanelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBookSearchBook";
            this.Text = "Buscar Libro";
            this.Load += new System.EventHandler(this.NoteBookSearchBook_Load);
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.PanelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BooksResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button OpenBookButton;
        private System.Windows.Forms.DataGridView BooksResultDataGridView;
        private System.Windows.Forms.TextBox NameBookTextBox;
        private System.Windows.Forms.ComboBox Categorie2ComboBox;
        private System.Windows.Forms.ComboBox Categorie1ComboBox;
        private System.Windows.Forms.ComboBox Categorie3ComboBox;
    }
}