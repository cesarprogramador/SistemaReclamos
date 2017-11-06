using SistemaReclamos.personas;
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
        string bandera;

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

                    this.btnNuevo.Enabled = true;
                }

                this.gbxAcciones.Enabled = true;
                this.btnNuevo.Enabled = true;
                this.btnModificar.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ConsultasReclamos _reclamo = new ConsultasReclamos();
            _reclamo.ShowDialog();
        }
    }
}
