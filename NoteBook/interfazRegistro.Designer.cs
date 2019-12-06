namespace NoteBook
{
    partial class interfazRegistro
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
            this.label1 = new System.Windows.Forms.Label();
            this.ContraseñaUsuario = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.tbConstraseñaRegistro = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Confirmacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre De Usuario";
            // 
            // ContraseñaUsuario
            // 
            this.ContraseñaUsuario.AutoSize = true;
            this.ContraseñaUsuario.Location = new System.Drawing.Point(105, 120);
            this.ContraseñaUsuario.Name = "ContraseñaUsuario";
            this.ContraseñaUsuario.Size = new System.Drawing.Size(96, 13);
            this.ContraseñaUsuario.TabIndex = 1;
            this.ContraseñaUsuario.Text = "Contraseña Nueva";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.BackColor = System.Drawing.Color.White;
            this.tbNombreUsuario.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tbNombreUsuario.Location = new System.Drawing.Point(86, 66);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNombreUsuario.Size = new System.Drawing.Size(128, 20);
            this.tbNombreUsuario.TabIndex = 2;
            this.tbNombreUsuario.Text = "fg";
            // 
            // tbConstraseñaRegistro
            // 
            this.tbConstraseñaRegistro.Location = new System.Drawing.Point(86, 145);
            this.tbConstraseñaRegistro.Name = "tbConstraseñaRegistro";
            this.tbConstraseñaRegistro.Size = new System.Drawing.Size(128, 20);
            this.tbConstraseñaRegistro.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Confirmacion
            // 
            this.Confirmacion.AutoSize = true;
            this.Confirmacion.Location = new System.Drawing.Point(105, 183);
            this.Confirmacion.Name = "Confirmacion";
            this.Confirmacion.Size = new System.Drawing.Size(0, 13);
            this.Confirmacion.TabIndex = 6;
            this.Confirmacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // interfazRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 311);
            this.Controls.Add(this.Confirmacion);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbConstraseñaRegistro);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.ContraseñaUsuario);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "interfazRegistro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ContraseñaUsuario;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.TextBox tbConstraseñaRegistro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Confirmacion;
    }
}