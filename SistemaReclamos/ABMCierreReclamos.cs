using SistemaReclamos.reclamos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReclamos
{
    public partial class ABMCierreReclamos : Form
    {
        ClassReclamos _reclamos;
        DataSet _reclamo;

        public ABMCierreReclamos()
        {
            InitializeComponent();
        }

        private void ABMCierreReclamos_Load(object sender, EventArgs e)
        {

        }

        private void ListarNumerosReclamos()
        {
            this.dgvReclamos.DataSource = null;

            this._reclamos = new ClassReclamos();

            this._reclamos.numreferencia = this.txtBusNumReferencia.Text;

            this.dgvReclamos.DataSource = this._reclamos.BuscarReclamosPorReferencia(this._reclamos, "Reclamos");
            this.dgvReclamos.DataMember = "Reclamos";

            if (this.dgvReclamos.Rows.Count > 0)
            {
                this.dgvReclamos.Columns[0].Visible = false;
                this.dgvReclamos.Columns[2].Visible = false;
                this.txtFechaFin.Text = this.dgvReclamos[2, 0].Value.ToString();

                if (this.txtFechaFin.Text.Length <= 0)
                {
                    this.txtFechaFin.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
                    this.gbxConfirmarAccion.Enabled = true;
                }
                else
                {
                    this.gbxConfirmarAccion.Enabled = false;
                }
                
                this.dgvReclamos.Columns[6].Visible = false;
                this.txtObservacion.Text = this.dgvReclamos[6, 0].Value.ToString();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtBusNumReferencia.Text.Length > 0)
            {
                this.ListarNumerosReclamos();
            }
            else
            {
                MessageBox.Show("Ingrese un número de reclamo!!!","Atención");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBusNumReferencia.Text = "";
            this.dgvReclamos.DataSource = null;
            this.txtObservacion.Text = "";
            this.gbxConfirmarAccion.Enabled = false;
        }

        private void txtObservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.txtObservacion.Text.Length > 0) this.gbxConfirmarAccion.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.btnLimpiar_Click(sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.txtObservacion.Text.Length > 0)
            {
                this._reclamos.idreclamo = this.dgvReclamos[0, 0].Value.ToString();
                this._reclamos.fechafin = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"); 
                this._reclamos.observacion = this.txtObservacion.Text;

                this._reclamos.accion = "M";
                this._reclamos.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");

                this._reclamo = this._reclamos.CierreReclamo(this._reclamos, "reclamo");

                if (this._reclamo.Tables["reclamo"].Rows.Count > 0)
                {
                    MessageBox.Show("Acción realizada con exito", "Atención!!!");

                    this.btnLimpiar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error en acción!!!", "Atención!!!");
                }
            }
        }
    }
}
