namespace NoteBook.UNA.NoteBook.Forms
{
    partial class BuscarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarForm));
            this.BuscarDataGridView = new System.Windows.Forms.DataGridView();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.BuscarTituloTextBox = new System.Windows.Forms.TextBox();
            this.BuscarTituloButton = new System.Windows.Forms.Button();
            this.BuscarCategoriaTextBox = new System.Windows.Forms.TextBox();
            this.BuscarCategoriaButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.BuscarTituloLabel = new System.Windows.Forms.Label();
            this.BuscarCategoriaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarDataGridView
            // 
            this.BuscarDataGridView.AllowUserToAddRows = false;
            this.BuscarDataGridView.AllowUserToDeleteRows = false;
            this.BuscarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.BuscarDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BuscarDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BuscarDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BuscarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BuscarDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.BuscarDataGridView.EnableHeadersVisualStyles = false;
            this.BuscarDataGridView.Location = new System.Drawing.Point(12, 111);
            this.BuscarDataGridView.Name = "BuscarDataGridView";
            this.BuscarDataGridView.ReadOnly = true;
            this.BuscarDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BuscarDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.BuscarDataGridView.RowHeadersVisible = false;
            this.BuscarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BuscarDataGridView.Size = new System.Drawing.Size(496, 271);
            this.BuscarDataGridView.TabIndex = 1;
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.BackColor = System.Drawing.SystemColors.Control;
            this.LimpiarButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.LimpiarButton.FlatAppearance.BorderSize = 2;
            this.LimpiarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarButton.Location = new System.Drawing.Point(412, 6);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(96, 28);
            this.LimpiarButton.TabIndex = 5;
            this.LimpiarButton.Text = "Limpiar Filtros";
            this.LimpiarButton.UseVisualStyleBackColor = false;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // BuscarTituloTextBox
            // 
            this.BuscarTituloTextBox.Location = new System.Drawing.Point(12, 30);
            this.BuscarTituloTextBox.Name = "BuscarTituloTextBox";
            this.BuscarTituloTextBox.Size = new System.Drawing.Size(158, 20);
            this.BuscarTituloTextBox.TabIndex = 3;
            // 
            // BuscarTituloButton
            // 
            this.BuscarTituloButton.BackColor = System.Drawing.SystemColors.Control;
            this.BuscarTituloButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BuscarTituloButton.FlatAppearance.BorderSize = 2;
            this.BuscarTituloButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarTituloButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarTituloButton.Image")));
            this.BuscarTituloButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarTituloButton.Location = new System.Drawing.Point(176, 24);
            this.BuscarTituloButton.Name = "BuscarTituloButton";
            this.BuscarTituloButton.Size = new System.Drawing.Size(69, 28);
            this.BuscarTituloButton.TabIndex = 4;
            this.BuscarTituloButton.Text = "Buscar";
            this.BuscarTituloButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarTituloButton.UseVisualStyleBackColor = false;
            this.BuscarTituloButton.Click += new System.EventHandler(this.BuscarTituloButton_Click);
            // 
            // BuscarCategoriaTextBox
            // 
            this.BuscarCategoriaTextBox.Location = new System.Drawing.Point(12, 79);
            this.BuscarCategoriaTextBox.Name = "BuscarCategoriaTextBox";
            this.BuscarCategoriaTextBox.Size = new System.Drawing.Size(158, 20);
            this.BuscarCategoriaTextBox.TabIndex = 6;
            // 
            // BuscarCategoriaButton
            // 
            this.BuscarCategoriaButton.BackColor = System.Drawing.SystemColors.Control;
            this.BuscarCategoriaButton.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.BuscarCategoriaButton.FlatAppearance.BorderSize = 2;
            this.BuscarCategoriaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarCategoriaButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarCategoriaButton.Image")));
            this.BuscarCategoriaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarCategoriaButton.Location = new System.Drawing.Point(176, 73);
            this.BuscarCategoriaButton.Name = "BuscarCategoriaButton";
            this.BuscarCategoriaButton.Size = new System.Drawing.Size(69, 27);
            this.BuscarCategoriaButton.TabIndex = 7;
            this.BuscarCategoriaButton.Text = "Buscar";
            this.BuscarCategoriaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarCategoriaButton.UseVisualStyleBackColor = false;
            this.BuscarCategoriaButton.Click += new System.EventHandler(this.BuscarCategoriaButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.BackColor = System.Drawing.SystemColors.Control;
            this.CancelarButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.CancelarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelarButton.Image = ((System.Drawing.Image)(resources.GetObject("CancelarButton.Image")));
            this.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelarButton.Location = new System.Drawing.Point(430, 390);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(78, 23);
            this.CancelarButton.TabIndex = 8;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelarButton.UseVisualStyleBackColor = false;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // BuscarTituloLabel
            // 
            this.BuscarTituloLabel.AutoSize = true;
            this.BuscarTituloLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuscarTituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarTituloLabel.ForeColor = System.Drawing.Color.Black;
            this.BuscarTituloLabel.Location = new System.Drawing.Point(40, 15);
            this.BuscarTituloLabel.Name = "BuscarTituloLabel";
            this.BuscarTituloLabel.Size = new System.Drawing.Size(99, 15);
            this.BuscarTituloLabel.TabIndex = 10;
            this.BuscarTituloLabel.Text = "Buscar por Titulo";
            // 
            // BuscarCategoriaLabel
            // 
            this.BuscarCategoriaLabel.AutoSize = true;
            this.BuscarCategoriaLabel.BackColor = System.Drawing.Color.Transparent;
            this.BuscarCategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarCategoriaLabel.ForeColor = System.Drawing.Color.Black;
            this.BuscarCategoriaLabel.Location = new System.Drawing.Point(29, 64);
            this.BuscarCategoriaLabel.Name = "BuscarCategoriaLabel";
            this.BuscarCategoriaLabel.Size = new System.Drawing.Size(122, 15);
            this.BuscarCategoriaLabel.TabIndex = 11;
            this.BuscarCategoriaLabel.Text = "Buscar por Categoria";
            // 
            // BuscarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 418);
            this.Controls.Add(this.BuscarCategoriaLabel);
            this.Controls.Add(this.BuscarTituloLabel);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.BuscarCategoriaButton);
            this.Controls.Add(this.BuscarCategoriaTextBox);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.BuscarTituloTextBox);
            this.Controls.Add(this.BuscarTituloButton);
            this.Controls.Add(this.BuscarDataGridView);
            this.Name = "BuscarForm";
            this.Text = "Buscar";
            ((System.ComponentModel.ISupportInitialize)(this.BuscarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BuscarDataGridView;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.TextBox BuscarTituloTextBox;
        private System.Windows.Forms.Button BuscarTituloButton;
        private System.Windows.Forms.TextBox BuscarCategoriaTextBox;
        private System.Windows.Forms.Button BuscarCategoriaButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Label BuscarTituloLabel;
        private System.Windows.Forms.Label BuscarCategoriaLabel;
    }
}