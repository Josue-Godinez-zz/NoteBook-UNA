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
            this.VisualizarDataGridView = new System.Windows.Forms.DataGridView();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.TituloColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoriaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaModificacionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrivacidadColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VisualizarDataGridView
            // 
            this.VisualizarDataGridView.AllowUserToAddRows = false;
            this.VisualizarDataGridView.AllowUserToDeleteRows = false;
            this.VisualizarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisualizarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TituloColumn,
            this.CategoriaColumn,
            this.FechaCreacionColumn,
            this.FechaModificacionColumn,
            this.PrivacidadColumn});
            this.VisualizarDataGridView.Location = new System.Drawing.Point(1, 1);
            this.VisualizarDataGridView.Name = "VisualizarDataGridView";
            this.VisualizarDataGridView.Size = new System.Drawing.Size(534, 235);
            this.VisualizarDataGridView.TabIndex = 0;
            this.VisualizarDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(1, 270);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(75, 23);
            this.AgregarButton.TabIndex = 1;
            this.AgregarButton.Text = "Nueva Nota";
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.Location = new System.Drawing.Point(110, 270);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(75, 23);
            this.EditarButton.TabIndex = 2;
            this.EditarButton.Text = "Editar Nota";
            this.EditarButton.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(435, 270);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 23);
            this.CancelarButton.TabIndex = 3;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // TituloColumn
            // 
            this.TituloColumn.HeaderText = "Titulo";
            this.TituloColumn.Name = "TituloColumn";
            this.TituloColumn.Width = 90;
            // 
            // CategoriaColumn
            // 
            this.CategoriaColumn.HeaderText = "Categoria";
            this.CategoriaColumn.Name = "CategoriaColumn";
            // 
            // FechaCreacionColumn
            // 
            this.FechaCreacionColumn.HeaderText = "Fecha de Creación";
            this.FechaCreacionColumn.Name = "FechaCreacionColumn";
            // 
            // FechaModificacionColumn
            // 
            this.FechaModificacionColumn.HeaderText = "Fecha de Modificación";
            this.FechaModificacionColumn.Name = "FechaModificacionColumn";
            // 
            // PrivacidadColumn
            // 
            this.PrivacidadColumn.HeaderText = "Privacidad";
            this.PrivacidadColumn.Name = "PrivacidadColumn";
            this.PrivacidadColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // VisualizarNotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 305);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.VisualizarDataGridView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VisualizarNotasForm";
            this.Text = "Notas";
            ((System.ComponentModel.ISupportInitialize)(this.VisualizarDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView VisualizarDataGridView;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TituloColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoriaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaModificacionColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrivacidadColumn;
    }
}