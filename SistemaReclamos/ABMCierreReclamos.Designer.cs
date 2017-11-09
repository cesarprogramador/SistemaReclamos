namespace SistemaReclamos
{
    partial class ABMCierreReclamos
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxConfirmarAccion = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvReclamos = new System.Windows.Forms.DataGridView();
            this.txtBusNumReferencia = new System.Windows.Forms.TextBox();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaFin = new System.Windows.Forms.TextBox();
            this.gbxBuscador = new System.Windows.Forms.GroupBox();
            this.gbxConfirmarAccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclamos)).BeginInit();
            this.gbxBuscador.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Image = global::SistemaReclamos.Properties.Resources.Floppy;
            this.btnAceptar.Location = new System.Drawing.Point(72, 19);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 41);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Image = global::SistemaReclamos.Properties.Resources.Undo;
            this.btnCancelar.Location = new System.Drawing.Point(252, 19);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 41);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxConfirmarAccion
            // 
            this.gbxConfirmarAccion.Controls.Add(this.btnCancelar);
            this.gbxConfirmarAccion.Controls.Add(this.btnAceptar);
            this.gbxConfirmarAccion.Enabled = false;
            this.gbxConfirmarAccion.Location = new System.Drawing.Point(12, 429);
            this.gbxConfirmarAccion.Name = "gbxConfirmarAccion";
            this.gbxConfirmarAccion.Size = new System.Drawing.Size(409, 72);
            this.gbxConfirmarAccion.TabIndex = 20;
            this.gbxConfirmarAccion.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número referencia:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Image = global::SistemaReclamos.Properties.Resources.Search;
            this.btnBuscar.Location = new System.Drawing.Point(95, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 42);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Image = global::SistemaReclamos.Properties.Resources.Refresh;
            this.btnLimpiar.Location = new System.Drawing.Point(213, 48);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 42);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvReclamos
            // 
            this.dgvReclamos.AllowUserToAddRows = false;
            this.dgvReclamos.AllowUserToDeleteRows = false;
            this.dgvReclamos.AllowUserToOrderColumns = true;
            this.dgvReclamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReclamos.Location = new System.Drawing.Point(15, 96);
            this.dgvReclamos.Name = "dgvReclamos";
            this.dgvReclamos.ReadOnly = true;
            this.dgvReclamos.Size = new System.Drawing.Size(372, 190);
            this.dgvReclamos.TabIndex = 12;
            // 
            // txtBusNumReferencia
            // 
            this.txtBusNumReferencia.Location = new System.Drawing.Point(129, 22);
            this.txtBusNumReferencia.Name = "txtBusNumReferencia";
            this.txtBusNumReferencia.Size = new System.Drawing.Size(191, 20);
            this.txtBusNumReferencia.TabIndex = 13;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(127, 327);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(260, 67);
            this.txtObservacion.TabIndex = 20;
            this.txtObservacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObservacion_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Observación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fecha cierre reclamo:";
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.Enabled = false;
            this.txtFechaFin.Location = new System.Drawing.Point(127, 299);
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(260, 20);
            this.txtFechaFin.TabIndex = 23;
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Controls.Add(this.txtFechaFin);
            this.gbxBuscador.Controls.Add(this.label2);
            this.gbxBuscador.Controls.Add(this.label1);
            this.gbxBuscador.Controls.Add(this.txtObservacion);
            this.gbxBuscador.Controls.Add(this.txtBusNumReferencia);
            this.gbxBuscador.Controls.Add(this.dgvReclamos);
            this.gbxBuscador.Controls.Add(this.btnLimpiar);
            this.gbxBuscador.Controls.Add(this.btnBuscar);
            this.gbxBuscador.Controls.Add(this.label4);
            this.gbxBuscador.Location = new System.Drawing.Point(12, 12);
            this.gbxBuscador.Name = "gbxBuscador";
            this.gbxBuscador.Size = new System.Drawing.Size(409, 411);
            this.gbxBuscador.TabIndex = 18;
            this.gbxBuscador.TabStop = false;
            this.gbxBuscador.Text = "Buscador";
            // 
            // ABMCierreReclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.gbxConfirmarAccion);
            this.Controls.Add(this.gbxBuscador);
            this.Name = "ABMCierreReclamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABM Cierre de Reclamos";
            this.Load += new System.EventHandler(this.ABMCierreReclamos_Load);
            this.gbxConfirmarAccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclamos)).EndInit();
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gbxConfirmarAccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvReclamos;
        private System.Windows.Forms.TextBox txtBusNumReferencia;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFechaFin;
        private System.Windows.Forms.GroupBox gbxBuscador;

    }
}