using SistemaReclamos.personas;
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
    public partial class MenuPrincipal : Form
    {
        ClassPersonas _loginper;
        ClassPersonas _empleados;
        ClassReclamos _reclamos;
       
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void aBMEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMEmpleados _empleado = new ABMEmpleados();
            
            _empleado.Show();
        }

        private void aBMClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMClientes _cliente = new ABMClientes();
            _cliente.Show();
        }

        private void aBMReclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMReclamos _reclamo = new ABMReclamos();

            _reclamo._idempleadosession = this._loginper.idpersona;

            _reclamo.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this._loginper = new ClassPersonas();

            FormLogin formlogin = new FormLogin();

            formlogin.ShowDialog();

            this._loginper.idpersona = formlogin.idpersona;
            this._loginper.apellido = formlogin.apellido;
            this._loginper.nombre = formlogin.nombre;
            this._loginper.tipopersona = formlogin.tipopersona;
           
            this.Text = "Ventana Principal - Usuario: " + this._loginper.apellido + ", " + this._loginper.nombre + " - Cargo: " + this._loginper.tipopersona;

            if (this._loginper.tipopersona != "Administrador")
            {
                this.reportesToolStripMenuItem.Visible = false;
                this.aBMEmpleadosToolStripMenuItem.Visible = false;
                this.aBMCierreDeReclamosToolStripMenuItem.Visible = false;
            }
            else
            {
                this.reportesToolStripMenuItem.Visible = true;
                this.aBMEmpleadosToolStripMenuItem.Visible = true;
                this.aBMCierreDeReclamosToolStripMenuItem.Visible = true;
            }

            this.dgvEmpleados.DataSource = null;
            this.gbxBuscador.Visible = false;

            this.dgvHistorialReclamos.DataSource = null;
            this.gbxHistorial.Visible = false;
        }

        private void cerrarSessiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MenuPrincipal_Load(sender, e);
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._empleados = new ClassPersonas();

            this._empleados.idtipopersona = "0";

            DataTable _tipopersonas = this._empleados.BuscarTipoPersonas(this._empleados);

            this.cbBusTipoEmpleado.DataSource = _tipopersonas;
            this.cbBusTipoEmpleado.ValueMember = "idtipopersona";
            this.cbBusTipoEmpleado.DisplayMember = "tipopersona";

            this.dgvEmpleados.DataSource = null;
            this.gbxBuscador.Visible = true;

            this.dgvHistorialReclamos.DataSource = null;
            this.gbxHistorial.Visible = true;

            this.dgvReclamos.DataSource = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._empleados.idpersona = "0";
            this._empleados.apellido = this.txtBusApellido.Text;
            this._empleados.nombre = this.txtBusNombre.Text;
            this._empleados.dni = this.txtBusDni.Text;
            this._empleados.idtipopersona = this.cbBusTipoEmpleado.SelectedValue.ToString();
            this._empleados.accion = "";
     
            this.dgvEmpleados.DataSource = this._empleados.BuscarPersonaEmpleados(this._empleados, "Empleados");
            this.dgvEmpleados.DataMember = "Empleados";

            if (this.dgvEmpleados.Rows.Count > 0) this.dgvEmpleados.Columns[0].Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.cbBusTipoEmpleado.SelectedValue = 1;
            this.txtBusApellido.Text = "";
            this.txtBusNombre.Text = "";
            this.txtBusDni.Text = "";
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvEmpleados.Rows.Count > 0)
            {
                this.ListarNumerosReclamos();
            }
        }

        private void ListarNumerosReclamos()
        {
            //Recuperar listado de reclamos asociados al cliente
            this.dgvReclamos.DataSource = null;

            this._reclamos = new ClassReclamos();

            this._reclamos.idempleado = this.dgvEmpleados[0, this.dgvEmpleados.CurrentCell.RowIndex].Value.ToString();

            this.dgvReclamos.DataSource = this._reclamos.BuscarReclamosPorEmpleados(this._reclamos, "Reclamos");
            this.dgvReclamos.DataMember = "Reclamos";

            if (this.dgvReclamos.Rows.Count > 0)
            {
                this.dgvReclamos.Columns[0].Visible = false;
                this.dgvReclamos.Columns[6].Visible = false;
            }
        }

        private void aBMCierreDeReclamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCierreReclamos _cierrereclamo = new ABMCierreReclamos();
            
            _cierrereclamo.Show();
        }

        private void dgvReclamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvReclamos.Rows.Count > 0)
            {
                PoblarTablaHistorialReclamos();
            }
        }

        private void PoblarTablaHistorialReclamos()
        {
            this.dgvHistorialReclamos.DataSource=null;

            this._reclamos = new ClassReclamos();

            this._reclamos.numreferencia = this.dgvReclamos[3,this.dgvReclamos.CurrentCell.RowIndex].Value.ToString();
            this.txtObservacion.Text = this.dgvReclamos[6, this.dgvReclamos.CurrentCell.RowIndex].Value.ToString();

            this.dgvHistorialReclamos.DataSource = this._reclamos.BuscarHistorialReclamos(this._reclamos, "Historial");
            this.dgvHistorialReclamos.DataMember = "Historial";

            if (this.dgvHistorialReclamos.Rows.Count > 0)
            {
                this.dgvHistorialReclamos.Columns[0].Visible = false;
                this.dgvHistorialReclamos.Columns[1].Visible = false;
                this.dgvHistorialReclamos.Columns[2].Visible = false;
                this.dgvHistorialReclamos.Columns[3].Visible = false;
                this.dgvHistorialReclamos.Columns[4].Visible = false;
                this.dgvHistorialReclamos.Columns[5].Visible = false;
                this.dgvHistorialReclamos.Columns[9].Visible = false;
            }
        }
    }
}
