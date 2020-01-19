namespace NoteBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarNotasForm));
            this.VisualizarDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.AbrirButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.SalirLabel = new System.Windows.Forms.Label();
            this.AbriLabel = new System.Windows.Forms.Label();
            this.PropiedadesLabel = new System.Windows.Forms.Label();
            this.AgregarLabel = new System.Windows.Forms.Label();
            this.NotasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VisualizarDataGridView
            // 
            this.VisualizarDataGridView.AllowUserToAddRows = false;
            this.VisualizarDataGridView.AllowUserToDeleteRows = false;
            this.VisualizarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.VisualizarDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.VisualizarDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
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
            this.VisualizarDataGridView.EnableHeadersVisualStyles = false;
            this.VisualizarDataGridView.Location = new System.Drawing.Point(138, 78);
            this.VisualizarDataGridView.Name = "VisualizarDataGridView";
            this.VisualizarDataGridView.ReadOnly = true;
            this.VisualizarDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.VisualizarDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.VisualizarDataGridView.RowHeadersVisible = false;
            this.VisualizarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            // SalirButton
            // 
            this.SalirButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SalirButton.BackgroundImage")));
            this.SalirButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SalirButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.SalirButton.FlatAppearance.BorderSize = 2;
            this.SalirButton.Location = new System.Drawing.Point(22, 305);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(51, 44);
            this.SalirButton.TabIndex = 3;
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.CancelarButton_Click);
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
            // SalirLabel
            // 
            this.SalirLabel.AutoSize = true;
            this.SalirLabel.BackColor = System.Drawing.Color.Transparent;
            this.SalirLabel.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirLabel.Location = new System.Drawing.Point(28, 352);
            this.SalirLabel.Name = "SalirLabel";
            this.SalirLabel.Size = new System.Drawing.Size(37, 15);
            this.SalirLabel.TabIndex = 9;
            this.SalirLabel.Text = "Salir";
            // 
            // AbriLabel
            // 
            this.AbriLabel.AutoSize = true;
            this.AbriLabel.BackColor = System.Drawing.Color.Transparent;
            this.AbriLabel.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbriLabel.Location = new System.Drawing.Point(17, 258);
            this.AbriLabel.Name = "AbriLabel";
            this.AbriLabel.Size = new System.Drawing.Size(61, 14);
            this.AbriLabel.TabIndex = 10;
            this.AbriLabel.Text = "Abrir Nota";
            // 
            // PropiedadesLabel
            // 
            this.PropiedadesLabel.AutoSize = true;
            this.PropiedadesLabel.BackColor = System.Drawing.Color.Transparent;
            this.PropiedadesLabel.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropiedadesLabel.Location = new System.Drawing.Point(13, 190);
            this.PropiedadesLabel.Name = "PropiedadesLabel";
            this.PropiedadesLabel.Size = new System.Drawing.Size(69, 14);
            this.PropiedadesLabel.TabIndex = 11;
            this.PropiedadesLabel.Text = "Propiedades";
            // 
            // AgregarLabel
            // 
            this.AgregarLabel.AutoSize = true;
            this.AgregarLabel.BackColor = System.Drawing.Color.Transparent;
            this.AgregarLabel.Font = new System.Drawing.Font("Lucida Handwriting", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarLabel.Location = new System.Drawing.Point(11, 124);
            this.AgregarLabel.Name = "AgregarLabel";
            this.AgregarLabel.Size = new System.Drawing.Size(75, 14);
            this.AgregarLabel.TabIndex = 12;
            this.AgregarLabel.Text = "Agregar Nota";
            // 
            // NotasLabel
            // 
            this.NotasLabel.AutoSize = true;
            this.NotasLabel.BackColor = System.Drawing.Color.Transparent;
            this.NotasLabel.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotasLabel.Location = new System.Drawing.Point(353, 54);
            this.NotasLabel.Name = "NotasLabel";
            this.NotasLabel.Size = new System.Drawing.Size(95, 21);
            this.NotasLabel.TabIndex = 13;
            this.NotasLabel.Text = "Mis Notas";
            // 
            // VisualizarNotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 379);
            this.ControlBox = false;
            this.Controls.Add(this.NotasLabel);
            this.Controls.Add(this.AgregarLabel);
            this.Controls.Add(this.PropiedadesLabel);
            this.Controls.Add(this.AbriLabel);
            this.Controls.Add(this.SalirLabel);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.BuscarTextBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.AbrirButton);
            this.Controls.Add(this.SalirButton);
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
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button AbrirButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label SalirLabel;
        private System.Windows.Forms.Label AbriLabel;
        private System.Windows.Forms.Label PropiedadesLabel;
        private System.Windows.Forms.Label AgregarLabel;
        private System.Windows.Forms.Label NotasLabel;
    }
}