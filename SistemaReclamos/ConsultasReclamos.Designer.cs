namespace SistemaReclamos
{
    partial class ConsultasReclamos
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
            this.cbRespuesta = new System.Windows.Forms.ComboBox();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoReclamos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(270, 214);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Siguiente";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbRespuesta
            // 
            this.cbRespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRespuesta.FormattingEnabled = true;
            this.cbRespuesta.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cbRespuesta.Location = new System.Drawing.Point(78, 114);
            this.cbRespuesta.Name = "cbRespuesta";
            this.cbRespuesta.Size = new System.Drawing.Size(260, 21);
            this.cbRespuesta.TabIndex = 2;
            this.cbRespuesta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbRespuesta_KeyPress);
            // 
            // txtConsulta
            // 
            this.txtConsulta.Enabled = false;
            this.txtConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsulta.Location = new System.Drawing.Point(78, 41);
            this.txtConsulta.Multiline = true;
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.Size = new System.Drawing.Size(260, 67);
            this.txtConsulta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consulta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Respuesta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo reclamo:";
            // 
            // cbTipoReclamos
            // 
            this.cbTipoReclamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoReclamos.FormattingEnabled = true;
            this.cbTipoReclamos.Location = new System.Drawing.Point(78, 12);
            this.cbTipoReclamos.Name = "cbTipoReclamos";
            this.cbTipoReclamos.Size = new System.Drawing.Size(260, 21);
            this.cbTipoReclamos.TabIndex = 6;
            this.cbTipoReclamos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTipoReclamos_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Observación:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacion.Location = new System.Drawing.Point(78, 141);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(260, 67);
            this.txtObservacion.TabIndex = 8;
            // 
            // ConsultasReclamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 246);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoReclamos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConsulta);
            this.Controls.Add(this.cbRespuesta);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConsultasReclamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas del reclamos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsultasReclamos_FormClosing);
            this.Load += new System.EventHandler(this.ConsultasReclamos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbRespuesta;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTipoReclamos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtObservacion;
    }
}