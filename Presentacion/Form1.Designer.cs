
namespace Presentacion
{
    partial class Form1
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
            this.grillaArticulos = new System.Windows.Forms.DataGridView();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.labelCampo = new System.Windows.Forms.Label();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.textBoxCampo = new System.Windows.Forms.TextBox();
            this.textBoxCriterio = new System.Windows.Forms.TextBox();
            this.textBoxFiltro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaArticulos
            // 
            this.grillaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaArticulos.Location = new System.Drawing.Point(43, 75);
            this.grillaArticulos.Name = "grillaArticulos";
            this.grillaArticulos.Size = new System.Drawing.Size(443, 217);
            this.grillaArticulos.TabIndex = 0;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(545, 75);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(287, 217);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(201, 324);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 41);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(320, 324);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 41);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(436, 324);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 41);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(674, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 34);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(545, 324);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(99, 41);
            this.btnDetalle.TabIndex = 6;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(80, 34);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(46, 13);
            this.labelCampo.TabIndex = 7;
            this.labelCampo.Text = "Campo :";
            // 
            // labelCriterio
            // 
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(288, 34);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(45, 13);
            this.labelCriterio.TabIndex = 8;
            this.labelCriterio.Text = "Criterio :";
            // 
            // labelFiltro
            // 
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(486, 34);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(35, 13);
            this.labelFiltro.TabIndex = 9;
            this.labelFiltro.Text = "Filtro :";
            // 
            // textBoxCampo
            // 
            this.textBoxCampo.Location = new System.Drawing.Point(132, 31);
            this.textBoxCampo.Name = "textBoxCampo";
            this.textBoxCampo.Size = new System.Drawing.Size(141, 20);
            this.textBoxCampo.TabIndex = 10;
            // 
            // textBoxCriterio
            // 
            this.textBoxCriterio.Location = new System.Drawing.Point(339, 31);
            this.textBoxCriterio.Name = "textBoxCriterio";
            this.textBoxCriterio.Size = new System.Drawing.Size(141, 20);
            this.textBoxCriterio.TabIndex = 11;
            // 
            // textBoxFiltro
            // 
            this.textBoxFiltro.Location = new System.Drawing.Point(527, 31);
            this.textBoxFiltro.Name = "textBoxFiltro";
            this.textBoxFiltro.Size = new System.Drawing.Size(141, 20);
            this.textBoxFiltro.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 397);
            this.Controls.Add(this.textBoxFiltro);
            this.Controls.Add(this.textBoxCriterio);
            this.Controls.Add(this.textBoxCampo);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.grillaArticulos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaArticulos;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.TextBox textBoxCampo;
        private System.Windows.Forms.TextBox textBoxCriterio;
        private System.Windows.Forms.TextBox textBoxFiltro;
    }
}

