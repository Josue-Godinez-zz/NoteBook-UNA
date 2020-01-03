namespace NoteBook
{
    partial class VisualizarContenidoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarContenidoForm));
            this.FondoLabel = new System.Windows.Forms.Label();
            this.FondoButton = new System.Windows.Forms.Button();
            this.LetraLabel = new System.Windows.Forms.Label();
            this.LetraButton = new System.Windows.Forms.Button();
            this.FuenteLabel = new System.Windows.Forms.Label();
            this.FuenteButton = new System.Windows.Forms.Button();
            this.ContenidoTextBox = new System.Windows.Forms.TextBox();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.ColorNota = new System.Windows.Forms.ColorDialog();
            this.Fuente = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // FondoLabel
            // 
            this.FondoLabel.AutoSize = true;
            this.FondoLabel.BackColor = System.Drawing.Color.Transparent;
            this.FondoLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FondoLabel.Location = new System.Drawing.Point(12, 30);
            this.FondoLabel.Name = "FondoLabel";
            this.FondoLabel.Size = new System.Drawing.Size(86, 15);
            this.FondoLabel.TabIndex = 0;
            this.FondoLabel.Text = "Color Fondo:";
            // 
            // FondoButton
            // 
            this.FondoButton.Location = new System.Drawing.Point(104, 25);
            this.FondoButton.Name = "FondoButton";
            this.FondoButton.Size = new System.Drawing.Size(23, 23);
            this.FondoButton.TabIndex = 1;
            this.FondoButton.UseVisualStyleBackColor = true;
            this.FondoButton.Click += new System.EventHandler(this.FondoButton_Click);
            // 
            // LetraLabel
            // 
            this.LetraLabel.AutoSize = true;
            this.LetraLabel.BackColor = System.Drawing.Color.Transparent;
            this.LetraLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LetraLabel.Location = new System.Drawing.Point(12, 82);
            this.LetraLabel.Name = "LetraLabel";
            this.LetraLabel.Size = new System.Drawing.Size(80, 15);
            this.LetraLabel.TabIndex = 2;
            this.LetraLabel.Text = "Color Letra:";
            // 
            // LetraButton
            // 
            this.LetraButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LetraButton.FlatAppearance.BorderSize = 3;
            this.LetraButton.Location = new System.Drawing.Point(104, 77);
            this.LetraButton.Name = "LetraButton";
            this.LetraButton.Size = new System.Drawing.Size(23, 23);
            this.LetraButton.TabIndex = 3;
            this.LetraButton.UseVisualStyleBackColor = true;
            this.LetraButton.Click += new System.EventHandler(this.LetraButton_Click);
            // 
            // FuenteLabel
            // 
            this.FuenteLabel.AutoSize = true;
            this.FuenteLabel.BackColor = System.Drawing.Color.Transparent;
            this.FuenteLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FuenteLabel.Location = new System.Drawing.Point(15, 136);
            this.FuenteLabel.Name = "FuenteLabel";
            this.FuenteLabel.Size = new System.Drawing.Size(53, 15);
            this.FuenteLabel.TabIndex = 4;
            this.FuenteLabel.Text = "Fuente:";
            // 
            // FuenteButton
            // 
            this.FuenteButton.Location = new System.Drawing.Point(77, 129);
            this.FuenteButton.Name = "FuenteButton";
            this.FuenteButton.Size = new System.Drawing.Size(50, 26);
            this.FuenteButton.TabIndex = 5;
            this.FuenteButton.Text = "AaBb";
            this.FuenteButton.UseVisualStyleBackColor = true;
            this.FuenteButton.Click += new System.EventHandler(this.FuenteButton_Click);
            // 
            // ContenidoTextBox
            // 
            this.ContenidoTextBox.BackColor = System.Drawing.Color.OldLace;
            this.ContenidoTextBox.Location = new System.Drawing.Point(169, 12);
            this.ContenidoTextBox.Multiline = true;
            this.ContenidoTextBox.Name = "ContenidoTextBox";
            this.ContenidoTextBox.Size = new System.Drawing.Size(253, 267);
            this.ContenidoTextBox.TabIndex = 6;
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackColor = System.Drawing.SystemColors.Control;
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.Location = new System.Drawing.Point(12, 316);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButton.Image")));
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.Location = new System.Drawing.Point(357, 316);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(78, 23);
            this.CancelarButton.TabIndex = 8;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // VisualizarContenidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(447, 351);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ContenidoTextBox);
            this.Controls.Add(this.FuenteButton);
            this.Controls.Add(this.FuenteLabel);
            this.Controls.Add(this.LetraButton);
            this.Controls.Add(this.LetraLabel);
            this.Controls.Add(this.FondoButton);
            this.Controls.Add(this.FondoLabel);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualizarContenidoForm";
            this.Text = "Visualizar Contenido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FondoLabel;
        private System.Windows.Forms.Button FondoButton;
        private System.Windows.Forms.Label LetraLabel;
        private System.Windows.Forms.Button LetraButton;
        private System.Windows.Forms.Label FuenteLabel;
        private System.Windows.Forms.Button FuenteButton;
        private System.Windows.Forms.TextBox ContenidoTextBox;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.ColorDialog ColorNota;
        private System.Windows.Forms.FontDialog Fuente;
    }
}