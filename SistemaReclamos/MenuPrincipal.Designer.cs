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
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivosToolStripMenuItem,
            this.aBMToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 24);
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
            this.cerrarSessiónToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cerrarSessiónToolStripMenuItem.Text = "Cerrar sessión";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMEmpleadosToolStripMenuItem,
            this.aBMClientesToolStripMenuItem,
            this.aBMReclamosToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // aBMEmpleadosToolStripMenuItem
            // 
            this.aBMEmpleadosToolStripMenuItem.Name = "aBMEmpleadosToolStripMenuItem";
            this.aBMEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aBMEmpleadosToolStripMenuItem.Text = "ABM Empleados";
            this.aBMEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.aBMEmpleadosToolStripMenuItem_Click);
            // 
            // aBMClientesToolStripMenuItem
            // 
            this.aBMClientesToolStripMenuItem.Name = "aBMClientesToolStripMenuItem";
            this.aBMClientesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aBMClientesToolStripMenuItem.Text = "ABM Clientes";
            this.aBMClientesToolStripMenuItem.Click += new System.EventHandler(this.aBMClientesToolStripMenuItem_Click);
            // 
            // aBMReclamosToolStripMenuItem
            // 
            this.aBMReclamosToolStripMenuItem.Name = "aBMReclamosToolStripMenuItem";
            this.aBMReclamosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aBMReclamosToolStripMenuItem.Text = "ABM Reclamos";
            this.aBMReclamosToolStripMenuItem.Click += new System.EventHandler(this.aBMReclamosToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}