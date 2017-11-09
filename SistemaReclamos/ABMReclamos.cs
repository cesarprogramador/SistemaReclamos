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
    public partial class ABMReclamos : Form
    {
        ClassPersonas _clientes;
        DataSet _cliente;
        ClassReclamos _reclamos;
        DataSet _historial;
        public string _idempleadosession;

        public ABMReclamos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._clientes.idpersona = this.txtBusCodigo.Text; ;
            this._clientes.apellido = this.txtBusApellido.Text;
            this._clientes.nombre = this.txtBusNombre.Text;
            this._clientes.dni = this.txtBusDni.Text;
            this._clientes.tipopersona = "Cliente";
            this._clientes.accion = "";
            this._clientes.accion = "L";

            this.dgvClientes.DataSource = this._clientes.BuscarPersonaClientes(this._clientes, "Clientes");
            this.dgvClientes.DataMember = "Clientes";

            if (this.dgvClientes.Rows.Count > 0) this.dgvClientes.Columns[0].Visible = false;
        }

        private void ABMReclamos_Load(object sender, EventArgs e)
        {
            this._clientes = new ClassPersonas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBusCodigo.Text = "";
            this.txtBusApellido.Text = "";
            this.txtBusNombre.Text = "";
            this.txtBusDni.Text = "";
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvClientes.Rows.Count > 0)
            {
                this._clientes.idpersona = this.dgvClientes[0, this.dgvClientes.CurrentCell.RowIndex].Value.ToString();

                this._cliente = this._clientes.BuscarPersonaClientes(this._clientes, "Cliente");

                if (this._cliente.Tables["Cliente"].Rows.Count > 0)
                {
                    this.txtCodigo.Text = this._clientes.idpersona;
                    this.txtDni.Text = this._cliente.Tables["Cliente"].Rows[0][2].ToString();
                    this.txtApellidoNombre.Text = this._cliente.Tables["Cliente"].Rows[0][0].ToString()+", "+this._cliente.Tables["Cliente"].Rows[0][1].ToString();
                    this.txtTelefono.Text = this._cliente.Tables["Cliente"].Rows[0][3].ToString()+"/"+this._cliente.Tables["Cliente"].Rows[0][4].ToString();
                    this.txtDomicilio.Text = this._cliente.Tables["Cliente"].Rows[0][6].ToString()+" Nº " +this._cliente.Tables["Cliente"].Rows[0][7].ToString() + " Pso:"+this._cliente.Tables["Cliente"].Rows[0][8].ToString()+" Dpto:"+this._cliente.Tables["Cliente"].Rows[0][9].ToString();
                    this.txtObservacion.Text = this._cliente.Tables["Cliente"].Rows[0][12].ToString();
                    this.txtTipoServicio.Text = this._cliente.Tables["Cliente"].Rows[0][10].ToString();
                    this.txtCorreo.Text = this._cliente.Tables["Cliente"].Rows[0][5].ToString();

                    this.ListarNumerosReclamos();

                    this.txtTipoReclamo.Text = "";
                    this.txtFechaIni.Text = "";
                    this.txtFechaFin.Text = "";
                    this.dgvDetalleProcesoReclamo.Rows.Clear();
                }

                this.gbxAcciones.Enabled = true;
                this.btnNuevo.Enabled = true;
            }
        }

        private void ListarNumerosReclamos()
        {
            //Recuperar listado de reclamos asociados al cliente
            this.cbReferenciaReclamos.DataSource = null;

            this._reclamos = new ClassReclamos();

            this._reclamos.idcliente = this._clientes.idpersona;

            DataTable _listanumreferecnias = this._reclamos.BuscarNumReferenciasDeReclamos(this._reclamos);

            this.cbReferenciaReclamos.DataSource = _listanumreferecnias;
            this.cbReferenciaReclamos.ValueMember = "idreclamo";
            this.cbReferenciaReclamos.DisplayMember = "numeroreferencia";

            this.btnEliminar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.cbReferenciaReclamos.Text = "R"+DateTime.Now.ToString("hhmmss");
            this.cbReferenciaReclamos.Enabled = false;

            ConsultasReclamos _formreclamo = new ConsultasReclamos();
            _formreclamo._numreferencia = this.cbReferenciaReclamos.Text;
            _formreclamo._idreclamo = "0";
            _formreclamo._idtiporeclamo = "0";
            _formreclamo._idproblematica = "0";
            _formreclamo._idcliente = this.dgvClientes[0, this.dgvClientes.CurrentCell.RowIndex].Value.ToString();
            _formreclamo._idempleado = this._idempleadosession;

            _formreclamo.ShowDialog();

            this.PoblarTablaHistorialReclamos();

            if (this.dgvDetalleProcesoReclamo.Rows.Count > 0)
            {
                MessageBox.Show("Se inicia circuito para dar solución a reclamo!!!");

                this.btnNuevo.Enabled = false;

                this.CicloDeChequeo();
            }
        }

        private void CicloDeChequeo()
        {
            int fil = 0;
         
            if (this.dgvDetalleProcesoReclamo.Rows.Count > 0)
            {
                ConsultasReclamos _formreclamo = new ConsultasReclamos();

                _formreclamo._idreclamo = this._historial.Tables["Historial"].Rows[0][0].ToString();
                _formreclamo._numreferencia = this.cbReferenciaReclamos.Text;
                _formreclamo._idtiporeclamo = this._historial.Tables["Historial"].Rows[0][9].ToString();
                _formreclamo._idcliente = this.dgvClientes[0, this.dgvClientes.CurrentCell.RowIndex].Value.ToString();
                _formreclamo._idempleado = "1";

                while (this.dgvDetalleProcesoReclamo[1, fil].Value.ToString() != "1")
                {
                    _formreclamo._tiporeclamo = this.txtTipoReclamo.Text;
                    _formreclamo._idproblematica = this.dgvDetalleProcesoReclamo[1, fil].Value.ToString();
                    _formreclamo._respuesta = this.dgvDetalleProcesoReclamo[3, fil].Value.ToString();

                    _formreclamo.ShowDialog();

                    this.PoblarTablaHistorialReclamos();

                    fil = this.dgvDetalleProcesoReclamo.Rows.Count - 1;
                }

                if (this.dgvDetalleProcesoReclamo[1, fil].Value.ToString() == "1")
                {
                    this.cbReferenciaReclamos.Enabled = true;

                    this.ListarNumerosReclamos();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PoblarTablaHistorialReclamos()
        {
            this.dgvDetalleProcesoReclamo.Rows.Clear();

            if (this.cbReferenciaReclamos.Text.Length > 0)
            {
                this._reclamos = new ClassReclamos();

                this._reclamos.numreferencia = this.cbReferenciaReclamos.Text;

                this._historial = this._reclamos.BuscarHistorialReclamos(this._reclamos, "Historial");

                if (this._historial.Tables["Historial"].Rows.Count > 0)
                {
                    this.txtTipoReclamo.Text = this._historial.Tables["Historial"].Rows[0][1].ToString();
                    this.txtFechaIni.Text = this._historial.Tables["Historial"].Rows[0][2].ToString();
                    this.txtFechaFin.Text = this._historial.Tables["Historial"].Rows[0][3].ToString();

                    for (int fil = 0; fil < this._historial.Tables["Historial"].Rows.Count; fil++)
                    {
                        this.dgvDetalleProcesoReclamo.Rows.Add(1);

                        this.dgvDetalleProcesoReclamo[0, fil].Value = this._historial.Tables["Historial"].Rows[fil][4].ToString();
                        this.dgvDetalleProcesoReclamo[1, fil].Value = this._historial.Tables["Historial"].Rows[fil][5].ToString();
                        this.dgvDetalleProcesoReclamo[2, fil].Value = this._historial.Tables["Historial"].Rows[fil][6].ToString();
                        this.dgvDetalleProcesoReclamo[3, fil].Value = this._historial.Tables["Historial"].Rows[fil][7].ToString();
                        this.dgvDetalleProcesoReclamo[4, fil].Value = this._historial.Tables["Historial"].Rows[fil][8].ToString();
                    }
                }
            }
        }

        private void cbReferenciaReclamos_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.PoblarTablaHistorialReclamos();

            if (this.dgvDetalleProcesoReclamo.Rows.Count > 0)
            {
                if (this.txtFechaFin.Text.Length > 0)
                {
                    this.btnEliminar.Enabled = false;
                    this.btnNuevo.Enabled = false;
                    this.txtObservacionCierre.Text = this._historial.Tables["Historial"].Rows[0][10].ToString();
                }
                else
                {
                    this.btnEliminar.Enabled = true;
                    this.btnNuevo.Enabled = true;
                }
            }
            else
            {
                this.btnEliminar.Enabled = false;
                MessageBox.Show("No existe número de referencia de reclamo!!!","Atención");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this._reclamos = new ClassReclamos();

            this._reclamos.idreclamo = this.cbReferenciaReclamos.SelectedValue.ToString();
            this._reclamos.idproblematicareclamo = "2";
            this._reclamos.numreferencia = "";
            this._reclamos.idcliente = "0";
            this._reclamos.idtiporeclamo = "0";
            this._reclamos.idempleado = "0";
            this._reclamos.fechaini = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._reclamos.fechafin = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            this._reclamos.respuesta = "";
            this._reclamos.observacion = "";

            this._reclamos.accion = "B";
            this._reclamos.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");

            this._historial = this._reclamos.ABMReclamo(this._reclamos, "reclamo");

            if (this._historial.Tables["reclamo"].Rows.Count>0)
            {
                MessageBox.Show("Acción realizada con exito", "Atención!!!");

                this.ListarNumerosReclamos();

                this.txtTipoReclamo.Text = "";
                this.txtFechaIni.Text = "";
                this.txtFechaFin.Text = "";
                this.dgvDetalleProcesoReclamo.Rows.Clear();
            }
            else
            {
                MessageBox.Show("Error en la eliminación del registro", "Atención!!!");
            }
        }
    }
}
