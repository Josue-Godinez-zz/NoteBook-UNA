﻿namespace NoteBook
{
    partial class NoteBooksActivityRegisterForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteBooksActivityRegisterForm));
            this.ActivitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.TimeColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccionColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ObjectColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InformationColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelSuperior = new System.Windows.Forms.Panel();
            this.AvatarPictureBox = new System.Windows.Forms.PictureBox();
            this.PanelInferior = new System.Windows.Forms.Panel();
            this.PrinterButton = new System.Windows.Forms.Button();
            this.NullButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ActivitiesDataGridView)).BeginInit();
            this.PanelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).BeginInit();
            this.PanelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActivitiesDataGridView
            // 
            this.ActivitiesDataGridView.AllowUserToAddRows = false;
            this.ActivitiesDataGridView.AllowUserToDeleteRows = false;
            this.ActivitiesDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ActivitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ActivitiesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ActivitiesDataGridView.BackgroundColor = System.Drawing.Color.LightYellow;
            this.ActivitiesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.ActivitiesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivitiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ActivitiesDataGridView.ColumnHeadersHeight = 30;
            this.ActivitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ActivitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeColum,
            this.UserColum,
            this.AccionColum,
            this.ObjectColum,
            this.InformationColum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ActivitiesDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.ActivitiesDataGridView.EnableHeadersVisualStyles = false;
            this.ActivitiesDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ActivitiesDataGridView.Location = new System.Drawing.Point(12, 96);
            this.ActivitiesDataGridView.MultiSelect = false;
            this.ActivitiesDataGridView.Name = "ActivitiesDataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ActivitiesDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ActivitiesDataGridView.RowHeadersVisible = false;
            this.ActivitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ActivitiesDataGridView.Size = new System.Drawing.Size(764, 287);
            this.ActivitiesDataGridView.TabIndex = 0;
            // 
            // TimeColum
            // 
            this.TimeColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TimeColum.HeaderText = "Fecha y Hora";
            this.TimeColum.Name = "TimeColum";
            this.TimeColum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UserColum
            // 
            this.UserColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserColum.HeaderText = "Usuario";
            this.UserColum.Name = "UserColum";
            this.UserColum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AccionColum
            // 
            this.AccionColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AccionColum.HeaderText = "Accion";
            this.AccionColum.Name = "AccionColum";
            this.AccionColum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ObjectColum
            // 
            this.ObjectColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ObjectColum.HeaderText = "Lugar";
            this.ObjectColum.Name = "ObjectColum";
            this.ObjectColum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // InformationColum
            // 
            this.InformationColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.InformationColum.HeaderText = "Informacion Adicional";
            this.InformationColum.Name = "InformationColum";
            this.InformationColum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PanelSuperior
            // 
            this.PanelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PanelSuperior.Controls.Add(this.AvatarPictureBox);
            this.PanelSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelSuperior.Name = "PanelSuperior";
            this.PanelSuperior.Size = new System.Drawing.Size(790, 90);
            this.PanelSuperior.TabIndex = 15;
            // 
            // AvatarPictureBox
            // 
            this.AvatarPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AvatarPictureBox.Image")));
            this.AvatarPictureBox.Location = new System.Drawing.Point(382, 12);
            this.AvatarPictureBox.Name = "AvatarPictureBox";
            this.AvatarPictureBox.Size = new System.Drawing.Size(65, 65);
            this.AvatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvatarPictureBox.TabIndex = 0;
            this.AvatarPictureBox.TabStop = false;
            // 
            // PanelInferior
            // 
            this.PanelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PanelInferior.Controls.Add(this.PrinterButton);
            this.PanelInferior.Controls.Add(this.NullButton);
            this.PanelInferior.Controls.Add(this.SearchButton);
            this.PanelInferior.Location = new System.Drawing.Point(0, 403);
            this.PanelInferior.Name = "PanelInferior";
            this.PanelInferior.Size = new System.Drawing.Size(790, 77);
            this.PanelInferior.TabIndex = 16;
            // 
            // PrinterButton
            // 
            this.PrinterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrinterButton.BackgroundImage")));
            this.PrinterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrinterButton.Location = new System.Drawing.Point(382, 15);
            this.PrinterButton.Name = "PrinterButton";
            this.PrinterButton.Size = new System.Drawing.Size(50, 50);
            this.PrinterButton.TabIndex = 1;
            this.PrinterButton.UseVisualStyleBackColor = true;
            this.PrinterButton.Click += new System.EventHandler(this.PrinterButton_Click);
            // 
            // NullButton
            // 
            this.NullButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NullButton.BackgroundImage")));
            this.NullButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NullButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NullButton.Location = new System.Drawing.Point(661, 15);
            this.NullButton.Name = "NullButton";
            this.NullButton.Size = new System.Drawing.Size(50, 50);
            this.NullButton.TabIndex = 2;
            this.NullButton.UseVisualStyleBackColor = true;
            this.NullButton.Click += new System.EventHandler(this.NullButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchButton.BackgroundImage")));
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.Location = new System.Drawing.Point(123, 15);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(50, 50);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // NoteBooksActivityRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.NullButton;
            this.ClientSize = new System.Drawing.Size(788, 475);
            this.Controls.Add(this.PanelInferior);
            this.Controls.Add(this.PanelSuperior);
            this.Controls.Add(this.ActivitiesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NoteBooksActivityRegisterForm";
            this.Text = "Registro De Actividades";
            ((System.ComponentModel.ISupportInitialize)(this.ActivitiesDataGridView)).EndInit();
            this.PanelSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPictureBox)).EndInit();
            this.PanelInferior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ActivitiesDataGridView;
        private System.Windows.Forms.Panel PanelSuperior;
        private System.Windows.Forms.PictureBox AvatarPictureBox;
        private System.Windows.Forms.Panel PanelInferior;
        private System.Windows.Forms.Button PrinterButton;
        private System.Windows.Forms.Button NullButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccionColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjectColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn InformationColum;
    }
}