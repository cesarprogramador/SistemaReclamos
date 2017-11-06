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
    public partial class ABMClientes : Form
    {
        ClassPersonas _clientes;
        DataSet _cliente;
        string bandera;

        public ABMClientes()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this._clientes.idpersona = this.txtBusCodAbonado.Text; ;
            this._clientes.apellido = this.txtBusApellido.Text;
            this._clientes.nombre = this.txtBusNombre.Text;
            this._clientes.dni = this.txtBusDni.Text;
            this._clientes.tipopersona = "Cliente";
            this._clientes.accion = "";
            if (this.cbxEliminado.Checked==true) this._clientes.accion = "B";

            this.dgvClientes.DataSource = this._clientes.BuscarPersonaClientes(this._clientes, "Clientes");
            this.dgvClientes.DataMember = "Clientes";

            if (this.dgvClientes.Rows.Count > 0) this.dgvClientes.Columns[0].Visible = false;
        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            this._clientes = new ClassPersonas();

            this._clientes.idtiposervicio = "0";
            
            DataTable _tiposervicios = this._clientes.BuscarTipoServicios(this._clientes);

            this.cbTipoServicio.DataSource = _tiposervicios;
            this.cbTipoServicio.ValueMember = "idtiposervicio";
            this.cbTipoServicio.DisplayMember = "servicio";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBusCodAbonado.Text = "";
            this.txtBusApellido.Text = "";
            this.txtBusNombre.Text = "";
            this.txtBusDni.Text = "";
            this.cbxEliminado.Checked = false;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvClientes.Rows.Count > 0)
            {
                this._clientes.idpersona = this.dgvClientes[0, this.dgvClientes.CurrentCell.RowIndex].Value.ToString();

                this._cliente = this._clientes.BuscarPersonaClientes(this._clientes, "Cliente");

                if (this._cliente.Tables["Cliente"].Rows.Count > 0)
                {
                    this.txtCodAbonado.Text = this.dgvClientes[0, this.dgvClientes.CurrentCell.RowIndex].Value.ToString();
                    this.txtApellido.Text = this._cliente.Tables["Cliente"].Rows[0][0].ToString();
                    this.txtNombre.Text = this._cliente.Tables["Cliente"].Rows[0][1].ToString();
                    this.txtDni.Text = this._cliente.Tables["Cliente"].Rows[0][2].ToString();
                    this.txtCel.Text = this._cliente.Tables["Cliente"].Rows[0][3].ToString();
                    this.txtTel.Text = this._cliente.Tables["Cliente"].Rows[0][4].ToString();
                    this.txtEmail.Text = this._cliente.Tables["Cliente"].Rows[0][5].ToString();
                    this.txtCalle.Text = this._cliente.Tables["Cliente"].Rows[0][6].ToString();
                    this.txtNumero.Text = this._cliente.Tables["Cliente"].Rows[0][7].ToString();
                    this.txtPiso.Text = this._cliente.Tables["Cliente"].Rows[0][8].ToString();
                    this.txtDpto.Text = this._cliente.Tables["Cliente"].Rows[0][9].ToString();

                    this.cbTipoServicio.Text = this._cliente.Tables["Cliente"].Rows[0][10].ToString();
                    this.txtNumReferencia.Text = this._cliente.Tables["Cliente"].Rows[0][11].ToString();
                    this.txtObservacion.Text = this._cliente.Tables["Cliente"].Rows[0][12].ToString();
                }

                this.gbxAcciones.Enabled = true;
                this.btnNuevo.Enabled = true;
                this.btnModificar.Enabled = true;
                this.btnEliminar.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.bandera = "N";
            this._clientes.idpersona = "0";
            this.txtCodAbonado.Enabled = false;
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.bandera = "M";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.bandera = "B";
            this.gbxAcciones.Enabled = false;
            this.gbxConfirmarAccion.Enabled = true;
            this.gbxBuscador.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.bandera = "";
            this._clientes.idpersona = "0";
            this.gbxAcciones.Enabled = true;
            this.btnNuevo.Enabled = true;
            this.btnEliminar.Enabled = false;
            this.btnModificar.Enabled = false;
            this.gbxConfirmarAccion.Enabled = false;
            this.gbxBuscador.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this._clientes.apellido = this.txtApellido.Text;
            this._clientes.nombre = this.txtNombre.Text;
            this._clientes.dni = this.txtDni.Text;
            this._clientes.cel = this.txtCel.Text;
            this._clientes.tel = this.txtTel.Text;
            this._clientes.correo = this.txtEmail.Text;
            this._clientes.calle = this.txtCalle.Text;
            this._clientes.numero = this.txtNumero.Text;
            this._clientes.piso = this.txtPiso.Text;
            this._clientes.dpto = this.txtDpto.Text;
            this._clientes.idtiposervicio = this.cbTipoServicio.SelectedValue.ToString();
            this._clientes.numreferencia = this.txtNumReferencia.Text;
            this._clientes.observacion = this.txtObservacion.Text;
            this._clientes.fechaingreso = DateTime.Now.ToString("yyyy/MM/dd");
            this._clientes.fechaegreso = DateTime.Now.ToString("yyyy/MM/dd");
           
            this._clientes.idtipopersona = "2";
            this._clientes.accion = this.bandera;
            this._clientes.fechaaccion = DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss");
            
            this.dgvClientes.DataSource = this._clientes.ABMPersona(this._clientes, "accion");
            this.dgvClientes.DataMember = "accion";

            if (this.dgvClientes.Rows.Count > 0)
            {
                this.dgvClientes.Columns[0].Visible = false;
                MessageBox.Show("Acción realizada con exito", "Atención!!!");

                this.btnCancelar_Click(sender, e);
            }
            else
            {
                if (this._clientes.accion == "B")
                {
                    MessageBox.Show("Acción realizada con exito", "Atención!!!");

                    this.btnCancelar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Error en la ejecución de la acción en curso. Controle datos!!!", "Error!!!");
                }
            }
        }
    }
}
