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
            this.FondoLabel.Location = new System.Drawing.Point(12, 30);
            this.FondoLabel.Name = "FondoLabel";
            this.FondoLabel.Size = new System.Drawing.Size(67, 13);
            this.FondoLabel.TabIndex = 0;
            this.FondoLabel.Text = "Color Fondo:";
            // 
            // FondoButton
            // 
            this.FondoButton.Location = new System.Drawing.Point(85, 25);
            this.FondoButton.Name = "FondoButton";
            this.FondoButton.Size = new System.Drawing.Size(23, 23);
            this.FondoButton.TabIndex = 1;
            this.FondoButton.UseVisualStyleBackColor = true;
            this.FondoButton.Click += new System.EventHandler(this.FondoButton_Click);
            // 
            // LetraLabel
            // 
            this.LetraLabel.AutoSize = true;
            this.LetraLabel.Location = new System.Drawing.Point(12, 82);
            this.LetraLabel.Name = "LetraLabel";
            this.LetraLabel.Size = new System.Drawing.Size(61, 13);
            this.LetraLabel.TabIndex = 2;
            this.LetraLabel.Text = "Color Letra:";
            // 
            // LetraButton
            // 
            this.LetraButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LetraButton.FlatAppearance.BorderSize = 3;
            this.LetraButton.Location = new System.Drawing.Point(85, 77);
            this.LetraButton.Name = "LetraButton";
            this.LetraButton.Size = new System.Drawing.Size(23, 23);
            this.LetraButton.TabIndex = 3;
            this.LetraButton.UseVisualStyleBackColor = true;
            this.LetraButton.Click += new System.EventHandler(this.LetraButton_Click);
            // 
            // FuenteLabel
            // 
            this.FuenteLabel.AutoSize = true;
            this.FuenteLabel.Location = new System.Drawing.Point(15, 136);
            this.FuenteLabel.Name = "FuenteLabel";
            this.FuenteLabel.Size = new System.Drawing.Size(43, 13);
            this.FuenteLabel.TabIndex = 4;
            this.FuenteLabel.Text = "Fuente:";
            // 
            // FuenteButton
            // 
            this.FuenteButton.Location = new System.Drawing.Point(58, 129);
            this.FuenteButton.Name = "FuenteButton";
            this.FuenteButton.Size = new System.Drawing.Size(50, 26);
            this.FuenteButton.TabIndex = 5;
            this.FuenteButton.Text = "AaBb";
            this.FuenteButton.UseVisualStyleBackColor = true;
            this.FuenteButton.Click += new System.EventHandler(this.FuenteButton_Click);
            // 
            // ContenidoTextBox
            // 
            this.ContenidoTextBox.Location = new System.Drawing.Point(155, 25);
            this.ContenidoTextBox.Multiline = true;
            this.ContenidoTextBox.Name = "ContenidoTextBox";
            this.ContenidoTextBox.Size = new System.Drawing.Size(253, 267);
            this.ContenidoTextBox.TabIndex = 6;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(18, 316);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(346, 316);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 8;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // VisualizarContenidoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualizarContenidoForm";
            this.Text = "VisualizarContenido";
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