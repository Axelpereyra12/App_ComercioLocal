namespace App
{
    partial class form1
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
            this.DgvArticulos = new System.Windows.Forms.DataGridView();
            this.labelFiltroRapido = new System.Windows.Forms.Label();
            this.TextBoxFiltroRapido = new System.Windows.Forms.TextBox();
            this.labelCampo = new System.Windows.Forms.Label();
            this.ComboBoxCampo = new System.Windows.Forms.ComboBox();
            this.ComboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.BotonFiltrar = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.pictureBoxArticulos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvArticulos
            // 
            this.DgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvArticulos.Location = new System.Drawing.Point(118, 54);
            this.DgvArticulos.Name = "DgvArticulos";
            this.DgvArticulos.RowTemplate.Height = 30;
            this.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvArticulos.Size = new System.Drawing.Size(580, 263);
            this.DgvArticulos.TabIndex = 0;
            this.DgvArticulos.SelectionChanged += new System.EventHandler(this.DgvArticulos_SelectionChanged);
            // 
            // labelFiltroRapido
            // 
            this.labelFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFiltroRapido.AutoSize = true;
            this.labelFiltroRapido.Location = new System.Drawing.Point(204, 31);
            this.labelFiltroRapido.Name = "labelFiltroRapido";
            this.labelFiltroRapido.Size = new System.Drawing.Size(40, 13);
            this.labelFiltroRapido.TabIndex = 2;
            this.labelFiltroRapido.Text = "Buscar";
            // 
            // TextBoxFiltroRapido
            // 
            this.TextBoxFiltroRapido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxFiltroRapido.Location = new System.Drawing.Point(257, 28);
            this.TextBoxFiltroRapido.Name = "TextBoxFiltroRapido";
            this.TextBoxFiltroRapido.Size = new System.Drawing.Size(324, 20);
            this.TextBoxFiltroRapido.TabIndex = 3;
            this.TextBoxFiltroRapido.TextChanged += new System.EventHandler(this.TextBoxFiltroRapido_TextChanged);
            // 
            // labelCampo
            // 
            this.labelCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(115, 376);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(40, 13);
            this.labelCampo.TabIndex = 8;
            this.labelCampo.Text = "Campo";
            // 
            // ComboBoxCampo
            // 
            this.ComboBoxCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxCampo.FormattingEnabled = true;
            this.ComboBoxCampo.Location = new System.Drawing.Point(168, 373);
            this.ComboBoxCampo.Name = "ComboBoxCampo";
            this.ComboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCampo.TabIndex = 9;
            this.ComboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCampo_SelectedIndexChanged);
            // 
            // ComboBoxCriterio
            // 
            this.ComboBoxCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxCriterio.FormattingEnabled = true;
            this.ComboBoxCriterio.Location = new System.Drawing.Point(339, 372);
            this.ComboBoxCriterio.Name = "ComboBoxCriterio";
            this.ComboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCriterio.TabIndex = 11;
            // 
            // labelCriterio
            // 
            this.labelCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(298, 375);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(39, 13);
            this.labelCriterio.TabIndex = 10;
            this.labelCriterio.Text = "Criterio";
            // 
            // labelFiltro
            // 
            this.labelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(482, 375);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(29, 13);
            this.labelFiltro.TabIndex = 12;
            this.labelFiltro.Text = "Filtro";
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(523, 373);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltroAvanzado.TabIndex = 13;
            // 
            // BotonFiltrar
            // 
            this.BotonFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotonFiltrar.Location = new System.Drawing.Point(638, 370);
            this.BotonFiltrar.Name = "BotonFiltrar";
            this.BotonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BotonFiltrar.TabIndex = 14;
            this.BotonFiltrar.Text = "Buscar";
            this.BotonFiltrar.UseVisualStyleBackColor = true;
            this.BotonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.BotonEliminar.Image = global::App.Properties.Resources.img_eliminar;
            this.BotonEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonEliminar.Location = new System.Drawing.Point(10, 242);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(102, 70);
            this.BotonEliminar.TabIndex = 16;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonEliminar.UseVisualStyleBackColor = false;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.BackColor = System.Drawing.SystemColors.Window;
            this.BotonModificar.Image = global::App.Properties.Resources.img_editar;
            this.BotonModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonModificar.Location = new System.Drawing.Point(10, 151);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(102, 70);
            this.BotonModificar.TabIndex = 15;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonModificar.UseVisualStyleBackColor = false;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.BackColor = System.Drawing.SystemColors.Window;
            this.BotonAgregar.Image = global::App.Properties.Resources.img_agregar;
            this.BotonAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BotonAgregar.Location = new System.Drawing.Point(10, 54);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(102, 73);
            this.BotonAgregar.TabIndex = 4;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BotonAgregar.UseVisualStyleBackColor = false;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // pictureBoxArticulos
            // 
            this.pictureBoxArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxArticulos.Location = new System.Drawing.Point(704, 28);
            this.pictureBoxArticulos.Name = "pictureBoxArticulos";
            this.pictureBoxArticulos.Size = new System.Drawing.Size(264, 332);
            this.pictureBoxArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulos.TabIndex = 1;
            this.pictureBoxArticulos.TabStop = false;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(977, 443);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.BotonFiltrar);
            this.Controls.Add(this.textBoxFiltroAvanzado);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.ComboBoxCriterio);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.ComboBoxCampo);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.BotonAgregar);
            this.Controls.Add(this.TextBoxFiltroRapido);
            this.Controls.Add(this.labelFiltroRapido);
            this.Controls.Add(this.pictureBoxArticulos);
            this.Controls.Add(this.DgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvArticulos;
        private System.Windows.Forms.PictureBox pictureBoxArticulos;
        private System.Windows.Forms.Label labelFiltroRapido;
        private System.Windows.Forms.TextBox TextBoxFiltroRapido;
        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.ComboBox ComboBoxCampo;
        private System.Windows.Forms.ComboBox ComboBoxCriterio;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
        private System.Windows.Forms.Button BotonFiltrar;
        private System.Windows.Forms.Button BotonModificar;
        private System.Windows.Forms.Button BotonEliminar;
    }
}

