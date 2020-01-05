﻿namespace NoteBook
{
    partial class VisualizarNotasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarNotasForm));
            this.VisualizarDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.AbrirButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VisualizarDataGridView
            // 
            this.VisualizarDataGridView.AllowUserToAddRows = false;
            this.VisualizarDataGridView.AllowUserToDeleteRows = false;
            this.VisualizarDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VisualizarDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.VisualizarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VisualizarDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.VisualizarDataGridView.Location = new System.Drawing.Point(138, 78);
            this.VisualizarDataGridView.Name = "VisualizarDataGridView";
            this.VisualizarDataGridView.ReadOnly = true;
            this.VisualizarDataGridView.Size = new System.Drawing.Size(533, 287);
            this.VisualizarDataGridView.TabIndex = 0;
            // 
            // AgregarButton
            // 
            this.AgregarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AgregarButton.BackgroundImage")));
            this.AgregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AgregarButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.AgregarButton.FlatAppearance.BorderSize = 2;
            this.AgregarButton.Location = new System.Drawing.Point(22, 78);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(51, 43);
            this.AgregarButton.TabIndex = 1;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditarButton.BackgroundImage")));
            this.EditarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditarButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.EditarButton.FlatAppearance.BorderSize = 2;
            this.EditarButton.Location = new System.Drawing.Point(22, 143);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(51, 44);
            this.EditarButton.TabIndex = 2;
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelarButton.BackgroundImage")));
            this.CancelarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelarButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.CancelarButton.FlatAppearance.BorderSize = 2;
            this.CancelarButton.Location = new System.Drawing.Point(22, 305);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(51, 44);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // AbrirButton
            // 
            this.AbrirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AbrirButton.BackgroundImage")));
            this.AbrirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AbrirButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.AbrirButton.FlatAppearance.BorderSize = 2;
            this.AbrirButton.Location = new System.Drawing.Point(22, 211);
            this.AbrirButton.Name = "AbrirButton";
            this.AbrirButton.Size = new System.Drawing.Size(51, 44);
            this.AbrirButton.TabIndex = 5;
            this.AbrirButton.UseVisualStyleBackColor = true;
            this.AbrirButton.Click += new System.EventHandler(this.AbrirButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackColor = System.Drawing.SystemColors.Control;
            this.BuscarButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BuscarButton.FlatAppearance.BorderSize = 2;
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.Location = new System.Drawing.Point(176, 8);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(69, 28);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.Location = new System.Drawing.Point(12, 14);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(158, 20);
            this.BuscarTextBox.TabIndex = 7;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.BackColor = System.Drawing.SystemColors.Control;
            this.LimpiarButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.LimpiarButton.FlatAppearance.BorderSize = 2;
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(575, 6);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(96, 28);
            this.LimpiarButton.TabIndex = 8;
            this.LimpiarButton.Text = "Limpiar Filtros";
            this.LimpiarButton.UseVisualStyleBackColor = false;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Salir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Abrir Nota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Propiedades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Agregar Nota";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mis Notas";
            // 
            // VisualizarNotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(683, 379);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.BuscarTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.AbrirButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.VisualizarDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualizarNotasForm";
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VisualizarDataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button AbrirButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}