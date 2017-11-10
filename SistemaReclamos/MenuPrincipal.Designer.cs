namespace SistemaReclamos
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSessiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMReclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMCierreDeReclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbxBuscador = new System.Windows.Forms.GroupBox();
            this.cbBusTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusNombre = new System.Windows.Forms.TextBox();
            this.txtBusApellido = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxHistorial = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReclamos = new System.Windows.Forms.DataGridView();
            this.dgvHistorialReclamos = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.gbxBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.gbxHistorial.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialReclamos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.aBMToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(889, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivosToolStripMenuItem
            // 
            this.archivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSessiónToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem1});
            this.archivosToolStripMenuItem.Name = "archivosToolStripMenuItem";
            this.archivosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.archivosToolStripMenuItem.Text = "Archivos";
            // 
            // cerrarSessiónToolStripMenuItem
            // 
            this.cerrarSessiónToolStripMenuItem.Name = "cerrarSessiónToolStripMenuItem";
            this.cerrarSessiónToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cerrarSessiónToolStripMenuItem.Text = "Cerrar sessión";
            this.cerrarSessiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSessiónToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMEmpleadosToolStripMenuItem,
            this.aBMClientesToolStripMenuItem,
            this.aBMReclamosToolStripMenuItem,
            this.aBMCierreDeReclamosToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // aBMEmpleadosToolStripMenuItem
            // 
            this.aBMEmpleadosToolStripMenuItem.Name = "aBMEmpleadosToolStripMenuItem";
            this.aBMEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.aBMEmpleadosToolStripMenuItem.Text = "Empleados";
            this.aBMEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.aBMEmpleadosToolStripMenuItem_Click);
            // 
            // aBMClientesToolStripMenuItem
            // 
            this.aBMClientesToolStripMenuItem.Name = "aBMClientesToolStripMenuItem";
            this.aBMClientesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.aBMClientesToolStripMenuItem.Text = "Clientes";
            this.aBMClientesToolStripMenuItem.Click += new System.EventHandler(this.aBMClientesToolStripMenuItem_Click);
            // 
            // aBMReclamosToolStripMenuItem
            // 
            this.aBMReclamosToolStripMenuItem.Name = "aBMReclamosToolStripMenuItem";
            this.aBMReclamosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.aBMReclamosToolStripMenuItem.Text = "Reclamos";
            this.aBMReclamosToolStripMenuItem.Click += new System.EventHandler(this.aBMReclamosToolStripMenuItem_Click);
            // 
            // aBMCierreDeReclamosToolStripMenuItem
            // 
            this.aBMCierreDeReclamosToolStripMenuItem.Name = "aBMCierreDeReclamosToolStripMenuItem";
            this.aBMCierreDeReclamosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.aBMCierreDeReclamosToolStripMenuItem.Text = "Cierre de reclamos";
            this.aBMCierreDeReclamosToolStripMenuItem.Click += new System.EventHandler(this.aBMCierreDeReclamosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // gbxBuscador
            // 
            this.gbxBuscador.Controls.Add(this.cbBusTipoEmpleado);
            this.gbxBuscador.Controls.Add(this.label2);
            this.gbxBuscador.Controls.Add(this.label1);
            this.gbxBuscador.Controls.Add(this.txtBusNombre);
            this.gbxBuscador.Controls.Add(this.txtBusApellido);
            this.gbxBuscador.Controls.Add(this.dgvEmpleados);
            this.gbxBuscador.Controls.Add(this.btnLimpiar);
            this.gbxBuscador.Controls.Add(this.btnBuscar);
            this.gbxBuscador.Controls.Add(this.label4);
            this.gbxBuscador.Controls.Add(this.txtBusDni);
            this.gbxBuscador.Controls.Add(this.label3);
            this.gbxBuscador.Location = new System.Drawing.Point(12, 27);
            this.gbxBuscador.Name = "gbxBuscador";
            this.gbxBuscador.Size = new System.Drawing.Size(297, 589);
            this.gbxBuscador.TabIndex = 17;
            this.gbxBuscador.TabStop = false;
            this.gbxBuscador.Text = "Buscador";
            // 
            // cbBusTipoEmpleado
            // 
            this.cbBusTipoEmpleado.FormattingEnabled = true;
            this.cbBusTipoEmpleado.Location = new System.Drawing.Point(100, 19);
            this.cbBusTipoEmpleado.Name = "cbBusTipoEmpleado";
            this.cbBusTipoEmpleado.Size = new System.Drawing.Size(191, 21);
            this.cbBusTipoEmpleado.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Tipo de empleado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombres:";
            // 
            // txtBusNombre
            // 
            this.txtBusNombre.Location = new System.Drawing.Point(100, 79);
            this.txtBusNombre.Name = "txtBusNombre";
            this.txtBusNombre.Size = new System.Drawing.Size(191, 20);
            this.txtBusNombre.TabIndex = 14;
            // 
            // txtBusApellido
            // 
            this.txtBusApellido.Location = new System.Drawing.Point(100, 51);
            this.txtBusApellido.Name = "txtBusApellido";
            this.txtBusApellido.Size = new System.Drawing.Size(191, 20);
            this.txtBusApellido.TabIndex = 13;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(16, 181);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(267, 395);
            this.dgvEmpleados.TabIndex = 12;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Image = global::SistemaReclamos.Properties.Resources.Refresh;
            this.btnLimpiar.Location = new System.Drawing.Point(172, 133);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 42);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Image = global::SistemaReclamos.Properties.Resources.Search;
            this.btnBuscar.Location = new System.Drawing.Point(54, 133);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 42);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido:";
            // 
            // txtBusDni
            // 
            this.txtBusDni.Location = new System.Drawing.Point(100, 107);
            this.txtBusDni.Name = "txtBusDni";
            this.txtBusDni.Size = new System.Drawing.Size(191, 20);
            this.txtBusDni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dni:";
            // 
            // gbxHistorial
            // 
            this.gbxHistorial.Controls.Add(this.label5);
            this.gbxHistorial.Controls.Add(this.txtObservacion);
            this.gbxHistorial.Controls.Add(this.groupBox1);
            this.gbxHistorial.Controls.Add(this.dgvHistorialReclamos);
            this.gbxHistorial.Location = new System.Drawing.Point(315, 27);
            this.gbxHistorial.Name = "gbxHistorial";
            this.gbxHistorial.Size = new System.Drawing.Size(562, 589);
            this.gbxHistorial.TabIndex = 18;
            this.gbxHistorial.TabStop = false;
            this.gbxHistorial.Text = "Historial reclamos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Observación por cierre del reclamo:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(195, 530);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(347, 46);
            this.txtObservacion.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReclamos);
            this.groupBox1.Location = new System.Drawing.Point(18, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 187);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reclamos";
            // 
            // dgvReclamos
            // 
            this.dgvReclamos.AllowUserToAddRows = false;
            this.dgvReclamos.AllowUserToDeleteRows = false;
            this.dgvReclamos.AllowUserToOrderColumns = true;
            this.dgvReclamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReclamos.Location = new System.Drawing.Point(18, 22);
            this.dgvReclamos.Name = "dgvReclamos";
            this.dgvReclamos.ReadOnly = true;
            this.dgvReclamos.Size = new System.Drawing.Size(489, 150);
            this.dgvReclamos.TabIndex = 13;
            this.dgvReclamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReclamos_CellClick);
            // 
            // dgvHistorialReclamos
            // 
            this.dgvHistorialReclamos.AllowUserToAddRows = false;
            this.dgvHistorialReclamos.AllowUserToDeleteRows = false;
            this.dgvHistorialReclamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorialReclamos.Location = new System.Drawing.Point(18, 228);
            this.dgvHistorialReclamos.Name = "dgvHistorialReclamos";
            this.dgvHistorialReclamos.ReadOnly = true;
            this.dgvHistorialReclamos.Size = new System.Drawing.Size(525, 289);
            this.dgvHistorialReclamos.TabIndex = 13;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 629);
            this.Controls.Add(this.gbxHistorial);
            this.Controls.Add(this.gbxBuscador);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxBuscador.ResumeLayout(false);
            this.gbxBuscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.gbxHistorial.ResumeLayout(false);
            this.gbxHistorial.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReclamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialReclamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMReclamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMCierreDeReclamosToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxBuscador;
        private System.Windows.Forms.ComboBox cbBusTipoEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusNombre;
        private System.Windows.Forms.TextBox txtBusApellido;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBusDni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxHistorial;
        private System.Windows.Forms.DataGridView dgvHistorialReclamos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvReclamos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObservacion;
    }
}